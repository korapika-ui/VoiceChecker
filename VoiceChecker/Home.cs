using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoiceChecker.Properties;

namespace VoiceChecker
{
    public enum FileTransferType
    {
        Good = 1,
        Sus = 2,
        Trash = 3
    }
    public partial class Home : Form
    {
        private Dictionary<string, FileTransferType> archive = new Dictionary<string, FileTransferType>();

        public string AudioType = ".wav";
        private double speed = 1.0; // 1.0 normal 


        History history;

        public string folderPath = "";

        private List<string> titles;
        private List<string> files;

        private int currentIndex = -1;
        private bool textChanged;


        public Home()
        {
            InitializeComponent();
            history = new History(this);
        }

        private void LoadData()
        {
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("تکایە فۆڵدەرێکی تەواو دیاری بکە");
                return;
            }

            titles = new List<string>();
            files = new List<string>();

            foreach (string file in Directory.EnumerateFiles(folderPath, "*.txt"))
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                //check if any audio files exist
                if (!FileExists(folderPath, fileName, ".wav") &&
                    !FileExists(folderPath, fileName, ".mp3"))
                {
                    MessageBox.Show(fileName + "ئەم فایلە دەنگی نیە، لێرەدا رادەوستێت ");
                    return;
                }


                // this is garbage way of doing this, but i am too lazy to do it the right way :)
                if (FileExists(folderPath, fileName, ".wav"))
                {
                    AudioType = ".wav";
                }
                else if (FileExists(folderPath, fileName, ".mp3"))
                {
                    AudioType = ".mp3";
                }




                string contents = File.ReadAllText(file);
                titles.Add(contents);
                files.Add(fileName);
            }


            currentIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    folderPath = fbd.SelectedPath;
                    UpdateFolderPath();

                    LoadData();
                    LoadNextFile();
                }
            }


        }

        private void UpdateFolderPath()
        {
            Settings.Default["folderPath"] = folderPath;
            Settings.Default.Save();

            txtCurrentFolder.Text = Settings.Default["folderPath"].ToString();
            GenerateInformation();
        }

        //load next file
        private void LoadNextFile()
        {
            if (!Directory.Exists(folderPath))
            {
                return;
            }

            if (currentIndex + 1 >= files.Count)
            {
                currentIndex++;
                return;
            }

            currentIndex++;
            txtTitle.Text = titles[currentIndex];
            PlayAudio(GetWavPath(currentIndex));
            GenerateInformation();
            this.Text = files[currentIndex];
        }

        private void PlayAudio(string path)
        {
            mediaPlayer.settings.rate = speed;

            UpdateSpeedTxt();

            mediaPlayer.URL = path;
            mediaPlayer.Ctlcontrols.play();


            //var soundPlayer = new System.Media.SoundPlayer
            //{
            //    SoundLocation = path
            //};
            //soundPlayer.Play();
        }



        private void StopPlayingMediea()
        {
            mediaPlayer.Ctlcontrols.stop();
        }

        private void ValidateText()
        {
            if (textChanged)
            {
                File.WriteAllText($"{folderPath}/{files[currentIndex]}.txt", txtTitle.Text);
                textChanged = false;
            }
        }

        private void MoveFile(string path, string path2)
        {
            File.Move(path, path2);
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            if (currentIndex == -1 || currentIndex >= files.Count)
            {
                MessageBox.Show("تکایە فۆڵدەرێکی تەواو دیاری بکە");
                return;
            }

            StopPlayingMediea();

            ValidateText();
            Directory.CreateDirectory($"{folderPath}/Good");

            string root1 = $"{folderPath}/{files[currentIndex]}.txt";
            string root2 = $"{folderPath}/{files[currentIndex]}{AudioType}";

            string dest1 = $"{folderPath}/Good/{files[currentIndex]}.txt";
            string dest2 = $"{folderPath}/Good/{files[currentIndex]}{AudioType}";

            archive.Add(files[currentIndex], FileTransferType.Good);
            UpdateHitory();

            Task.Run(() => MoveFile(root1, dest1));
            Task.Run(() => MoveFile(root2, dest2));

            LoadNextFile();
        }

        private void btnSus_Click(object sender, EventArgs e)
        {
            if (currentIndex == -1 || currentIndex >= files.Count)
            {
                MessageBox.Show("تکایە فۆڵدەرێکی تەواو دیاری بکە");
                return;
            }
            StopPlayingMediea();

            Directory.CreateDirectory($"{folderPath}/Sus");

            string root1 = $"{folderPath}/{files[currentIndex]}.txt";
            string root2 = $"{folderPath}/{files[currentIndex]}{AudioType}";

            string dest1 = $"{folderPath}/Sus/{files[currentIndex]}.txt";
            string dest2 = $"{folderPath}/Sus/{files[currentIndex]}{AudioType}";


            Task.Run(() => MoveFile(root1, dest1));
            Task.Run(() => MoveFile(root2, dest2));

            archive.Add(files[currentIndex], FileTransferType.Sus);
            UpdateHitory();


            LoadNextFile();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            if (currentIndex == -1 || currentIndex >= files.Count)
            {
                MessageBox.Show("تکایە فۆڵدەرێکی تەواو دیاری بکە");
                return;
            }
            StopPlayingMediea();

            Directory.CreateDirectory($"{folderPath}/Trash");

            string root1 = $"{folderPath}/{files[currentIndex]}.txt";
            string root2 = $"{folderPath}/{files[currentIndex]}{AudioType}";

            string dest1 = $"{folderPath}/Trash/{files[currentIndex]}.txt";
            string dest2 = $"{folderPath}/Trash/{files[currentIndex]}{AudioType}";


            Task.Run(() => MoveFile(root1, dest1));
            Task.Run(() => MoveFile(root2, dest2));

            archive.Add(files[currentIndex], FileTransferType.Trash);
            UpdateHitory();


            LoadNextFile();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadNextFile();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            if (currentIndex == -1 || currentIndex >= files.Count)
                return;
            var path = GetWavPath(currentIndex);
            if (path == null)
                return;

            PlayAudio(path);
        }

        private void GenerateInformation()
        {
            var st = new StringBuilder();

            if (Directory.Exists(folderPath))
            {
                var rootCount = Directory.GetFiles(folderPath, "*.txt", SearchOption.TopDirectoryOnly).Count();

                st.AppendLine("کۆی " + (rootCount).ToString() + "تێکست بوونی هەیە");

            }

            if (Directory.Exists(folderPath + "/Good"))
            {
                var goodCount = Directory.GetFiles(folderPath + "/Good", "*.txt", SearchOption.TopDirectoryOnly).Count();
                st.AppendLine("کۆی" + (goodCount).ToString() + "فایلی باش هەیە");
            }

            if (Directory.Exists(folderPath + "/Trash"))
            {
                var goodCount = Directory.GetFiles(folderPath + "/Trash", "*.txt", SearchOption.TopDirectoryOnly).Count();
                st.AppendLine("کۆی" + (goodCount).ToString() + "فایلی خەراپ هەیە");
            }

            txtInfo.Text = st.ToString();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }

        private string GetWavPath(int index)
        {
            if (!Directory.Exists(folderPath))
            {
                return null;
            }

            return folderPath + "/" + files[index] + AudioType;
        }

        /// <summary>
        /// Open the current folder 
        /// </summary>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderPath))
            {
                return;
            }

            Process.Start(folderPath);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            var info = new Information();
            info.ShowDialog();
        }

        private bool FileExists(string path)
        {
            return File.Exists(path);
        }

        private bool FileExists(string path, string fileName, string format)
        {
            return FileExists(path + "/" + fileName + format);
        }
        private void Home_Load(object sender, EventArgs e)
        {
            folderPath = Settings.Default["folderPath"].ToString();
            txtCurrentFolder.Text = folderPath;

            LoadData();
            GenerateInformation();
            LoadNextFile();

            mainTip.SetToolTip(btnGood, "فایلەکە بگوازەوە بۆ فۆلدەری باش");
            mainTip.SetToolTip(btnSus, "فایلەکە بگوازەوە بۆ فۆڵدەری گومان");
            mainTip.SetToolTip(btnTrash, "فایلەکە بگوازەوە بۆ فۆڵدەری زبڵ");

            mainTip.SetToolTip(btnChangeFolder, "فۆڵدەرێک دیارە بکە کە فایلە تێکست و دەنگەکان دیاری بکە");
            mainTip.SetToolTip(btnLoad, "فایلی داهاتوو بهێنە(تکایە ئاگاداربە ئەمە دووگمەیە دامەگرە تەنها ئەو کاتەنەبێ کە فۆڵدەرت گۆریەو و دەنگەکە بۆخۆی کار ناکا");
            mainTip.SetToolTip(btnOpen, "فۆلدەرکەم بۆ بکەوە");
            mainTip.SetToolTip(btnRepeat, "دەنگەکە دووبارەبکەوە");

        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            if (speed > 2)
                return;

            speed += 0.25;
            mediaPlayer.settings.rate = speed;

            UpdateSpeedTxt();
        }


        private void btnSlow_Click(object sender, EventArgs e)
        {
            if (speed <= 0.25)
                return;

            speed -= 0.25;
            mediaPlayer.settings.rate = speed;

            UpdateSpeedTxt();

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            speed = 1.0;
            mediaPlayer.settings.rate = speed;

            UpdateSpeedTxt();
        }


        private void UpdateSpeedTxt()
        {
            txtSpeed.Text = speed.ToString();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var history = new History(this);
            this.history = history;

            UpdateHitory();
            history.Show();

        }


        private void UpdateHitory()
        {
            history.LoadData(archive);
        }
    }
}

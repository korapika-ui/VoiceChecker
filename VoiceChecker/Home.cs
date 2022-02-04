using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoiceChecker.Properties;

namespace VoiceChecker
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private string folderPath = "";

        private List<string> titles;
        private List<string> files;

        private int currentIndex = -1;
        private bool textChanged;

        private void Form1_Load(object sender, EventArgs e)
        {

            

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
                if (!FileExists(folderPath + "/" + fileName + ".wav"))
                {
                    MessageBox.Show("ئەم فۆڵدەرە تەواو نیە");
                    return;
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
                }
            }

            LoadData();
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
        }

        private void PlayAudio(string path)
        {
            var soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.SoundLocation = path;
            soundPlayer.Play();
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            if (currentIndex == -1 || currentIndex >= files.Count)
            {
                MessageBox.Show("تکایە فۆڵدەرێکی تەواو دیاری بکە");
                return;
            }

            ValidateText();
            Directory.CreateDirectory($"{folderPath}/Good");

            string root1 = $"{folderPath}/{files[currentIndex]}.txt";
            string root2 = $"{folderPath}/{files[currentIndex]}.wav";

            string dest1 = $"{folderPath}/Good/{files[currentIndex]}.txt";
            string dest2 = $"{folderPath}/Good/{files[currentIndex]}.wav";


            MoveFile(root1, dest1);
            MoveFile(root2, dest2);

            LoadNextFile();
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

        private void btnSus_Click(object sender, EventArgs e)
        {
            if (currentIndex == -1 || currentIndex >= files.Count)
            {
                MessageBox.Show("تکایە فۆڵدەرێکی تەواو دیاری بکە");
                return;
            }

            Directory.CreateDirectory($"{folderPath}/Sus");

            string root1 = $"{folderPath}/{files[currentIndex]}.txt";
            string root2 = $"{folderPath}/{files[currentIndex]}.wav";

            string dest1 = $"{folderPath}/Sus/{files[currentIndex]}.txt";
            string dest2 = $"{folderPath}/Sus/{files[currentIndex]}.wav";


            MoveFile(root1, dest1);
            MoveFile(root2, dest2);

            LoadNextFile();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            if (currentIndex == -1 || currentIndex >= files.Count)
            {
                MessageBox.Show("تکایە فۆڵدەرێکی تەواو دیاری بکە");
                return;
            }

            Directory.CreateDirectory($"{folderPath}/Trash");

            string root1 = $"{folderPath}/{files[currentIndex]}.txt";
            string root2 = $"{folderPath}/{files[currentIndex]}.wav";

            string dest1 = $"{folderPath}/Trash/{files[currentIndex]}.txt";
            string dest2 = $"{folderPath}/Trash/{files[currentIndex]}.wav";


            MoveFile(root1, dest1);
            MoveFile(root2, dest2);

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
            return folderPath + "/" + files[index] + ".wav";
        }

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
    }
}

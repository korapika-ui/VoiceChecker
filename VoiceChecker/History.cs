using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceChecker
{

    public partial class History : Form
    {
        private readonly Home parent;

        public History(Home parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void History_Load(object sender, EventArgs e)
        {

        }

        public void LoadData(Dictionary<string, FileTransferType> data)
        {
            listbox.Items.Clear();
            foreach (var item in data.Reverse())
            {
                listbox.Items.Add(item.Key + ":----->:" + item.Value);
            }
        }

        private void listbox_DoubleClick(object sender, EventArgs e)
        {
            var value = listbox.SelectedItem.ToString();
            var values = value.Split(':');

            var id = values[0];
            var parentPath = values[2];

            var filePath = $"{parent.folderPath}/{parentPath}/{id}.txt";

            // suppose that we have a test.txt at E:\
            if (!File.Exists(filePath))
            {
                return;
            }

            System.Diagnostics.Process.Start(filePath);

        }
    }
}

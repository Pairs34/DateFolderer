using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DateFolderer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSelectFileDir_Click(object sender, EventArgs e)
        {
            try
            {
                folderSelector.Description = "Dosya dizinini seçiniz";
                var dialogResult = folderSelector.ShowDialog();
                if (dialogResult == DialogResult.OK && !String.IsNullOrEmpty(folderSelector.SelectedPath))
                {
                    txtFileDir.Text = folderSelector.SelectedPath;
                    int fileCount = Directory.GetFiles(folderSelector.SelectedPath, "*", SearchOption.AllDirectories)
                        .Length;
                    lblCountOfFile.Visible = fileCount > 0 ? true : false;
                    lblCountOfFile.Text = String.Format("{0} adet dosya bulundu", fileCount);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnSaveDir_Click(object sender, EventArgs e)
        {
            try
            {
                folderSelector.Description = "Dosya dizinini seçiniz";
                var dialogResult = folderSelector.ShowDialog();
                if (dialogResult == DialogResult.OK && !String.IsNullOrEmpty(folderSelector.SelectedPath))
                {
                    txtSaveDir.Text = folderSelector.SelectedPath;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var allFiles = Directory.GetFiles(txtFileDir.Text, "*", SearchOption.AllDirectories);
            foreach (var file in allFiles)
            {
                var fileDate = File.GetCreationTime(file);
                CheckOrCreateDir($"{txtSaveDir.Text}\\{fileDate.Year}");
                CheckOrCreateDir($"{txtSaveDir.Text}\\{fileDate.Year}\\{fileDate.Month}");
                CheckOrCreateDir($"{txtSaveDir.Text}\\{fileDate.Year}\\{fileDate.Month}\\{fileDate.Day}");
                string DestinationPath = $"{txtSaveDir.Text}\\{fileDate.Year}\\{fileDate.Month}\\{fileDate.Day}";
                File.Copy(file, DestinationPath + "\\" + Path.GetFileName(file),true);
            }

            MessageBox.Show("Aktarım tamamlandı.");
        }

        public void CheckOrCreateDir(string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}

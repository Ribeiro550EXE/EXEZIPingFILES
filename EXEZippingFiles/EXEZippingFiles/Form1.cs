using System.Diagnostics;
using System.IO.Compression;

namespace EXEZippingFiles
{
    public partial class Form1 : Form
    {
        string path = Environment.CurrentDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void CHFolderBT_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlgFolder = new FolderBrowserDialog())
            {
                if (dlgFolder.ShowDialog() == DialogResult.OK)
                {
                    ZipParent(dlgFolder.SelectedPath);
                }


            }
        }
        private void ZipParent(string fpath)
        {
            string zipparent = Path.GetDirectoryName(fpath);
            Process.Start("explorer.exe", zipparent);
            string zipname = Path.GetFileName(fpath);
            string zipfilename = Path.Combine(zipparent, zipname + ".zip");
            ZipFile.CreateFromDirectory(fpath, zipfilename, CompressionLevel.Fastest, true);

            LBShowPath.Text = "Zipped -_- " + fpath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LOGOPICTURE.Image = Image.FromFile(path + "\\IMG\\LOGOCOMPANY.png");
        }
    }
}

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

namespace CopyApp01
{
    public partial class CopyMainForm : Form
    {
        private string sourceFile;
        private string destFile;
        public CopyMainForm()
        {
            InitializeComponent();
        }

        private void btnSrcFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK) 
                { 
                    sourceFile = openFileDialog.FileName;
                    lblSrcPath.Text = sourceFile;
                }
            }
        }

        private void btnDstFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    destFile = saveFileDialog.FileName;
                    File.Copy(sourceFile, destFile, true); // 혹시 파일이 있을경우 덮어쓰기
                    lblDstPath.Text = "복사완료 !!"+destFile;
                }
            }
        }
    }
}

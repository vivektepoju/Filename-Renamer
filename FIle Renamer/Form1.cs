using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Renamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if ((txtTrim.Text != "" && txtTrim.Text != "0") || txtAppend.Text != "" || chkReplace.Checked)
            {
                if (txtTrim.Text == "") txtTrim.Text = "0";

                var result = MessageBox.Show("Continue ?", "Are you sure you want to Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    rtbFilesToBeNamed.Text = "Renamed File Names :\n";
                    string[] filePaths;

                    if(chkZipFiles.Checked)
                        filePaths = Directory.GetFiles(txtPath.Text, "*.zip");
                    else
                        filePaths = Directory.GetFiles(txtPath.Text);

                    foreach (var filename in filePaths)
                    {
                        string FileExt = Path.GetExtension(filename);
                        string fileRename = filename.Substring(0, filename.Length - FileExt.Length - Convert.ToInt32(txtTrim.Text)) + txtAppend.Text + FileExt;
                        //string fileRename = filename.Substring(0, filename.Length - filename.Split('.')[1].Length - 1 - Convert.ToInt32(txtTrim.Text)) + txtAppend.Text + "." + filename.Split('.')[1];
                        if (chkReplace.Checked)
                        {
                            fileRename=fileRename.Replace(txtReplaceFrom.Text, txtReplaceWith.Text);
                        }
                        File.Move(filename, fileRename);
                        rtbFilesToBeNamed.AppendText(fileRename + "\n");
                    }
                }
            }
            else
                MessageBox.Show("No Inputs provided!!!");
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            

            if (txtTrim.Text == "") txtTrim.Text = "0";

            string[] filePaths;

            if(chkZipFiles.Checked)
                filePaths = Directory.GetFiles(txtPath.Text, "*.zip");
            else
                filePaths = Directory.GetFiles(txtPath.Text);

            rtbFilesToBeNamed.Text = "After Renameing File names will be:\n";
            foreach (var filename in filePaths)
            {
                string FileExt =Path.GetExtension(filename);
                string fileRename = filename.Substring(0, filename.Length - FileExt.Length - Convert.ToInt32(txtTrim.Text)) + txtAppend.Text + FileExt;
                if (chkReplace.Checked)
                {
                    fileRename=fileRename.Replace(txtReplaceFrom.Text, txtReplaceWith.Text);
                }
                rtbFilesToBeNamed.AppendText(fileRename+ "\n");
            }
            
        }

        private void ChkReplace_CheckedChanged(object sender, EventArgs e)
        {
            if(chkReplace.Checked)
            {
                txtReplaceFrom.Enabled = true;
                txtReplaceWith.Enabled = true;
            }
            else
            {
                txtReplaceFrom.Enabled = false;
                txtReplaceWith.Enabled = false;
            }
        }
    }
}

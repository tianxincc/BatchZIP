using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BatchZIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //EnterPath.Text = @"D:\测试";
            //OutPath.Text = @"C:\Users\champion\Desktop\新建文件夹";
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            EnterPath.Text=GetPath();
        }
        private void BtnOpenOut_Click(object sender, EventArgs e)
        {
            OutPath.Text = GetPath();
        }

        private string GetPath() 
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            return string.IsNullOrWhiteSpace(folder.SelectedPath) ? "" : folder.SelectedPath;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (!FileHelper.IsExistDirectory(EnterPath.Text) && !FileHelper.IsExistDirectory(OutPath.Text))
            {
                MessageBox.Show("请输入合法的路径。");
                return;
            }
            Thread thread = new Thread(new ThreadStart(ThreadZip));
            thread.Start();

            MessageBox.Show("压缩成功");
        }

        private void ThreadZip()
        {
            var FileList = FileHelper.GetDirectories(EnterPath.Text);
            //创建一个文件夹用作输入目录
            var zipout = $@"{OutPath.Text}\{CommonStatus.OutPath}";
            FileHelper.CreateDirectory(zipout);
            foreach (var item in FileList)
            {
                var guid = Guid.NewGuid();
                ZipHelper.CreateZip(item, $@"{zipout}\{guid}.zip");
                var md5 = FileHelper.GetMD5HashFromFile($@"{zipout}\{guid}.zip");
                File.Move($@"{zipout}\{guid}.zip", $@"{zipout}\{md5}.zip");
                var source = new DirectoryInfo($@"{zipout}\");
                if (ckCustom.Checked)
                {
                    var fileList = source.GetFiles();
                    var DateStr = FileHelper.FileToString($@"{ Directory.GetCurrentDirectory()}\ReplaceDateTime.txt");
                    var Datesplit = DateStr.Split("卍".ToCharArray());
                    for (int i = 0; i < fileList.Length; i++)
                    {
                        fileList[i].CreationTime = DateTime.Parse(Datesplit[i].TrimEnd());
                        fileList[i].LastWriteTime = DateTime.Parse(Datesplit[i].TrimEnd());
                    }
                }
            }

        }




    }
}

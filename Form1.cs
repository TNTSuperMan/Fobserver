﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fobserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fsw.Path = Path.GetTempPath();
            fsw.NotifyFilter = NotifyFilters.Size | NotifyFilters.LastWrite;
            
            log("監視システムが起動されました");
        }
        string nowpath;

        private void reference(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                observepath.Text = ofd.FileName;
            }
        }

        private void detect(object sender, FileSystemEventArgs e)
        {
            if(e.FullPath == nowpath)
            {
                updfd();
                log("監視ファイルの変更を検出しました");
                if (ecb.Checked)
                {
                    ni.BalloonTipText = "監視ファイル\"" + Path.GetFileName(nowpath) + "\"の変更を検出しました";
                    ni.BalloonTipTitle = "監視ファイルの変更を検出!";
                    ni.ShowBalloonTip(5000);
                }
            }
           
        }

        private void changepath(object sender, EventArgs e)
        {
            nowpath = Path.GetFullPath(observepath.Text);
            fsw.Path = Path.GetDirectoryName(nowpath);
            updfd();
            log("監視するファイルを変更されました");
        }
        private void log(string message)
        {
            obslog.Text += "("+ DateTime.Now.ToString() + ")\n" + message + "\n\n";
        }
        private void updfd()
        {
            Thread.Sleep(100);
            try
            {
                using (StreamReader r = new StreamReader(fsw.Path))
                {
                    fcontent.Text = r.ReadToEnd();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void clslog(object sender, EventArgs e)
        {
            fcontent.Text = string.Empty;
        }

        private void delete(object sender, FileSystemEventArgs e)
        {
            log("監視ファイルが削除されました");
            fcontent.Text = "";
        }

        private void create(object sender, FileSystemEventArgs e)
        {
            log("監視ファイルが作られました");
            updfd();
        }
    }
}

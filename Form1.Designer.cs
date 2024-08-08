namespace Fobserver
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fsw = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.observepath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.obslog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fcontent = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ni = new System.Windows.Forms.NotifyIcon(this.components);
            this.ecb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.SuspendLayout();
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fsw.Path = "C:\\Users\\broke\\霊夢立ち絵（作ふにちか）zip版";
            this.fsw.SynchronizingObject = this;
            this.fsw.Changed += new System.IO.FileSystemEventHandler(this.detect);
            this.fsw.Created += new System.IO.FileSystemEventHandler(this.create);
            this.fsw.Deleted += new System.IO.FileSystemEventHandler(this.delete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "監視対象";
            // 
            // observepath
            // 
            this.observepath.BackColor = System.Drawing.Color.Black;
            this.observepath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.observepath.ForeColor = System.Drawing.Color.Green;
            this.observepath.Location = new System.Drawing.Point(89, 6);
            this.observepath.Name = "observepath";
            this.observepath.Size = new System.Drawing.Size(409, 23);
            this.observepath.TabIndex = 1;
            this.observepath.TextChanged += new System.EventHandler(this.changepath);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(504, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "参照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reference);
            // 
            // ofd
            // 
            this.ofd.Filter = "全てのファイル|*.*";
            // 
            // obslog
            // 
            this.obslog.BackColor = System.Drawing.Color.Black;
            this.obslog.ForeColor = System.Drawing.Color.Green;
            this.obslog.Location = new System.Drawing.Point(15, 60);
            this.obslog.Name = "obslog";
            this.obslog.ReadOnly = true;
            this.obslog.Size = new System.Drawing.Size(185, 378);
            this.obslog.TabIndex = 3;
            this.obslog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "監視ログ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(207, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "監視ファイルの状態";
            // 
            // fcontent
            // 
            this.fcontent.BackColor = System.Drawing.Color.Black;
            this.fcontent.ForeColor = System.Drawing.Color.Green;
            this.fcontent.Location = new System.Drawing.Point(210, 51);
            this.fcontent.Name = "fcontent";
            this.fcontent.ReadOnly = true;
            this.fcontent.Size = new System.Drawing.Size(578, 387);
            this.fcontent.TabIndex = 6;
            this.fcontent.Text = "";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(81, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "ログを消去";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clslog);
            // 
            // ni
            // 
            this.ni.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ni.BalloonTipTitle = "ファイル監視システム";
            this.ni.Icon = ((System.Drawing.Icon)(resources.GetObject("ni.Icon")));
            this.ni.Text = "Fobserver";
            this.ni.Visible = true;
            // 
            // ecb
            // 
            this.ecb.AutoSize = true;
            this.ecb.ForeColor = System.Drawing.Color.Green;
            this.ecb.Location = new System.Drawing.Point(560, 9);
            this.ecb.Name = "ecb";
            this.ecb.Size = new System.Drawing.Size(81, 16);
            this.ecb.TabIndex = 8;
            this.ecb.Text = "変更を通知";
            this.ecb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ecb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fcontent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.obslog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.observepath);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.TextBox observepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox obslog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox fcontent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon ni;
        private System.Windows.Forms.CheckBox ecb;
    }
}


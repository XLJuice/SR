namespace SR
{
    partial class Downloader
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Downloader));
            this.url = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnpath = new System.Windows.Forms.Button();
            this.hint = new System.Windows.Forms.ToolTip(this.components);
            this.tlstrp = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.strpbtnpath = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnstrp = new System.Windows.Forms.MenuStrip();
            this.strpbtndownload = new System.Windows.Forms.ToolStripButton();
            this.strpbtnclear = new System.Windows.Forms.ToolStripButton();
            this.strpbtnexit = new System.Windows.Forms.ToolStripButton();
            this.strpbtninfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrptbabout = new System.Windows.Forms.ToolStripTextBox();
            this.tlstrptbpath = new System.Windows.Forms.ToolStripTextBox();
            this.tlstrptbdownload = new System.Windows.Forms.ToolStripTextBox();
            this.tlstrptbclear = new System.Windows.Forms.ToolStripTextBox();
            this.tlstrptbexit = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrp.SuspendLayout();
            this.mnstrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(78, 55);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(252, 20);
            this.url.TabIndex = 0;
            this.hint.SetToolTip(this.url, "Enter file\'s link");
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(78, 81);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(252, 20);
            this.path.TabIndex = 1;
            this.hint.SetToolTip(this.path, "Enter file\'s path");
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(78, 107);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(252, 20);
            this.fname.TabIndex = 2;
            this.hint.SetToolTip(this.fname, "Enter file\'s name");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 85);
            this.button1.TabIndex = 3;
            this.button1.Text = "Download";
            this.hint.SetToolTip(this.button1, "Click to download file");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Link:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(120, 247);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(271, 20);
            this.status.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 85);
            this.button2.TabIndex = 8;
            this.button2.Text = "One more";
            this.hint.SetToolTip(this.button2, "Click to clean all textboxes and download new file");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button3.Location = new System.Drawing.Point(161, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 78);
            this.button3.TabIndex = 9;
            this.button3.Text = "Exit";
            this.hint.SetToolTip(this.button3, "Click to exit");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnpath
            // 
            this.btnpath.Location = new System.Drawing.Point(336, 81);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(192, 23);
            this.btnpath.TabIndex = 10;
            this.btnpath.Text = "Path";
            this.hint.SetToolTip(this.btnpath, "Click to choose download path ");
            this.btnpath.UseVisualStyleBackColor = true;
            this.btnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // tlstrp
            // 
            this.tlstrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpbtndownload,
            this.toolStripSeparator1,
            this.strpbtnpath,
            this.toolStripSeparator3,
            this.strpbtnclear,
            this.toolStripSeparator2,
            this.strpbtnexit,
            this.strpbtninfo});
            this.tlstrp.Location = new System.Drawing.Point(0, 24);
            this.tlstrp.Name = "tlstrp";
            this.tlstrp.Size = new System.Drawing.Size(537, 25);
            this.tlstrp.TabIndex = 11;
            this.tlstrp.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // strpbtnpath
            // 
            this.strpbtnpath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strpbtnpath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpbtnpath.Name = "strpbtnpath";
            this.strpbtnpath.Size = new System.Drawing.Size(78, 22);
            this.strpbtnpath.Text = "Choose path";
            this.strpbtnpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mnstrp
            // 
            this.mnstrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnstrp.Location = new System.Drawing.Point(0, 0);
            this.mnstrp.Name = "mnstrp";
            this.mnstrp.Size = new System.Drawing.Size(537, 24);
            this.mnstrp.TabIndex = 12;
            this.mnstrp.Text = "menuStrip1";
            // 
            // strpbtndownload
            // 
            this.strpbtndownload.Image = global::SR.Properties.Resources.arrow;
            this.strpbtndownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpbtndownload.Name = "strpbtndownload";
            this.strpbtndownload.Size = new System.Drawing.Size(81, 22);
            this.strpbtndownload.Text = "Download";
            this.strpbtndownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // strpbtnclear
            // 
            this.strpbtnclear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strpbtnclear.Image = ((System.Drawing.Image)(resources.GetObject("strpbtnclear.Image")));
            this.strpbtnclear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpbtnclear.Name = "strpbtnclear";
            this.strpbtnclear.Size = new System.Drawing.Size(38, 22);
            this.strpbtnclear.Text = "Clear";
            this.strpbtnclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // strpbtnexit
            // 
            this.strpbtnexit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.strpbtnexit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strpbtnexit.Image = global::SR.Properties.Resources.images;
            this.strpbtnexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpbtnexit.Name = "strpbtnexit";
            this.strpbtnexit.Size = new System.Drawing.Size(23, 22);
            this.strpbtnexit.Text = "Exit";
            this.strpbtnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // strpbtninfo
            // 
            this.strpbtninfo.Image = global::SR.Properties.Resources.About;
            this.strpbtninfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strpbtninfo.Name = "strpbtninfo";
            this.strpbtninfo.Size = new System.Drawing.Size(60, 22);
            this.strpbtninfo.Text = "About";
            this.strpbtninfo.Click += new System.EventHandler(this.strpbtninfo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrptbabout,
            this.toolStripSeparator4,
            this.tlstrptbpath,
            this.toolStripSeparator5,
            this.tlstrptbdownload,
            this.toolStripSeparator6,
            this.tlstrptbclear,
            this.toolStripSeparator7,
            this.tlstrptbexit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tlstrptbabout
            // 
            this.tlstrptbabout.Name = "tlstrptbabout";
            this.tlstrptbabout.ReadOnly = true;
            this.tlstrptbabout.Size = new System.Drawing.Size(100, 23);
            this.tlstrptbabout.Text = "About";
            this.tlstrptbabout.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlstrptbabout.Click += new System.EventHandler(this.strpbtninfo_Click);
            // 
            // tlstrptbpath
            // 
            this.tlstrptbpath.Name = "tlstrptbpath";
            this.tlstrptbpath.ReadOnly = true;
            this.tlstrptbpath.Size = new System.Drawing.Size(100, 23);
            this.tlstrptbpath.Text = "Choose path";
            this.tlstrptbpath.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlstrptbpath.Click += new System.EventHandler(this.btnpath_Click);
            // 
            // tlstrptbdownload
            // 
            this.tlstrptbdownload.Name = "tlstrptbdownload";
            this.tlstrptbdownload.ReadOnly = true;
            this.tlstrptbdownload.Size = new System.Drawing.Size(100, 23);
            this.tlstrptbdownload.Text = "Download";
            this.tlstrptbdownload.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlstrptbdownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlstrptbclear
            // 
            this.tlstrptbclear.Name = "tlstrptbclear";
            this.tlstrptbclear.ReadOnly = true;
            this.tlstrptbclear.Size = new System.Drawing.Size(100, 23);
            this.tlstrptbclear.Text = "Clear";
            this.tlstrptbclear.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlstrptbclear.Click += new System.EventHandler(this.button2_Click);
            // 
            // tlstrptbexit
            // 
            this.tlstrptbexit.Name = "tlstrptbexit";
            this.tlstrptbexit.ReadOnly = true;
            this.tlstrptbexit.Size = new System.Drawing.Size(100, 23);
            this.tlstrptbexit.Text = "Exit";
            this.tlstrptbexit.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tlstrptbexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(537, 385);
            this.Controls.Add(this.tlstrp);
            this.Controls.Add(this.mnstrp);
            this.Controls.Add(this.btnpath);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.path);
            this.Controls.Add(this.url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnstrp;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader 9999";
            this.tlstrp.ResumeLayout(false);
            this.tlstrp.PerformLayout();
            this.mnstrp.ResumeLayout(false);
            this.mnstrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnpath;
        private System.Windows.Forms.ToolTip hint;
        private System.Windows.Forms.ToolStrip tlstrp;
        private System.Windows.Forms.ToolStripButton strpbtnpath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton strpbtnclear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton strpbtndownload;
        private System.Windows.Forms.ToolStripButton strpbtnexit;
        private System.Windows.Forms.MenuStrip mnstrp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton strpbtninfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox tlstrptbabout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox tlstrptbpath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox tlstrptbdownload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox tlstrptbclear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox tlstrptbexit;
    }
}


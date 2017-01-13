namespace FileChecksum
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_BAS64 = new System.Windows.Forms.CheckBox();
            this.cb_SHA512 = new System.Windows.Forms.CheckBox();
            this.cb_SHA348 = new System.Windows.Forms.CheckBox();
            this.cb_SHA256 = new System.Windows.Forms.CheckBox();
            this.cb_SHA1 = new System.Windows.Forms.CheckBox();
            this.cb_Md5 = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_BAS64);
            this.groupBox1.Controls.Add(this.cb_SHA512);
            this.groupBox1.Controls.Add(this.cb_SHA348);
            this.groupBox1.Controls.Add(this.cb_SHA256);
            this.groupBox1.Controls.Add(this.cb_SHA1);
            this.groupBox1.Controls.Add(this.cb_Md5);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checksum options";
            // 
            // cb_BAS64
            // 
            this.cb_BAS64.AutoSize = true;
            this.cb_BAS64.Checked = true;
            this.cb_BAS64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_BAS64.Location = new System.Drawing.Point(322, 19);
            this.cb_BAS64.Name = "cb_BAS64";
            this.cb_BAS64.Size = new System.Drawing.Size(66, 17);
            this.cb_BAS64.TabIndex = 5;
            this.cb_BAS64.Text = "BASE64";
            this.cb_BAS64.UseVisualStyleBackColor = true;
            // 
            // cb_SHA512
            // 
            this.cb_SHA512.AutoSize = true;
            this.cb_SHA512.Checked = true;
            this.cb_SHA512.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_SHA512.Location = new System.Drawing.Point(253, 19);
            this.cb_SHA512.Name = "cb_SHA512";
            this.cb_SHA512.Size = new System.Drawing.Size(66, 17);
            this.cb_SHA512.TabIndex = 4;
            this.cb_SHA512.Text = "SHA512";
            this.cb_SHA512.UseVisualStyleBackColor = true;
            // 
            // cb_SHA348
            // 
            this.cb_SHA348.AutoSize = true;
            this.cb_SHA348.Checked = true;
            this.cb_SHA348.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_SHA348.Location = new System.Drawing.Point(184, 19);
            this.cb_SHA348.Name = "cb_SHA348";
            this.cb_SHA348.Size = new System.Drawing.Size(66, 17);
            this.cb_SHA348.TabIndex = 3;
            this.cb_SHA348.Text = "SHA348";
            this.cb_SHA348.UseVisualStyleBackColor = true;
            // 
            // cb_SHA256
            // 
            this.cb_SHA256.AutoSize = true;
            this.cb_SHA256.Checked = true;
            this.cb_SHA256.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_SHA256.Location = new System.Drawing.Point(115, 19);
            this.cb_SHA256.Name = "cb_SHA256";
            this.cb_SHA256.Size = new System.Drawing.Size(66, 17);
            this.cb_SHA256.TabIndex = 2;
            this.cb_SHA256.Text = "SHA256";
            this.cb_SHA256.UseVisualStyleBackColor = true;
            // 
            // cb_SHA1
            // 
            this.cb_SHA1.AutoSize = true;
            this.cb_SHA1.Checked = true;
            this.cb_SHA1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_SHA1.Location = new System.Drawing.Point(58, 19);
            this.cb_SHA1.Name = "cb_SHA1";
            this.cb_SHA1.Size = new System.Drawing.Size(54, 17);
            this.cb_SHA1.TabIndex = 1;
            this.cb_SHA1.Text = "SHA1";
            this.cb_SHA1.UseVisualStyleBackColor = true;
            // 
            // cb_Md5
            // 
            this.cb_Md5.AutoSize = true;
            this.cb_Md5.Checked = true;
            this.cb_Md5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Md5.Location = new System.Drawing.Point(6, 19);
            this.cb_Md5.Name = "cb_Md5";
            this.cb_Md5.Size = new System.Drawing.Size(49, 17);
            this.cb_Md5.TabIndex = 0;
            this.cb_Md5.Text = "MD5";
            this.cb_Md5.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Location = new System.Drawing.Point(13, 69);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 206);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SizeChanged += new System.EventHandler(this.listView1_SizeChanged);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toolStripMenuItem1.Text = "Copy Hash Value";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 287);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CheckSum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckBox cb_BAS64;
        private System.Windows.Forms.CheckBox cb_SHA512;
        private System.Windows.Forms.CheckBox cb_SHA348;
        private System.Windows.Forms.CheckBox cb_SHA256;
        private System.Windows.Forms.CheckBox cb_SHA1;
        private System.Windows.Forms.CheckBox cb_Md5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}


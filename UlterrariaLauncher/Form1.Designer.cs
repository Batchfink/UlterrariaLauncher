﻿namespace UlterrariaLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.versionBox = new System.Windows.Forms.ComboBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.installBtn = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.revertBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fdb = new System.Windows.Forms.FolderBrowserDialog();
            this.achievementsPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.achievementsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UlterrariaLauncher.Properties.Resources.UlterrariaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progLbl
            // 
            this.progLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progLbl.Location = new System.Drawing.Point(3, 254);
            this.progLbl.Name = "progLbl";
            this.progLbl.Size = new System.Drawing.Size(297, 19);
            this.progLbl.TabIndex = 3;
            this.progLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 231);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 4;
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(3, 162);
            this.progBar.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(294, 36);
            this.progBar.TabIndex = 7;
            // 
            // versionBox
            // 
            this.versionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionBox.FormattingEnabled = true;
            this.versionBox.Location = new System.Drawing.Point(3, 108);
            this.versionBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(294, 21);
            this.versionBox.TabIndex = 6;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(218, 52);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 5;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // installBtn
            // 
            this.installBtn.Location = new System.Drawing.Point(3, 3);
            this.installBtn.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(96, 43);
            this.installBtn.TabIndex = 0;
            this.installBtn.Text = "Patch version";
            this.installBtn.UseVisualStyleBackColor = true;
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.installBtn);
            this.controlPanel.Controls.Add(this.revertBtn);
            this.controlPanel.Controls.Add(this.playBtn);
            this.controlPanel.Controls.Add(this.pathBox);
            this.controlPanel.Controls.Add(this.browseBtn);
            this.controlPanel.Controls.Add(this.versionBox);
            this.controlPanel.Controls.Add(this.progBar);
            this.controlPanel.Controls.Add(this.textBox1);
            this.controlPanel.Controls.Add(this.progLbl);
            this.controlPanel.Controls.Add(this.flowLayoutPanel1);
            this.controlPanel.Location = new System.Drawing.Point(0, 256);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(300, 224);
            this.controlPanel.TabIndex = 1;
            // 
            // revertBtn
            // 
            this.revertBtn.Location = new System.Drawing.Point(102, 3);
            this.revertBtn.Name = "revertBtn";
            this.revertBtn.Size = new System.Drawing.Size(96, 43);
            this.revertBtn.TabIndex = 11;
            this.revertBtn.Text = "Revert To Vanilla";
            this.revertBtn.UseVisualStyleBackColor = true;
            this.revertBtn.Click += new System.EventHandler(this.revertBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(201, 3);
            this.playBtn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(96, 43);
            this.playBtn.TabIndex = 9;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(3, 52);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(209, 20);
            this.pathBox.TabIndex = 8;
            this.pathBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Terraria";
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 276);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // achievementsPnl
            // 
            this.achievementsPnl.AutoScroll = true;
            this.achievementsPnl.Controls.Add(this.label1);
            this.achievementsPnl.Location = new System.Drawing.Point(315, 0);
            this.achievementsPnl.Name = "achievementsPnl";
            this.achievementsPnl.Size = new System.Drawing.Size(400, 480);
            this.achievementsPnl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Achievements";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 480);
            this.Controls.Add(this.achievementsPnl);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ulterraria Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.achievementsPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label progLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.ComboBox versionBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button installBtn;
        private System.Windows.Forms.FlowLayoutPanel controlPanel;
        private System.Windows.Forms.MaskedTextBox pathBox;
        private System.Windows.Forms.FolderBrowserDialog fdb;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.FlowLayoutPanel achievementsPnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button revertBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
    }
}


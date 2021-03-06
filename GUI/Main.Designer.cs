﻿namespace GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Reponame = new System.Windows.Forms.Label();
            this.EnterRepo = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.RefreshProgress = new System.Windows.Forms.ProgressBar();
            this.Packages = new System.Windows.Forms.CheckedListBox();
            this.name = new System.Windows.Forms.Label();
            this.packageid = new System.Windows.Forms.Label();
            this.section = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.GroupBox();
            this.URL = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.md5 = new System.Windows.Forms.Label();
            this.depends = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RepoBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RefreshBar = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reponame
            // 
            this.Reponame.AutoSize = true;
            this.Reponame.Location = new System.Drawing.Point(386, 9);
            this.Reponame.Name = "Reponame";
            this.Reponame.Size = new System.Drawing.Size(118, 13);
            this.Reponame.TabIndex = 0;
            this.Reponame.Text = "Placeholder Reponame";
            // 
            // EnterRepo
            // 
            this.EnterRepo.Location = new System.Drawing.Point(527, 630);
            this.EnterRepo.Name = "EnterRepo";
            this.EnterRepo.Size = new System.Drawing.Size(207, 20);
            this.EnterRepo.TabIndex = 1;
            this.EnterRepo.Text = "https://coolstar.org/publicrepo/";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(1062, 629);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 20);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Add";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // RefreshProgress
            // 
            this.RefreshProgress.Location = new System.Drawing.Point(740, 629);
            this.RefreshProgress.MarqueeAnimationSpeed = 1;
            this.RefreshProgress.Name = "RefreshProgress";
            this.RefreshProgress.Size = new System.Drawing.Size(316, 20);
            this.RefreshProgress.TabIndex = 3;
            // 
            // Packages
            // 
            this.Packages.CheckOnClick = true;
            this.Packages.FormattingEnabled = true;
            this.Packages.Location = new System.Drawing.Point(389, 26);
            this.Packages.Name = "Packages";
            this.Packages.Size = new System.Drawing.Size(402, 574);
            this.Packages.TabIndex = 4;
            this.Packages.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Packages_ItemCheck_1);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(50, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 5;
            this.name.Text = "Name";
            // 
            // packageid
            // 
            this.packageid.AutoSize = true;
            this.packageid.Location = new System.Drawing.Point(30, 29);
            this.packageid.Name = "packageid";
            this.packageid.Size = new System.Drawing.Size(61, 13);
            this.packageid.TabIndex = 6;
            this.packageid.Text = "PackageID";
            // 
            // section
            // 
            this.section.AutoSize = true;
            this.section.Location = new System.Drawing.Point(58, 42);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(43, 13);
            this.section.TabIndex = 7;
            this.section.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Section:";
            // 
            // Info
            // 
            this.Info.Controls.Add(this.URL);
            this.Info.Controls.Add(this.label10);
            this.Info.Controls.Add(this.description);
            this.Info.Controls.Add(this.size);
            this.Info.Controls.Add(this.md5);
            this.Info.Controls.Add(this.depends);
            this.Info.Controls.Add(this.label7);
            this.Info.Controls.Add(this.label5);
            this.Info.Controls.Add(this.label6);
            this.Info.Controls.Add(this.label4);
            this.Info.Controls.Add(this.label1);
            this.Info.Controls.Add(this.section);
            this.Info.Controls.Add(this.label3);
            this.Info.Controls.Add(this.packageid);
            this.Info.Controls.Add(this.label2);
            this.Info.Controls.Add(this.name);
            this.Info.Location = new System.Drawing.Point(797, 26);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(340, 353);
            this.Info.TabIndex = 11;
            this.Info.TabStop = false;
            this.Info.Text = "Info";
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(42, 94);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(29, 13);
            this.URL.TabIndex = 19;
            this.URL.TabStop = true;
            this.URL.Text = "URL";
            this.URL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.URL_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "URL:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(75, 107);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(259, 246);
            this.description.TabIndex = 17;
            this.description.Text = "Description";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(42, 81);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(27, 13);
            this.size.TabIndex = 16;
            this.size.Text = "Size";
            // 
            // md5
            // 
            this.md5.AutoSize = true;
            this.md5.Location = new System.Drawing.Point(45, 68);
            this.md5.Name = "md5";
            this.md5.Size = new System.Drawing.Size(30, 13);
            this.md5.TabIndex = 15;
            this.md5.Text = "MD5";
            // 
            // depends
            // 
            this.depends.AutoSize = true;
            this.depends.Location = new System.Drawing.Point(65, 55);
            this.depends.Name = "depends";
            this.depends.Size = new System.Drawing.Size(50, 13);
            this.depends.TabIndex = 14;
            this.depends.Text = "Depends";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "MD5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Depends:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(527, 614);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Repo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(737, 613);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Repo load";
            // 
            // RepoBox
            // 
            this.RepoBox.FormattingEnabled = true;
            this.RepoBox.Location = new System.Drawing.Point(12, 26);
            this.RepoBox.Name = "RepoBox";
            this.RepoBox.Size = new System.Drawing.Size(371, 576);
            this.RepoBox.TabIndex = 14;
            this.RepoBox.SelectedValueChanged += new System.EventHandler(this.RepoBox_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RefreshBar
            // 
            this.RefreshBar.Location = new System.Drawing.Point(93, 630);
            this.RefreshBar.MarqueeAnimationSpeed = 1;
            this.RefreshBar.Name = "RefreshBar";
            this.RefreshBar.Size = new System.Drawing.Size(428, 23);
            this.RefreshBar.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 614);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Refresh";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1149, 661);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RefreshBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RepoBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Packages);
            this.Controls.Add(this.RefreshProgress);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.EnterRepo);
            this.Controls.Add(this.Reponame);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Main";
            this.Text = "RepositoryExplorer";
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reponame;
        private System.Windows.Forms.TextBox EnterRepo;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.ProgressBar RefreshProgress;
        private System.Windows.Forms.CheckedListBox Packages;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label packageid;
        private System.Windows.Forms.Label section;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label md5;
        private System.Windows.Forms.Label depends;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel URL;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ListBox RepoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar RefreshBar;
        private System.Windows.Forms.Label label11;
    }
}


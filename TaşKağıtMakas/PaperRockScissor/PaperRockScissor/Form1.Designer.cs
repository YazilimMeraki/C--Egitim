
namespace PaperRockScissor
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.gbxChose = new System.Windows.Forms.Panel();
            this.pbxComputer = new System.Windows.Forms.PictureBox();
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblScissors = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRock = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblScorePlayer = new System.Windows.Forms.Label();
            this.lblScoreComputer = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxChose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRock.Location = new System.Drawing.Point(6, 19);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(258, 118);
            this.btnRock.TabIndex = 0;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaper.Location = new System.Drawing.Point(270, 19);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(258, 118);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissors.BackgroundImage")));
            this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScissors.Location = new System.Drawing.Point(534, 19);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(244, 118);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // gbxChose
            // 
            this.gbxChose.Controls.Add(this.pbxComputer);
            this.gbxChose.Controls.Add(this.pbxPlayer);
            this.gbxChose.Location = new System.Drawing.Point(18, 13);
            this.gbxChose.Name = "gbxChose";
            this.gbxChose.Size = new System.Drawing.Size(786, 301);
            this.gbxChose.TabIndex = 3;
            // 
            // pbxComputer
            // 
            this.pbxComputer.Location = new System.Drawing.Point(395, 13);
            this.pbxComputer.Name = "pbxComputer";
            this.pbxComputer.Size = new System.Drawing.Size(383, 260);
            this.pbxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxComputer.TabIndex = 1;
            this.pbxComputer.TabStop = false;
            // 
            // pbxPlayer
            // 
            this.pbxPlayer.Location = new System.Drawing.Point(6, 13);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(383, 260);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPlayer.TabIndex = 0;
            this.pbxPlayer.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblScissors);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRock);
            this.groupBox1.Controls.Add(this.btnRock);
            this.groupBox1.Controls.Add(this.btnPaper);
            this.groupBox1.Controls.Add(this.btnScissors);
            this.groupBox1.Location = new System.Drawing.Point(18, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chose";
            // 
            // lblScissors
            // 
            this.lblScissors.AutoSize = true;
            this.lblScissors.Location = new System.Drawing.Point(636, 140);
            this.lblScissors.Name = "lblScissors";
            this.lblScissors.Size = new System.Drawing.Size(46, 13);
            this.lblScissors.TabIndex = 11;
            this.lblScissors.Text = "Scissors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Paper";
            // 
            // lblRock
            // 
            this.lblRock.AutoSize = true;
            this.lblRock.Location = new System.Drawing.Point(118, 140);
            this.lblRock.Name = "lblRock";
            this.lblRock.Size = new System.Drawing.Size(33, 13);
            this.lblRock.TabIndex = 9;
            this.lblRock.Text = "Rock";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(21, 335);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(65, 13);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "Your Point =";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(410, 335);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(75, 13);
            this.lblComputer.TabIndex = 6;
            this.lblComputer.Text = "Rivals  Point =";
            // 
            // lblScorePlayer
            // 
            this.lblScorePlayer.AutoSize = true;
            this.lblScorePlayer.Location = new System.Drawing.Point(92, 335);
            this.lblScorePlayer.Name = "lblScorePlayer";
            this.lblScorePlayer.Size = new System.Drawing.Size(10, 13);
            this.lblScorePlayer.TabIndex = 7;
            this.lblScorePlayer.Text = "-";
            // 
            // lblScoreComputer
            // 
            this.lblScoreComputer.AutoSize = true;
            this.lblScoreComputer.Location = new System.Drawing.Point(491, 335);
            this.lblScoreComputer.Name = "lblScoreComputer";
            this.lblScoreComputer.Size = new System.Drawing.Size(10, 13);
            this.lblScoreComputer.TabIndex = 8;
            this.lblScoreComputer.Text = "-";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(378, 528);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Score";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 572);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblScoreComputer);
            this.Controls.Add(this.lblScorePlayer);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxChose);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.gbxChose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Panel gbxChose;
        private System.Windows.Forms.PictureBox pbxComputer;
        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRock;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblScorePlayer;
        private System.Windows.Forms.Label lblScoreComputer;
        private System.Windows.Forms.Button btnClear;
    }
}


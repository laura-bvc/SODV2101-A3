namespace A03
{
    partial class PlayerCard
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
            picPlayer = new PictureBox();
            lblName = new Label();
            lblAgeTag = new Label();
            lblPtsTag = new Label();
            lblRebTag = new Label();
            lblAstTag = new Label();
            lblTeam = new Label();
            picTeam = new PictureBox();
            lblAge = new Label();
            lblPts = new Label();
            lblReb = new Label();
            lblAst = new Label();
            lblTeamTag = new Label();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTeam).BeginInit();
            SuspendLayout();
            // 
            // picPlayer
            // 
            picPlayer.Location = new Point(59, 247);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(550, 600);
            picPlayer.SizeMode = PictureBoxSizeMode.CenterImage;
            picPlayer.TabIndex = 0;
            picPlayer.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.Window;
            lblName.Location = new Point(59, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(180, 72);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblAgeTag
            // 
            lblAgeTag.AutoSize = true;
            lblAgeTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgeTag.ForeColor = SystemColors.Window;
            lblAgeTag.Location = new Point(731, 382);
            lblAgeTag.Name = "lblAgeTag";
            lblAgeTag.Size = new Size(109, 54);
            lblAgeTag.TabIndex = 2;
            lblAgeTag.Text = "Age:";
            // 
            // lblPtsTag
            // 
            lblPtsTag.AutoSize = true;
            lblPtsTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPtsTag.ForeColor = SystemColors.Window;
            lblPtsTag.Location = new Point(731, 529);
            lblPtsTag.Name = "lblPtsTag";
            lblPtsTag.Size = new Size(345, 54);
            lblPtsTag.TabIndex = 3;
            lblPtsTag.Text = "Points per Game:";
            // 
            // lblRebTag
            // 
            lblRebTag.AutoSize = true;
            lblRebTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRebTag.ForeColor = SystemColors.Window;
            lblRebTag.Location = new Point(731, 643);
            lblRebTag.Name = "lblRebTag";
            lblRebTag.Size = new Size(397, 54);
            lblRebTag.TabIndex = 4;
            lblRebTag.Text = "Rebound per Game:";
            // 
            // lblAstTag
            // 
            lblAstTag.AutoSize = true;
            lblAstTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAstTag.ForeColor = SystemColors.Window;
            lblAstTag.Location = new Point(731, 751);
            lblAstTag.Name = "lblAstTag";
            lblAstTag.Size = new Size(355, 54);
            lblAstTag.TabIndex = 5;
            lblAstTag.Text = "Assists per Game:";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeam.ForeColor = SystemColors.Window;
            lblTeam.Location = new Point(194, 156);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(123, 54);
            lblTeam.TabIndex = 6;
            lblTeam.Text = "Team";
            // 
            // picTeam
            // 
            picTeam.Location = new Point(1008, 57);
            picTeam.Name = "picTeam";
            picTeam.Size = new Size(300, 300);
            picTeam.SizeMode = PictureBoxSizeMode.Zoom;
            picTeam.TabIndex = 7;
            picTeam.TabStop = false;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = SystemColors.Window;
            lblAge.Location = new Point(830, 382);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(98, 54);
            lblAge.TabIndex = 8;
            lblAge.Text = "Age";
            // 
            // lblPts
            // 
            lblPts.AutoSize = true;
            lblPts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPts.ForeColor = SystemColors.Window;
            lblPts.Location = new Point(1069, 529);
            lblPts.Name = "lblPts";
            lblPts.Size = new Size(82, 54);
            lblPts.TabIndex = 9;
            lblPts.Text = "Pts";
            // 
            // lblReb
            // 
            lblReb.AutoSize = true;
            lblReb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReb.ForeColor = SystemColors.Window;
            lblReb.Location = new Point(1122, 643);
            lblReb.Name = "lblReb";
            lblReb.Size = new Size(95, 54);
            lblReb.TabIndex = 10;
            lblReb.Text = "Reb";
            // 
            // lblAst
            // 
            lblAst.AutoSize = true;
            lblAst.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAst.ForeColor = SystemColors.Window;
            lblAst.Location = new Point(1078, 751);
            lblAst.Name = "lblAst";
            lblAst.Size = new Size(85, 54);
            lblAst.TabIndex = 11;
            lblAst.Text = "Ast";
            // 
            // lblTeamTag
            // 
            lblTeamTag.AutoSize = true;
            lblTeamTag.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTeamTag.ForeColor = SystemColors.Window;
            lblTeamTag.Location = new Point(59, 156);
            lblTeamTag.Name = "lblTeamTag";
            lblTeamTag.Size = new Size(145, 54);
            lblTeamTag.TabIndex = 12;
            lblTeamTag.Text = "Team: ";
            // 
            // PlayerCard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1368, 912);
            Controls.Add(lblTeamTag);
            Controls.Add(lblAst);
            Controls.Add(lblReb);
            Controls.Add(lblPts);
            Controls.Add(lblAge);
            Controls.Add(picTeam);
            Controls.Add(lblTeam);
            Controls.Add(lblAstTag);
            Controls.Add(lblRebTag);
            Controls.Add(lblPtsTag);
            Controls.Add(lblAgeTag);
            Controls.Add(lblName);
            Controls.Add(picPlayer);
            Name = "PlayerCard";
            Text = "Player Card";
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTeam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPlayer;
        private Label lblName;
        private Label lblAgeTag;
        private Label lblPtsTag;
        private Label lblRebTag;
        private Label lblAstTag;
        private Label lblTeam;
        private PictureBox picTeam;
        private Label lblAge;
        private Label lblPts;
        private Label lblReb;
        private Label lblAst;
        private Label lblTeamTag;
    }
}
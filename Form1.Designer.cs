namespace Helicopter_Game_Assignment
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
            this.pictureBox_Hurdle = new System.Windows.Forms.PictureBox();
            this.pictureBox_Helicopter = new System.Windows.Forms.PictureBox();
            this.panel_rightwall = new System.Windows.Forms.Panel();
            this.panel_topwall = new System.Windows.Forms.Panel();
            this.label_Score = new System.Windows.Forms.Label();
            this.label_BestScore = new System.Windows.Forms.Label();
            this.panel_leftwall = new System.Windows.Forms.Panel();
            this.panel_bottomwall = new System.Windows.Forms.Panel();
            this.timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.pictureBox_CrashedCopter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hurdle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Helicopter)).BeginInit();
            this.panel_topwall.SuspendLayout();
            this.panel_bottomwall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CrashedCopter)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Hurdle
            // 
            this.pictureBox_Hurdle.Image = global::Helicopter_Game_Assignment.Properties.Resources.pillar;
            this.pictureBox_Hurdle.Location = new System.Drawing.Point(672, 161);
            this.pictureBox_Hurdle.Name = "pictureBox_Hurdle";
            this.pictureBox_Hurdle.Size = new System.Drawing.Size(41, 100);
            this.pictureBox_Hurdle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Hurdle.TabIndex = 1;
            this.pictureBox_Hurdle.TabStop = false;
            // 
            // pictureBox_Helicopter
            // 
            this.pictureBox_Helicopter.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Helicopter.Image = global::Helicopter_Game_Assignment.Properties.Resources.Helicopter;
            this.pictureBox_Helicopter.Location = new System.Drawing.Point(87, 186);
            this.pictureBox_Helicopter.Name = "pictureBox_Helicopter";
            this.pictureBox_Helicopter.Size = new System.Drawing.Size(73, 53);
            this.pictureBox_Helicopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Helicopter.TabIndex = 0;
            this.pictureBox_Helicopter.TabStop = false;
            // 
            // panel_rightwall
            // 
            this.panel_rightwall.BackColor = System.Drawing.Color.DarkRed;
            this.panel_rightwall.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_rightwall.Location = new System.Drawing.Point(738, 0);
            this.panel_rightwall.Name = "panel_rightwall";
            this.panel_rightwall.Size = new System.Drawing.Size(10, 489);
            this.panel_rightwall.TabIndex = 4;
            // 
            // panel_topwall
            // 
            this.panel_topwall.BackColor = System.Drawing.Color.DarkRed;
            this.panel_topwall.Controls.Add(this.label_Score);
            this.panel_topwall.Controls.Add(this.label_BestScore);
            this.panel_topwall.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topwall.Location = new System.Drawing.Point(0, 0);
            this.panel_topwall.Name = "panel_topwall";
            this.panel_topwall.Size = new System.Drawing.Size(738, 32);
            this.panel_topwall.TabIndex = 5;
            // 
            // label_Score
            // 
            this.label_Score.AutoSize = true;
            this.label_Score.BackColor = System.Drawing.Color.Transparent;
            this.label_Score.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label_Score.ForeColor = System.Drawing.Color.White;
            this.label_Score.Location = new System.Drawing.Point(506, 7);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(115, 25);
            this.label_Score.TabIndex = 5;
            this.label_Score.Text = "Current Score:";
            // 
            // label_BestScore
            // 
            this.label_BestScore.AutoSize = true;
            this.label_BestScore.BackColor = System.Drawing.Color.Transparent;
            this.label_BestScore.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label_BestScore.ForeColor = System.Drawing.Color.White;
            this.label_BestScore.Location = new System.Drawing.Point(47, 7);
            this.label_BestScore.Name = "label_BestScore";
            this.label_BestScore.Size = new System.Drawing.Size(91, 25);
            this.label_BestScore.TabIndex = 4;
            this.label_BestScore.Text = "Best Score:";
            // 
            // panel_leftwall
            // 
            this.panel_leftwall.BackColor = System.Drawing.Color.DarkRed;
            this.panel_leftwall.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_leftwall.Location = new System.Drawing.Point(0, 32);
            this.panel_leftwall.Name = "panel_leftwall";
            this.panel_leftwall.Size = new System.Drawing.Size(10, 457);
            this.panel_leftwall.TabIndex = 6;
            // 
            // panel_bottomwall
            // 
            this.panel_bottomwall.BackColor = System.Drawing.Color.DarkRed;
            this.panel_bottomwall.Controls.Add(this.pictureBox_CrashedCopter);
            this.panel_bottomwall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottomwall.Location = new System.Drawing.Point(10, 424);
            this.panel_bottomwall.Name = "panel_bottomwall";
            this.panel_bottomwall.Size = new System.Drawing.Size(728, 65);
            this.panel_bottomwall.TabIndex = 7;
            // 
            // timer_Clock
            // 
            this.timer_Clock.Enabled = true;
            this.timer_Clock.Interval = 200;
            this.timer_Clock.Tick += new System.EventHandler(this.timer_Clock_Tick);
            // 
            // button_start
            // 
            this.button_start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_start.BackColor = System.Drawing.Color.Brown;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Poppins", 10F);
            this.button_start.ForeColor = System.Drawing.Color.White;
            this.button_start.Location = new System.Drawing.Point(295, 401);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(182, 44);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // pictureBox_CrashedCopter
            // 
            this.pictureBox_CrashedCopter.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CrashedCopter.Image = global::Helicopter_Game_Assignment.Properties.Resources.CrashedCopter;
            this.pictureBox_CrashedCopter.Location = new System.Drawing.Point(70, 1);
            this.pictureBox_CrashedCopter.Name = "pictureBox_CrashedCopter";
            this.pictureBox_CrashedCopter.Size = new System.Drawing.Size(89, 57);
            this.pictureBox_CrashedCopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_CrashedCopter.TabIndex = 10;
            this.pictureBox_CrashedCopter.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Helicopter_Game_Assignment.Properties.Resources.Main_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 489);
            this.Controls.Add(this.panel_bottomwall);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.panel_leftwall);
            this.Controls.Add(this.panel_topwall);
            this.Controls.Add(this.panel_rightwall);
            this.Controls.Add(this.pictureBox_Helicopter);
            this.Controls.Add(this.pictureBox_Hurdle);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Helicopter_Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hurdle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Helicopter)).EndInit();
            this.panel_topwall.ResumeLayout(false);
            this.panel_topwall.PerformLayout();
            this.panel_bottomwall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CrashedCopter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Helicopter;
        private System.Windows.Forms.PictureBox pictureBox_Hurdle;
        private System.Windows.Forms.Panel panel_rightwall;
        private System.Windows.Forms.Panel panel_topwall;
        private System.Windows.Forms.Label label_Score;
        private System.Windows.Forms.Label label_BestScore;
        private System.Windows.Forms.Panel panel_leftwall;
        private System.Windows.Forms.Panel panel_bottomwall;
        private System.Windows.Forms.Timer timer_Clock;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.PictureBox pictureBox_CrashedCopter;
    }
}


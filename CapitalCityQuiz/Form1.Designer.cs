namespace CapitalCityQuiz
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
            this.btnHighscore = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHighscore
            // 
            this.btnHighscore.BackColor = System.Drawing.Color.Transparent;
            this.btnHighscore.BackgroundImage = global::CapitalCityQuiz.Properties.Resources.button;
            this.btnHighscore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHighscore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHighscore.FlatAppearance.BorderSize = 0;
            this.btnHighscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighscore.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighscore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHighscore.Location = new System.Drawing.Point(322, 341);
            this.btnHighscore.Margin = new System.Windows.Forms.Padding(2);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(149, 57);
            this.btnHighscore.TabIndex = 12;
            this.btnHighscore.Text = "HIGHSCORES";
            this.btnHighscore.UseVisualStyleBackColor = false;
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click_1);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::CapitalCityQuiz.Properties.Resources.button;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(322, 260);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(149, 57);
            this.btnPlay.TabIndex = 11;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = global::CapitalCityQuiz.Properties.Resources.homepageBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHighscore);
            this.Controls.Add(this.btnPlay);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        //private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnHighscore;
        private System.Windows.Forms.Button btnPlay;
    }
}


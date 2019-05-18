namespace CapitalCityQuiz
{
    partial class PlayerNameInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerNameInput));
            this.lblAskName = new System.Windows.Forms.Label();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.btnSubmitName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAskName
            // 
            this.lblAskName.AutoSize = true;
            this.lblAskName.BackColor = System.Drawing.Color.Transparent;
            this.lblAskName.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskName.Location = new System.Drawing.Point(148, 69);
            this.lblAskName.Name = "lblAskName";
            this.lblAskName.Size = new System.Drawing.Size(189, 23);
            this.lblAskName.TabIndex = 0;
            this.lblAskName.Text = "What\'s your name?";
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Font = new System.Drawing.Font("AvenirNext LT Pro Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayerName.Location = new System.Drawing.Point(152, 123);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(180, 30);
            this.tbPlayerName.TabIndex = 1;
            // 
            // btnSubmitName
            // 
            this.btnSubmitName.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitName.BackgroundImage = global::CapitalCityQuiz.Properties.Resources.button;
            this.btnSubmitName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitName.FlatAppearance.BorderSize = 0;
            this.btnSubmitName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitName.Font = new System.Drawing.Font("AvenirNext LT Pro Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmitName.Location = new System.Drawing.Point(192, 194);
            this.btnSubmitName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitName.Name = "btnSubmitName";
            this.btnSubmitName.Size = new System.Drawing.Size(96, 39);
            this.btnSubmitName.TabIndex = 13;
            this.btnSubmitName.Text = "OKAY";
            this.btnSubmitName.UseVisualStyleBackColor = false;
            this.btnSubmitName.Click += new System.EventHandler(this.btnSubmitName_Click_1);
            // 
            // PlayerNameInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapitalCityQuiz.Properties.Resources.backgroundQuiz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 278);
            this.Controls.Add(this.btnSubmitName);
            this.Controls.Add(this.tbPlayerName);
            this.Controls.Add(this.lblAskName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayerNameInput";
            this.Text = "MemCity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAskName;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Button btnSubmitName;
    }
}
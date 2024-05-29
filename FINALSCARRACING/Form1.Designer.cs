namespace FINALSCARRACING
{
    partial class frmMenu
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
            this.bttnPlay = new System.Windows.Forms.Button();
            this.bttnHelp = new System.Windows.Forms.Button();
            this.pnlHelp = new System.Windows.Forms.Panel();
            this.bttnHelpBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.pnlHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnPlay
            // 
            this.bttnPlay.BackColor = System.Drawing.Color.Orchid;
            this.bttnPlay.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPlay.ForeColor = System.Drawing.Color.Black;
            this.bttnPlay.Location = new System.Drawing.Point(151, 396);
            this.bttnPlay.Name = "bttnPlay";
            this.bttnPlay.Size = new System.Drawing.Size(175, 50);
            this.bttnPlay.TabIndex = 0;
            this.bttnPlay.Text = "PLAY";
            this.bttnPlay.UseVisualStyleBackColor = false;
            this.bttnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnHelp
            // 
            this.bttnHelp.BackColor = System.Drawing.Color.Orchid;
            this.bttnHelp.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnHelp.ForeColor = System.Drawing.Color.Black;
            this.bttnHelp.Location = new System.Drawing.Point(151, 452);
            this.bttnHelp.Name = "bttnHelp";
            this.bttnHelp.Size = new System.Drawing.Size(175, 53);
            this.bttnHelp.TabIndex = 1;
            this.bttnHelp.Text = "HELP";
            this.bttnHelp.UseVisualStyleBackColor = false;
            this.bttnHelp.Click += new System.EventHandler(this.bttnHelp_Click);
            // 
            // pnlHelp
            // 
            this.pnlHelp.BackColor = System.Drawing.Color.Plum;
            this.pnlHelp.Controls.Add(this.bttnHelpBack);
            this.pnlHelp.Controls.Add(this.label1);
            this.pnlHelp.Controls.Add(this.label2);
            this.pnlHelp.Location = new System.Drawing.Point(77, 197);
            this.pnlHelp.Name = "pnlHelp";
            this.pnlHelp.Size = new System.Drawing.Size(326, 308);
            this.pnlHelp.TabIndex = 2;
            // 
            // bttnHelpBack
            // 
            this.bttnHelpBack.BackColor = System.Drawing.Color.Orchid;
            this.bttnHelpBack.Location = new System.Drawing.Point(129, 255);
            this.bttnHelpBack.Name = "bttnHelpBack";
            this.bttnHelpBack.Size = new System.Drawing.Size(75, 23);
            this.bttnHelpBack.TabIndex = 2;
            this.bttnHelpBack.Text = "BACK";
            this.bttnHelpBack.UseVisualStyleBackColor = false;
            this.bttnHelpBack.Click += new System.EventHandler(this.bttnHelpBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "HELP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 192);
            this.label2.TabIndex = 1;
            this.label2.Text = "Avoid hitting other cars.\r\nUse arrow key left and right to hover.\r\n\r\nSCORE: 40 - " +
    "400 = Bronze\r\nSCORE: 400 - 999 = Silver\r\nSCORE: 1000 Above = Gold\r\n\r\n\r\n";
            // 
            // picBackGround
            // 
            this.picBackGround.Image = global::FINALSCARRACING.Properties.Resources.CAR_RACING;
            this.picBackGround.Location = new System.Drawing.Point(-3, 0);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(479, 659);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 3;
            this.picBackGround.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FINALSCARRACING.Properties.Resources.CAR_RACING;
            this.ClientSize = new System.Drawing.Size(476, 657);
            this.Controls.Add(this.bttnPlay);
            this.Controls.Add(this.bttnHelp);
            this.Controls.Add(this.picBackGround);
            this.Controls.Add(this.pnlHelp);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN MENU";
            this.pnlHelp.ResumeLayout(false);
            this.pnlHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnPlay;
        private System.Windows.Forms.Button bttnHelp;
        private System.Windows.Forms.Panel pnlHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnHelpBack;
        private System.Windows.Forms.PictureBox picBackGround;
    }
}


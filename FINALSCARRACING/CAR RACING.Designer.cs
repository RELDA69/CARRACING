namespace FINALSCARRACING
{
    partial class CAR_RACING
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
            this.btnStart = new System.Windows.Forms.Button();
            this.textScore = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.grpBxCars = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picCar4 = new System.Windows.Forms.PictureBox();
            this.picCar3 = new System.Windows.Forms.PictureBox();
            this.picCar2 = new System.Windows.Forms.PictureBox();
            this.picCar1 = new System.Windows.Forms.PictureBox();
            this.roadtrack2 = new System.Windows.Forms.PictureBox();
            this.roadtrack1 = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stopWatch = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.lblLastScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            this.grpBxCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("PMingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(102, 597);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 48);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("PMingLiU-ExtB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(112, 534);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(129, 27);
            this.textScore.TabIndex = 2;
            this.textScore.Text = "SCORE: 0";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::FINALSCARRACING.Properties.Resources.GEARICON;
            this.btnSettings.Location = new System.Drawing.Point(12, 525);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(70, 69);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 3;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // grpBxCars
            // 
            this.grpBxCars.BackColor = System.Drawing.Color.DarkGray;
            this.grpBxCars.Controls.Add(this.label6);
            this.grpBxCars.Controls.Add(this.label5);
            this.grpBxCars.Controls.Add(this.label4);
            this.grpBxCars.Controls.Add(this.label3);
            this.grpBxCars.Controls.Add(this.picCar4);
            this.grpBxCars.Controls.Add(this.picCar3);
            this.grpBxCars.Controls.Add(this.picCar2);
            this.grpBxCars.Controls.Add(this.picCar1);
            this.grpBxCars.Location = new System.Drawing.Point(66, 62);
            this.grpBxCars.Name = "grpBxCars";
            this.grpBxCars.Size = new System.Drawing.Size(333, 371);
            this.grpBxCars.TabIndex = 6;
            this.grpBxCars.TabStop = false;
            this.grpBxCars.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Red Sedan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pink Race Car";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Red Race Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "VAN";
            // 
            // picCar4
            // 
            this.picCar4.Image = global::FINALSCARRACING.Properties.Resources.carred;
            this.picCar4.Location = new System.Drawing.Point(228, 206);
            this.picCar4.Name = "picCar4";
            this.picCar4.Size = new System.Drawing.Size(50, 100);
            this.picCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCar4.TabIndex = 3;
            this.picCar4.TabStop = false;
            this.picCar4.Click += new System.EventHandler(this.picCar4_Click);
            // 
            // picCar3
            // 
            this.picCar3.Image = global::FINALSCARRACING.Properties.Resources.carpink;
            this.picCar3.Location = new System.Drawing.Point(51, 206);
            this.picCar3.Name = "picCar3";
            this.picCar3.Size = new System.Drawing.Size(50, 100);
            this.picCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCar3.TabIndex = 2;
            this.picCar3.TabStop = false;
            this.picCar3.Click += new System.EventHandler(this.picCar3_Click);
            // 
            // picCar2
            // 
            this.picCar2.Image = global::FINALSCARRACING.Properties.Resources.carorang;
            this.picCar2.Location = new System.Drawing.Point(228, 37);
            this.picCar2.Name = "picCar2";
            this.picCar2.Size = new System.Drawing.Size(50, 100);
            this.picCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCar2.TabIndex = 1;
            this.picCar2.TabStop = false;
            this.picCar2.Click += new System.EventHandler(this.picCar2_Click);
            // 
            // picCar1
            // 
            this.picCar1.Image = global::FINALSCARRACING.Properties.Resources.truckwhite;
            this.picCar1.Location = new System.Drawing.Point(51, 37);
            this.picCar1.Name = "picCar1";
            this.picCar1.Size = new System.Drawing.Size(50, 100);
            this.picCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCar1.TabIndex = 0;
            this.picCar1.TabStop = false;
            this.picCar1.Click += new System.EventHandler(this.picCar1_Click);
            // 
            // roadtrack2
            // 
            this.roadtrack2.Image = global::FINALSCARRACING.Properties.Resources.Roadtrack_png;
            this.roadtrack2.Location = new System.Drawing.Point(0, 0);
            this.roadtrack2.Name = "roadtrack2";
            this.roadtrack2.Size = new System.Drawing.Size(475, 519);
            this.roadtrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack2.TabIndex = 1;
            this.roadtrack2.TabStop = false;
            // 
            // roadtrack1
            // 
            this.roadtrack1.Image = global::FINALSCARRACING.Properties.Resources.Roadtrack_png;
            this.roadtrack1.Location = new System.Drawing.Point(0, -519);
            this.roadtrack1.Name = "roadtrack1";
            this.roadtrack1.Size = new System.Drawing.Size(475, 519);
            this.roadtrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack1.TabIndex = 0;
            this.roadtrack1.TabStop = false;
            // 
            // A1
            // 
            this.A1.Image = global::FINALSCARRACING.Properties.Resources.cargreen;
            this.A1.Location = new System.Drawing.Point(66, 19);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(50, 101);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.A1.TabIndex = 2;
            this.A1.TabStop = false;
            this.A1.Tag = "carLeft";
            // 
            // A2
            // 
            this.A2.Image = global::FINALSCARRACING.Properties.Resources.carred;
            this.A2.Location = new System.Drawing.Point(257, 78);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(50, 100);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.A2.TabIndex = 3;
            this.A2.TabStop = false;
            this.A2.Tag = "carRight";
            // 
            // explosion
            // 
            this.explosion.Image = global::FINALSCARRACING.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(106, 328);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 4;
            this.explosion.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::FINALSCARRACING.Properties.Resources.bronze_png;
            this.award.Location = new System.Drawing.Point(131, 220);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(212, 78);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.award.TabIndex = 5;
            this.award.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::FINALSCARRACING.Properties.Resources.carorang;
            this.player.Location = new System.Drawing.Point(206, 396);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.A1);
            this.panel1.Controls.Add(this.A2);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadtrack1);
            this.panel1.Controls.Add(this.roadtrack2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.grpBxCars);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 519);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(474, 519);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // stopWatch
            // 
            this.stopWatch.AutoSize = true;
            this.stopWatch.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopWatch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.stopWatch.Location = new System.Drawing.Point(114, 570);
            this.stopWatch.Name = "stopWatch";
            this.stopWatch.Size = new System.Drawing.Size(127, 24);
            this.stopWatch.TabIndex = 4;
            this.stopWatch.Text = "00:00:00:00";
            // 
            // lblLastTime
            // 
            this.lblLastTime.AutoSize = true;
            this.lblLastTime.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastTime.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblLastTime.Location = new System.Drawing.Point(305, 611);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(127, 24);
            this.lblLastTime.TabIndex = 5;
            this.lblLastTime.Text = "00:00:00:00";
            // 
            // lblLastScore
            // 
            this.lblLastScore.AutoSize = true;
            this.lblLastScore.Font = new System.Drawing.Font("PMingLiU-ExtB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastScore.Location = new System.Drawing.Point(304, 570);
            this.lblLastScore.Name = "lblLastScore";
            this.lblLastScore.Size = new System.Drawing.Size(129, 27);
            this.lblLastScore.TabIndex = 6;
            this.lblLastScore.Text = "SCORE: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(305, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "PREVIOUS:";
            // 
            // CAR_RACING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(476, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastScore);
            this.Controls.Add(this.lblLastTime);
            this.Controls.Add(this.stopWatch);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CAR_RACING";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAR_RACING";
            this.Load += new System.EventHandler(this.CAR_RACING_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            this.grpBxCars.ResumeLayout(false);
            this.grpBxCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.GroupBox grpBxCars;
        private System.Windows.Forms.PictureBox roadtrack2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picCar4;
        private System.Windows.Forms.PictureBox picCar3;
        private System.Windows.Forms.PictureBox picCar2;
        private System.Windows.Forms.PictureBox picCar1;
        private System.Windows.Forms.PictureBox roadtrack1;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label stopWatch;
        private System.Windows.Forms.Label lblLastTime;
        private System.Windows.Forms.Label lblLastScore;
        private System.Windows.Forms.Label label1;
    }
}
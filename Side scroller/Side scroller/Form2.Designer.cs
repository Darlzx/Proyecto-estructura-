namespace Side_scroller
{
    partial class Form2
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.puntos2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // puntos2
            // 
            this.puntos2.AutoSize = true;
            this.puntos2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos2.Location = new System.Drawing.Point(271, 9);
            this.puntos2.Name = "puntos2";
            this.puntos2.Size = new System.Drawing.Size(24, 25);
            this.puntos2.TabIndex = 30;
            this.puntos2.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Side_scroller.Properties.Resources.coin;
            this.pictureBox4.Location = new System.Drawing.Point(949, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox2.Location = new System.Drawing.Point(1227, 418);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // door
            // 
            this.door.Image = global::Side_scroller.Properties.Resources.door_closed;
            this.door.Location = new System.Drawing.Point(1269, 76);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(60, 90);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.door.TabIndex = 29;
            this.door.TabStop = false;
            this.door.Tag = "door";
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = global::Side_scroller.Properties.Resources.coin;
            this.pictureBox27.Location = new System.Drawing.Point(1135, 214);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(36, 35);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 28;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Tag = "coin";
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = global::Side_scroller.Properties.Resources.coin;
            this.pictureBox26.Location = new System.Drawing.Point(933, 343);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(36, 35);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 27;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Tag = "coin";
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = global::Side_scroller.Properties.Resources.coin;
            this.pictureBox25.Location = new System.Drawing.Point(270, 97);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(36, 35);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 26;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Tag = "coin";
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::Side_scroller.Properties.Resources.coin;
            this.pictureBox24.Location = new System.Drawing.Point(426, 328);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(36, 35);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 25;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Tag = "coin";
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = global::Side_scroller.Properties.Resources.coin;
            this.pictureBox23.Location = new System.Drawing.Point(652, 377);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(36, 35);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 24;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Tag = "coin";
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = global::Side_scroller.Properties.Resources.coin;
            this.pictureBox22.Location = new System.Drawing.Point(652, 227);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(36, 35);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 23;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Tag = "coin";
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::Side_scroller.Properties.Resources.coin;
            this.pictureBox21.Location = new System.Drawing.Point(523, 41);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(36, 35);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 22;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Tag = "coin";
            // 
            // player
            // 
            this.player.Image = global::Side_scroller.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(59, 367);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(39, 56);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 21;
            this.player.TabStop = false;
            this.player.Tag = "palyer";
            // 
            // key
            // 
            this.key.Image = global::Side_scroller.Properties.Resources.SuperKeySMSJ;
            this.key.Location = new System.Drawing.Point(87, 51);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(31, 38);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key.TabIndex = 20;
            this.key.TabStop = false;
            this.key.Tag = "key";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox19.Location = new System.Drawing.Point(1092, 255);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(127, 28);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 19;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "platform";
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox18.Location = new System.Drawing.Point(1227, 170);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(127, 28);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 18;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "platform";
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox17.Location = new System.Drawing.Point(225, 138);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(127, 28);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 17;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "platform";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox16.Location = new System.Drawing.Point(477, 104);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(127, 28);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 16;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "platform";
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox15.Location = new System.Drawing.Point(614, 268);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(127, 28);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 15;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "platform";
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox14.Location = new System.Drawing.Point(891, 384);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(127, 28);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "platform";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox13.Location = new System.Drawing.Point(904, 138);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(127, 28);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox10.Location = new System.Drawing.Point(41, 95);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(127, 28);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox9.Location = new System.Drawing.Point(492, 418);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(127, 62);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox8.Location = new System.Drawing.Point(614, 418);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(127, 62);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox3.Location = new System.Drawing.Point(248, 418);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Side_scroller.Properties.Resources.platform;
            this.pictureBox1.Location = new System.Drawing.Point(2, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // background
            // 
            this.background.Image = global::Side_scroller.Properties.Resources.fondo_2;
            this.background.Location = new System.Drawing.Point(2, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1446, 720);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 481);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.puntos2);
            this.Controls.Add(this.door);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.player);
            this.Controls.Add(this.key);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.background);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox key;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox23;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.PictureBox pictureBox25;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.PictureBox pictureBox27;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.Label puntos2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
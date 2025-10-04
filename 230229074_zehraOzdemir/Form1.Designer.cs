namespace _230229074_zehraOzdemir
{
    partial class GameScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_kill = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.powerup = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.boss_b = new System.Windows.Forms.PictureBox();
            this.strong_b = new System.Windows.Forms.PictureBox();
            this.fast_b = new System.Windows.Forms.PictureBox();
            this.basic_b = new System.Windows.Forms.PictureBox();
            this.e_boss = new System.Windows.Forms.PictureBox();
            this.e_strong = new System.Windows.Forms.PictureBox();
            this.e_fast = new System.Windows.Forms.PictureBox();
            this.e_basic = new System.Windows.Forms.PictureBox();
            this.player_bullet = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_over = new System.Windows.Forms.Label();
            this.lbl_health = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.powerup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strong_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fast_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basic_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_boss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_strong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_fast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_basic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_kill
            // 
            this.lbl_kill.AutoSize = true;
            this.lbl_kill.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kill.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_kill.Location = new System.Drawing.Point(16, 14);
            this.lbl_kill.Name = "lbl_kill";
            this.lbl_kill.Size = new System.Drawing.Size(152, 35);
            this.lbl_kill.TabIndex = 1;
            this.lbl_kill.Text = "KILLED : 0";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lbl_score.Location = new System.Drawing.Point(263, 14);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(140, 35);
            this.lbl_score.TabIndex = 2;
            this.lbl_score.Text = "SCORE : 0";
            this.lbl_score.Click += new System.EventHandler(this.lbl_score_Click);
            // 
            // powerup
            // 
            this.powerup.Image = global::_230229074_zehraOzdemir.Properties.Resources.powerUp;
            this.powerup.Location = new System.Drawing.Point(577, 422);
            this.powerup.Name = "powerup";
            this.powerup.Size = new System.Drawing.Size(80, 80);
            this.powerup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.powerup.TabIndex = 14;
            this.powerup.TabStop = false;
            // 
            // rock
            // 
            this.rock.Image = global::_230229074_zehraOzdemir.Properties.Resources.rock_3;
            this.rock.Location = new System.Drawing.Point(42, 303);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(80, 80);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock.TabIndex = 13;
            this.rock.TabStop = false;
            // 
            // boss_b
            // 
            this.boss_b.Image = global::_230229074_zehraOzdemir.Properties.Resources.enemy_bullet;
            this.boss_b.Location = new System.Drawing.Point(513, 275);
            this.boss_b.Name = "boss_b";
            this.boss_b.Size = new System.Drawing.Size(60, 110);
            this.boss_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boss_b.TabIndex = 12;
            this.boss_b.TabStop = false;
            this.boss_b.Tag = "40";
            // 
            // strong_b
            // 
            this.strong_b.Image = global::_230229074_zehraOzdemir.Properties.Resources.enemy_bullet3;
            this.strong_b.Location = new System.Drawing.Point(322, 226);
            this.strong_b.Name = "strong_b";
            this.strong_b.Size = new System.Drawing.Size(50, 90);
            this.strong_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.strong_b.TabIndex = 11;
            this.strong_b.TabStop = false;
            this.strong_b.Tag = "50";
            // 
            // fast_b
            // 
            this.fast_b.Image = global::_230229074_zehraOzdemir.Properties.Resources.enemy_bullet2;
            this.fast_b.Location = new System.Drawing.Point(183, 195);
            this.fast_b.Name = "fast_b";
            this.fast_b.Size = new System.Drawing.Size(40, 60);
            this.fast_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fast_b.TabIndex = 10;
            this.fast_b.TabStop = false;
            this.fast_b.Tag = "5";
            // 
            // basic_b
            // 
            this.basic_b.Image = global::_230229074_zehraOzdemir.Properties.Resources.enemy_bullet4;
            this.basic_b.Location = new System.Drawing.Point(70, 160);
            this.basic_b.Name = "basic_b";
            this.basic_b.Size = new System.Drawing.Size(30, 50);
            this.basic_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.basic_b.TabIndex = 9;
            this.basic_b.TabStop = false;
            this.basic_b.Tag = "10";
            // 
            // e_boss
            // 
            this.e_boss.Image = global::_230229074_zehraOzdemir.Properties.Resources.enemy_boss;
            this.e_boss.Location = new System.Drawing.Point(447, 59);
            this.e_boss.Name = "e_boss";
            this.e_boss.Size = new System.Drawing.Size(180, 210);
            this.e_boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_boss.TabIndex = 8;
            this.e_boss.TabStop = false;
            this.e_boss.Tag = "enemy";
            // 
            // e_strong
            // 
            this.e_strong.Image = global::_230229074_zehraOzdemir.Properties.Resources.enemy_strong_2;
            this.e_strong.Location = new System.Drawing.Point(269, 70);
            this.e_strong.Name = "e_strong";
            this.e_strong.Size = new System.Drawing.Size(150, 150);
            this.e_strong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_strong.TabIndex = 7;
            this.e_strong.TabStop = false;
            this.e_strong.Tag = "enemy";
            this.e_strong.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // e_fast
            // 
            this.e_fast.Image = global::_230229074_zehraOzdemir.Properties.Resources.enemy_fast;
            this.e_fast.Location = new System.Drawing.Point(149, 69);
            this.e_fast.Name = "e_fast";
            this.e_fast.Size = new System.Drawing.Size(100, 120);
            this.e_fast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_fast.TabIndex = 6;
            this.e_fast.TabStop = false;
            this.e_fast.Tag = "enemy";
            // 
            // e_basic
            // 
            this.e_basic.Image = global::_230229074_zehraOzdemir.Properties.Resources.enemy_basic_2;
            this.e_basic.Location = new System.Drawing.Point(40, 74);
            this.e_basic.Name = "e_basic";
            this.e_basic.Size = new System.Drawing.Size(90, 80);
            this.e_basic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.e_basic.TabIndex = 5;
            this.e_basic.TabStop = false;
            this.e_basic.Tag = "enemy";
            // 
            // player_bullet
            // 
            this.player_bullet.Image = global::_230229074_zehraOzdemir.Properties.Resources.player_bullet;
            this.player_bullet.Location = new System.Drawing.Point(335, 550);
            this.player_bullet.Name = "player_bullet";
            this.player_bullet.Size = new System.Drawing.Size(40, 60);
            this.player_bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_bullet.TabIndex = 4;
            this.player_bullet.TabStop = false;
            this.player_bullet.Tag = "30";
            this.player_bullet.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // player
            // 
            this.player.Image = global::_230229074_zehraOzdemir.Properties.Resources.spaceship_4;
            this.player.Location = new System.Drawing.Point(284, 616);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(140, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_over.Location = new System.Drawing.Point(214, 367);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(263, 53);
            this.lbl_over.TabIndex = 15;
            this.lbl_over.Text = "GAME OVER";
            // 
            // lbl_health
            // 
            this.lbl_health.AutoSize = true;
            this.lbl_health.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_health.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_health.Location = new System.Drawing.Point(470, 14);
            this.lbl_health.Name = "lbl_health";
            this.lbl_health.Size = new System.Drawing.Size(209, 35);
            this.lbl_health.TabIndex = 16;
            this.lbl_health.Text = "HEALTH : 1000";
            this.lbl_health.Click += new System.EventHandler(this.lbl_health_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.lbl_health);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.powerup);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.e_boss);
            this.Controls.Add(this.e_strong);
            this.Controls.Add(this.e_fast);
            this.Controls.Add(this.e_basic);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_kill);
            this.Controls.Add(this.player_bullet);
            this.Controls.Add(this.boss_b);
            this.Controls.Add(this.strong_b);
            this.Controls.Add(this.fast_b);
            this.Controls.Add(this.basic_b);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "230229074_ZehraOzdemir";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.powerup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boss_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strong_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fast_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basic_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_boss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_strong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_fast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_basic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_kill;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox player_bullet;
        private System.Windows.Forms.PictureBox e_basic;
        private System.Windows.Forms.PictureBox e_fast;
        private System.Windows.Forms.PictureBox e_strong;
        private System.Windows.Forms.PictureBox e_boss;
        private System.Windows.Forms.PictureBox basic_b;
        private System.Windows.Forms.PictureBox fast_b;
        private System.Windows.Forms.PictureBox strong_b;
        private System.Windows.Forms.PictureBox boss_b;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox powerup;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.Label lbl_health;
    }
}


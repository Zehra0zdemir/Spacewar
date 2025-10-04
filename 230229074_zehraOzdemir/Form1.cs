using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _230229074_zehraOzdemir
{
    public partial class GameScreen : Form
    { 
        // uzay gemilerinin canları
        private int playerHealth = 1000; 
        private int enemyBasicHealth = 50; 
        private int enemyFastHealth = 30; 
        private int enemyStrongHealth = 200;
        private int enemyBossHealth = 400;

        //public List<Bullet> bullets = new List<Bullet>();
        //public int score = 0;

        // Yeni değişkenler ekleyelim
        private bool isBossSpawned = false;
        private bool isAdvancedEnemiesSpawned = false;
        
        // Constructor'da düşmanları başlangıçta gizleyelim
        public GameScreen()
        {
            InitializeComponent();
            lbl_over.Visible = false;
            e_fast.Visible = false;
            e_strong.Visible = false;
            e_boss.Visible = false;
            e_basic.Visible = true;
            timer1.Start();
            timer1.Interval = 20;
        }

        int score = 0;
        int kill;

        bool right, left, space;

        // 
        private void CheckCollisions()
        {
            foreach (Control control in this.Controls.OfType<Control>().ToList())
            {
                if (control is PictureBox playerBullet && playerBullet.Tag != null && playerBullet.Tag is int damage)
                {
                    // Basic düşman kontrolü
                    if (e_basic.Visible && playerBullet.Bounds.IntersectsWith(e_basic.Bounds))
                    {
                        enemyBasicHealth -= damage;
                        this.Controls.Remove(playerBullet);
                        if (enemyBasicHealth <= 0)
                        {
                            e_basic.Visible = false;
                            UpdateScore(50);
                            UpdateKill();
                            enemyBasicHealth = 50;
                        }
                    }

                    // Strong düşman kontrolü
                    if (e_strong.Visible && playerBullet.Bounds.IntersectsWith(e_strong.Bounds))
                    {
                        enemyStrongHealth -= damage;
                        this.Controls.Remove(playerBullet);
                        if (enemyStrongHealth <= 0)
                        {
                            e_strong.Visible = false;
                            UpdateScore(150);
                            UpdateKill();
                            enemyStrongHealth = 200;
                        }
                    }

                    // Fast düşman kontrolü
                    if (e_fast.Visible && playerBullet.Bounds.IntersectsWith(e_fast.Bounds))
                    {
                        enemyFastHealth -= damage;
                        this.Controls.Remove(playerBullet);
                        if (enemyFastHealth <= 0)
                        {
                            e_fast.Visible = false;
                            UpdateScore(100);
                            UpdateKill();
                            enemyFastHealth = 30;
                        }
                    }

                    // Boss kontrolü
                    if (e_boss.Visible && playerBullet.Bounds.IntersectsWith(e_boss.Bounds))
                    {
                        enemyBossHealth -= damage;
                        this.Controls.Remove(playerBullet);
                        if (enemyBossHealth <= 0)
                        {
                            e_boss.Visible = false;
                            GameWin();
                        }
                    }
                }
            }

            // Can kontrolü
            if (playerHealth <= 0)
            {
                GameOver();
            }
        }

        private void UpdateScore(int points) 
        { 
            score += points; 
            if (lbl_score != null)
            {
                lbl_score.Text = "SCORE: " + score;
                lbl_score.Refresh();
            }
        }

        private void UpdateKill()
        {
            kill++ ;
            lbl_kill.Text = "KILLED: " + kill;
        }

        private void UpdateHealthLabel()
        {
            if (lbl_health != null)
            {
                lbl_health.Text = "HEALTH: " + playerHealth;
                lbl_health.Refresh();
            }
        }

        private void GameOver()
        {
            lbl_over.Text = "GAME OVER";
            lbl_over.Visible = true;
            timer1.Stop();
        }

        private void GameWin()
        {
            lbl_over.Text = "YOU WIN!";
            lbl_over.Visible = true;
            timer1.Stop();
        }

        void Bullet()
        {
            // Player kurşunu yukarı doğru hareket eder
            player_bullet.Top -= 20;
            if (player_bullet.Top < 0)
            {
                player_bullet.Image = Properties.Resources.player_bullet;
                player_bullet.Left = player.Left + 40;
                player_bullet.Top = player.Top;
            }

            // Düşman kurşunları aşağı doğru hareket eder
            basic_b.Top += 20;
            if (basic_b.Top > this.Height)
            {
                basic_b.Left = e_basic.Left + 25;
                basic_b.Top = e_basic.Top;
            }

            strong_b.Top += 20;
            if (strong_b.Top > this.Height)
            {
                strong_b.Left = e_strong.Left + 40;
                strong_b.Top = e_strong.Top;
            }

            fast_b.Top += 20;
            if (fast_b.Top > this.Height)
            {
                fast_b.Left = e_fast.Left + 25;
                fast_b.Top = e_fast.Top;
            }

            boss_b.Top += 20;
            if (boss_b.Top > this.Height)
            {
                boss_b.Left = e_boss.Left + 40;
                boss_b.Top = e_boss.Top;
            }
        }

        void Rock()
        {
            Random rnd = new Random();
            int y;
            rock.Top += 5;
            if (rock.Top < 0)
            {
                y = rnd.Next(0, 700);
                rock.Location = new Point(y, 10);      //YENİ OLUŞANLAR GÖRÜNMÜYOR
            }
        }

        private void Enemy() 
        { 
            MoveEnemyTowardsPlayer(e_basic); 
            MoveEnemyTowardsPlayer(e_fast); 
            MoveEnemyTowardsPlayer(e_strong); 
            MoveEnemyTowardsPlayer(e_boss); 
        }

        private void MoveEnemyTowardsPlayer(PictureBox enemy)
        {
            int deltaX = player.Left - enemy.Left;
            int deltaY = player.Top - enemy.Top;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            // Her bir enemy için hız değerini ayarla
            int speed = 5; // Varsayılan hız

            // Name veya Tag kullanarak farklı hızlar belirleyin
            switch (enemy.Name)
            {
                case "e_basic":
                    speed = 3; // Temel düşman hızı
                    break;
                case "e_fast":
                    speed = 5; // Hızlı düşman hızı
                    break;
                case "e_strong":
                    speed = 2; // Güçlü düşman hızı
                    break;
                case "e_boss":
                    speed = 2; // Boss düşman hızı
                    break;
            }

            if (distance > 0)
            {
                int moveX = (int)(speed * deltaX / distance);
                int moveY = (int)(speed * deltaY / distance);
                enemy.Left += moveX;
                enemy.Top += moveY;
            }
            else
            {
                // Mesafe 0 olduğunda düşmanı yok et
                this.Controls.Remove(enemy);
            }

            if (enemy.Top > this.ClientSize.Height-50 || enemy.Left < 10 || enemy.Left > this.ClientSize.Width-10)
            {
                Random rnd = new Random();
                int newX = rnd.Next(0, this.ClientSize.Width);
                enemy.Location = new Point(newX, 0);
            }
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (player.Left > 10)
                {
                    player.Left -= 5;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (player.Left < 400)
                {
                    player.Left += 5;
                }
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Shoot();
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }

        void Add_Bullet()
        {
            PictureBox player_bullet = new PictureBox();
            this.Controls.Add(player_bullet);
            player_bullet.BringToFront();
        }

        private void MoveEnemy()
        {
            // Formdaki tüm PictureBox kontrollerini döngüyle kontrol et
            foreach (Control control in this.Controls)
            {
                // Kontrol bir PictureBox mı ve Tag'i "enemy" mi?
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "enemy")
                {
                    PictureBox enemy = (PictureBox)control; // Kontrolü PictureBox'a dönüştür

                    // Her enemy için hareket metodunu çağır
                    MoveEnemyTowardsPlayer(enemy);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Player hareketi
            if (left && player.Left > 10)
                player.Left -= 5;
            if (right && player.Left < 400)
                player.Left += 5;
            if (space)
                Shoot();

            MoveBullets();
            MoveEnemyBullets();
            CheckCollisions();
            CheckSpaceshipsCollision();
            
            // Düşman spawn kontrolü
            if (score >= 500 && !isBossSpawned)
            {
                e_basic.Visible = false;
                e_fast.Visible = false;
                e_strong.Visible = false;
                e_boss.Visible = true;
                isBossSpawned = true;
            }
            else if (score >= 200 && !isAdvancedEnemiesSpawned)
            {
                e_fast.Visible = true;
                e_strong.Visible = true;
                isAdvancedEnemiesSpawned = true;
            }

            MoveEnemy();
            Enemy();
        }

        private void MoveBullets()
        {
            foreach (Control control in this.Controls.OfType<Control>().ToList())
            {
                if (control is PictureBox bullet && bullet.Tag != null && bullet.Tag is int)
                {
                    bullet.Top -= 10;
                    if (bullet.Top < -50)
                    {
                        this.Controls.Remove(control);
                    }
                }
            }
        }

        private void MoveEnemyBullets()
        {
            foreach (Control control in this.Controls.OfType<Control>().ToList())
            {
                if (control is PictureBox enemyBullet && enemyBullet.Tag != null && enemyBullet.Tag.ToString().StartsWith("enemy"))
                {
                    enemyBullet.Top += 10;
                    
                    // Player'a çarpma kontrolü
                    if (enemyBullet.Bounds.IntersectsWith(player.Bounds))
                    {
                        try
                        {
                            string[] tagParts = enemyBullet.Tag.ToString().Split('_');
                            if (tagParts.Length >= 2) // Dizi kontrolü ekle
                            {
                                int damage = int.Parse(tagParts[1]);
                                playerHealth -= damage;
                                UpdateHealthLabel();
                            }
                            this.Controls.Remove(enemyBullet);
                            
                            if (playerHealth <= 0)
                            {
                                GameOver();
                            }
                        }
                        catch
                        {
                            // Hata durumunda sadece mermiyi kaldır
                            this.Controls.Remove(enemyBullet);
                        }
                    }
                    
                    // Ekrandan çıkan mermileri temizle
                    if (enemyBullet.Top > this.Height)
                    {
                        this.Controls.Remove(enemyBullet);
                    }
                }
            }
        }

        private void Shoot()
        {
            
            bullet.Location = new Point(
                player.Left + (player.Width / 2) - 5,
                player.Top - 20
            );

            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void CheckSpaceshipsCollision()
        {
            // Basic düşman çarpışması
            if (player.Bounds.IntersectsWith(e_basic.Bounds) && e_basic.Visible)
            {
                playerHealth -= 40; // Normal hasar 20 * 2
                UpdateHealthLabel();
            }

            // Fast düşman çarpışması
            if (player.Bounds.IntersectsWith(e_fast.Bounds) && e_fast.Visible)
            {
                playerHealth -= 60; // Normal hasar 30 * 2
                UpdateHealthLabel();
            }

            // Strong düşman çarpışması
            if (player.Bounds.IntersectsWith(e_strong.Bounds) && e_strong.Visible)
            {
                playerHealth -= 80; // Normal hasar 40 * 2
                UpdateHealthLabel();
            }

            // Boss çarpışması
            if (player.Bounds.IntersectsWith(e_boss.Bounds) && e_boss.Visible)
            {
                GameOver();
            }

            // Can kontrolü
            if (playerHealth <= 0)
            {
                GameOver();
            }
        }

        private void lbl_score_Click(object sender, EventArgs e)
        {

        }

        private void lbl_health_Click(object sender, EventArgs e)
        {

        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        // Düşman mermisi oluşturma metodunu da güncelleyelim
        private void CreateEnemyBullet(PictureBox enemy, int damage)
        {
            PictureBox bullet = new PictureBox();
            bullet.Size = new Size(5, 10);
            bullet.BackColor = Color.Red;
            bullet.Tag = $"enemy_{damage}"; // Tag formatını garantile
            bullet.Location = new Point(
                enemy.Left + (enemy.Width / 2) - 2,
                enemy.Bottom
            );
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
    }
}

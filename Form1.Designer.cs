namespace MyGame
{
    partial class FlappyBird
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.pctGronud = new System.Windows.Forms.PictureBox();
            this.TubeUp = new System.Windows.Forms.PictureBox();
            this.TubeDown = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.lbGameOver = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lbFinalScores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctGronud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TubeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TubeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbScore.Font = new System.Drawing.Font("Better VCR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbScore.ForeColor = System.Drawing.Color.DarkMagenta;
            this.lbScore.Location = new System.Drawing.Point(12, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(138, 21);
            this.lbScore.TabIndex = 3;
            this.lbScore.Text = "Score: 0";
            // 
            // pctGronud
            // 
            this.pctGronud.BackColor = System.Drawing.Color.Transparent;
            this.pctGronud.BackgroundImage = global::MyGame.Properties.Resources.ground;
            this.pctGronud.Location = new System.Drawing.Point(-4, 501);
            this.pctGronud.Name = "pctGronud";
            this.pctGronud.Size = new System.Drawing.Size(972, 19);
            this.pctGronud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGronud.TabIndex = 4;
            this.pctGronud.TabStop = false;
            // 
            // TubeUp
            // 
            this.TubeUp.BackColor = System.Drawing.Color.Transparent;
            this.TubeUp.Image = global::MyGame.Properties.Resources.png_transparent_super_mario_brothers_computer_game_warp_tunnel_tube_sprite_green_computer_green_laptop_green_gaming_green_game__2_;
            this.TubeUp.Location = new System.Drawing.Point(521, -164);
            this.TubeUp.Name = "TubeUp";
            this.TubeUp.Size = new System.Drawing.Size(55, 327);
            this.TubeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TubeUp.TabIndex = 2;
            this.TubeUp.TabStop = false;
            // 
            // TubeDown
            // 
            this.TubeDown.BackColor = System.Drawing.Color.Transparent;
            this.TubeDown.Image = global::MyGame.Properties.Resources.png_transparent_super_mario_brothers_computer_game_warp_tunnel_tube_sprite_green_computer_green_laptop_green_gaming_green_game__1_;
            this.TubeDown.Location = new System.Drawing.Point(521, 326);
            this.TubeDown.Name = "TubeDown";
            this.TubeDown.Size = new System.Drawing.Size(55, 320);
            this.TubeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TubeDown.TabIndex = 1;
            this.TubeDown.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bird.Image = global::MyGame.Properties.Resources.Птичка__1___1_;
            this.bird.Location = new System.Drawing.Point(41, 219);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(56, 66);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // lbGameOver
            // 
            this.lbGameOver.AutoSize = true;
            this.lbGameOver.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbGameOver.Font = new System.Drawing.Font("Better VCR", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGameOver.Location = new System.Drawing.Point(93, 166);
            this.lbGameOver.Name = "lbGameOver";
            this.lbGameOver.Size = new System.Drawing.Size(493, 37);
            this.lbGameOver.TabIndex = 5;
            this.lbGameOver.Text = "Птичка разбилась(";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Orange;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Font = new System.Drawing.Font("Better VCR", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestart.Location = new System.Drawing.Point(217, 269);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(230, 47);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Заново";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lbFinalScores
            // 
            this.lbFinalScores.AutoSize = true;
            this.lbFinalScores.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbFinalScores.Font = new System.Drawing.Font("Better VCR", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFinalScores.Location = new System.Drawing.Point(212, 219);
            this.lbFinalScores.Name = "lbFinalScores";
            this.lbFinalScores.Size = new System.Drawing.Size(233, 29);
            this.lbFinalScores.TabIndex = 5;
            this.lbFinalScores.Text = "Ваши очки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Better VCR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(673, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Нуб";
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 517);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lbFinalScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGameOver);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.TubeUp);
            this.Controls.Add(this.TubeDown);
            this.Controls.Add(this.pctGronud);
            this.Controls.Add(this.bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FlappyBird_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pctGronud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TubeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TubeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox TubeDown;
        private System.Windows.Forms.PictureBox TubeUp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox pctGronud;
        private System.Windows.Forms.Label lbGameOver;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lbFinalScores;
        private System.Windows.Forms.Label label1;
    }
}



namespace Гонки
{
    partial class FormRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRace));
            this.pictureBoxRoad = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxRoad2 = new System.Windows.Forms.PictureBox();
            this.EnemyCar1 = new System.Windows.Forms.PictureBox();
            this.EnemyCar2 = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.Coin = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRoad
            // 
            this.pictureBoxRoad.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoad.Image")));
            this.pictureBoxRoad.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRoad.Name = "pictureBoxRoad";
            this.pictureBoxRoad.Size = new System.Drawing.Size(840, 662);
            this.pictureBoxRoad.TabIndex = 0;
            this.pictureBoxRoad.TabStop = false;
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(433, 521);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(112, 128);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 1;
            this.Car.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBoxRoad2
            // 
            this.pictureBoxRoad2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoad2.Image")));
            this.pictureBoxRoad2.Location = new System.Drawing.Point(0, -650);
            this.pictureBoxRoad2.Name = "pictureBoxRoad2";
            this.pictureBoxRoad2.Size = new System.Drawing.Size(840, 650);
            this.pictureBoxRoad2.TabIndex = 2;
            this.pictureBoxRoad2.TabStop = false;
            // 
            // EnemyCar1
            // 
            this.EnemyCar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnemyCar1.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar1.Image")));
            this.EnemyCar1.Location = new System.Drawing.Point(289, -130);
            this.EnemyCar1.Name = "EnemyCar1";
            this.EnemyCar1.Size = new System.Drawing.Size(128, 128);
            this.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar1.TabIndex = 3;
            this.EnemyCar1.TabStop = false;
            // 
            // EnemyCar2
            // 
            this.EnemyCar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnemyCar2.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar2.Image")));
            this.EnemyCar2.Location = new System.Drawing.Point(548, -400);
            this.EnemyCar2.Name = "EnemyCar2";
            this.EnemyCar2.Size = new System.Drawing.Size(128, 128);
            this.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar2.TabIndex = 4;
            this.EnemyCar2.TabStop = false;
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Red;
            this.labelLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLose.Location = new System.Drawing.Point(301, 197);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(244, 37);
            this.labelLose.TabIndex = 5;
            this.labelLose.Text = "Вы проиграли !";
            this.labelLose.Click += new System.EventHandler(this.labelLose_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Red;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRestart.Location = new System.Drawing.Point(323, 254);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(209, 33);
            this.buttonRestart.TabIndex = 6;
            this.buttonRestart.Text = "Начать заново";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // Coin
            // 
            this.Coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Coin.Image = ((System.Drawing.Image)(resources.GetObject("Coin.Image")));
            this.Coin.Location = new System.Drawing.Point(377, -600);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(32, 32);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin.TabIndex = 8;
            this.Coin.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCoins.Location = new System.Drawing.Point(12, 21);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(124, 25);
            this.labelCoins.TabIndex = 9;
            this.labelCoins.Text = "Монеты: 0";
            // 
            // FormRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.EnemyCar2);
            this.Controls.Add(this.EnemyCar1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.pictureBoxRoad);
            this.Controls.Add(this.pictureBoxRoad2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRace_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRoad;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBoxRoad2;
        private System.Windows.Forms.PictureBox EnemyCar1;
        private System.Windows.Forms.PictureBox EnemyCar2;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.Label labelCoins;
    }
}


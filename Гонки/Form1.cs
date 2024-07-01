using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гонки
{
    public partial class FormRace : System.Windows.Forms.Form
    {
        private Point pos;  // где мы нажали мышкой первый раз
        private bool dragging;  // значения о том передвигаем ли окно или нет

        private bool lose = false; // движение маишнки после проигрыша

        private int countCoints = 0;

        public FormRace()
        {
            InitializeComponent();

            pictureBoxRoad.MouseDown += MouseClickDown;
            pictureBoxRoad.MouseUp += MouseClickUp;
            pictureBoxRoad.MouseMove += MouseClickMove;
            // передвижение pictureBox по клику мышки 

            pictureBoxRoad2.MouseDown += MouseClickDown;
            pictureBoxRoad2.MouseUp += MouseClickUp;
            pictureBoxRoad2.MouseMove += MouseClickMove;

            // Пропадание button и label
            labelLose.Visible = false;
            buttonRestart.Visible = false;

            // при перезапуске все работает
            KeyPreview = true;
        }

        private void MouseClickDown(object sender, MouseEventArgs e) // нажатие мышки
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        private void MouseClickUp(object sender, MouseEventArgs e) // отпустили мышку
        {
            dragging = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e) // нажали на мышку и двигаем
        {
            if (dragging)            
            {
                Point Currentpoint = PointToScreen(new Point(e.X, e.Y));  // получаем координаты где сейчас находится мышка и преобразуем к координатам экрана с помощью PointToScreen
                this.Location = new Point(Currentpoint.X-pos.X, Currentpoint.Y-pos.Y + pictureBoxRoad.Top);  // от текущего места мышки отнимаем начальную точку мышки 
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // движение дороги с помощью двух PictureBox
            int speed = 7;
            pictureBoxRoad.Top += speed;
            pictureBoxRoad2.Top += speed;

            // Движение вражеских машинок
            int CarSpeed = 7;
            EnemyCar1.Top += CarSpeed;
            EnemyCar2.Top += CarSpeed;
 
            // движение монетки со скоростью движения дороги
            Coin.Top += speed;

            if (pictureBoxRoad.Top >= 650)
            {
                // Возвращение двух PictureBox на начальные координаты
                pictureBoxRoad.Top = 0;
                pictureBoxRoad2.Top = -650;
            }

            // Спавн вражеских машинок на рандомных координатах
            if (EnemyCar1.Top >= 650)
            {
                EnemyCar1.Top = -130;
                Random rnd = new Random();
                EnemyCar1.Left = rnd.Next(150, 290);
            }
            if (EnemyCar2.Top >= 650)
            {
                EnemyCar2.Top = -400;
                Random rnd = new Random();
                EnemyCar2.Left = rnd.Next(350,560);
            }

            // Проверка столкнвоения машинок
            if (Car.Bounds.IntersectsWith(EnemyCar1.Bounds) || Car.Bounds.IntersectsWith(EnemyCar2.Bounds)) 
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                buttonRestart.Visible = true;

                lose = true;
            }

            if (Coin.Top >= 650)
            {
                // возвращение монетки на координаты -50
                Coin.Top = -50;                

                Random rnd = new Random();
                Coin.Left = rnd.Next(150, 560);
            }

            if (Car.Bounds.IntersectsWith(Coin.Bounds)) // проверка координат машинки и монетки
            {
                countCoints++;
                labelCoins.Text = $"Монеты: {countCoints.ToString()}";

                // при сокосновении с монеткой возвращаем ее на рандомные по Х координаты
                Coin.Top = -50;
                Random rnd = new Random();
                Coin.Left = rnd.Next(150, 560);
            }

                
        }

        private void FormRace_KeyDown(object sender, KeyEventArgs e)
        {
            // движение маишнки после проигрыша
            if (lose)
            {
                return;
            }
            
            int speedCar = 10;
            // передвижение машинки
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && Car.Left > 150 ) // если больше 150 пикселей, то не выходим за границы
            {
                Car.Left -= speedCar;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && Car.Right < 700)
            {
                Car.Left += speedCar;
            }
            else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && Car.Top > 5)
            {
                Car.Top -= speedCar;
            }
            else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.S) && Car.Top < 520)
            {
                Car.Top += speedCar;
            }
        }

        private void labelLose_Click(object sender, EventArgs e)
        {

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            EnemyCar1.Top = -130;
            EnemyCar2.Top = -400;
            labelLose.Visible = false;
            buttonRestart.Visible = false;
            timer.Enabled = true; // запуск таймера
            lose = false;

            countCoints = 0;
            labelCoins.Text = "Монеты: 0";
            Coin.Top = -500;
        }
    }
}

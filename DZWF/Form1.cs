using System;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Timer = System.Windows.Forms.Timer;

namespace DZWF
{
    public partial class Form1 : Form
    {
        bool gameOver = false;
        private int maxCount = 0;
        private int timer = 0;
        private int countClicks = 0;
        public Form1()
        {
            InitializeComponent();
            // пример на создание таймера
            // таймер в винформс - это механизм, который позволяет запускать определённую функцию периодически с некоторым интервалом 
            var t = new Timer(); // это невизуальный компонент
            t.Interval = 1000; // интервал (свойство) задат частоту повторения определённого участка кода (в данном случае нужно чтобы какие-то вещи происходили раз в миллисекунду - 1000 раз в секунду)
            t.Tick += new System.EventHandler(Fun); // тик (событие) - наступает после истечения времени интервала, функция Fun срабатывает как обработчик этого события
            t.Start(); // старт (метод) - непосредственно запуск дополнительнго потока
            // t.Stop();
        }
        
        private void Fun(object sender, EventArgs e)
        {
            var a = DateTime.Now;//Вычитаем три дня
            var b = new DateTime(2023, 01, 01, 0, 0, 0);//Вычитаем три дня
            TimeSpan c = b - a;
            textBox1.Text = c.ToString().Substring(0, 11);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             switch (e.KeyCode)
             {
                 case Keys.Down:
                     if (this.Top + this.Height < Screen.PrimaryScreen.Bounds.Bottom)
                     {
                         SetDesktopLocation(this.Left, this.Top + 50);
                     }
                     break;
                 case Keys.Up:
                     if (this.Top > 0)
                     {
                         SetDesktopLocation(this.Left, this.Top - 50);
                     }
                     break;
                 case Keys.Right:
                     if ((this.Left + this.Width) < Screen.PrimaryScreen.Bounds.Right)
                     {
                         SetDesktopLocation(this.Left + 50, this.Top);
                     }
                     break;
                 case Keys.Left:
                     if (this.Left > 0)
                     {
                         SetDesktopLocation(this.Left - 50, this.Top);
                     }
                 break;
                case Keys.Enter:
                    button1.Enabled = true;
                    break;

                default:
                     break;
             }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer == 10 && gameOver == false)
            {
                gameOver = true;
                MessageBox.Show("Вы накликали : " + countClicks);
                timer1.Stop();
                timer = 0;
                countClicks = 0;
            }
            if (countClicks > maxCount)
            {
                maxCount = countClicks;
                MaxRecord.Text = "Max:" + maxCount.ToString();
            }
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (gameOver == true) gameOver = false;
            timer1.Start();
            countClicks++;
            CounterClicks.Text = countClicks.ToString();
        }

    }
}

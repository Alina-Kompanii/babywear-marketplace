using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace крокодил
{
    public partial class Form1 : Form
    {

        private float xPosition = 0;
        private float yPosition = 0;
        private float targetX = 200; 
        private float easingFactor = 0.05f; 

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 15; 
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Form2 newForm = new Form2();
                newForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Вычисляем расстояние до цели
            float dx = targetX - xPosition;

            // Применяем easing
            xPosition += dx * easingFactor;

            // Если достаточно близко к цели, останавливаемся
            if (Math.Abs(dx) < 0.1)
            {
                xPosition = targetX;
            }

            pictureBox1.Location = new System.Drawing.Point((int)xPosition, pictureBox1.Location.Y); // Двигаем только по X
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

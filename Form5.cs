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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        userPictureBox.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);

                        userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при загрузке изображения: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ник сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваша скидка составляет 17%!", "Моя скидка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш лимит на оплату при получении.", "До 20 099 ₽", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HomeLibrary - самая большая библиотека на просторах Интернета! Книги, которые понравятся каждому члену семьи, а цены приятно удивят!" +
                            "Создатель: Федоров Влад, криптомиллиардер из Тимашевска.", "Вам также может понравиться...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sky Twins - недорогие билеты в любую точку мира! А также горящие путевки в самые элитные курорты. Вас ждет обслуживание на высшем уровне и незабываемый отдых!" +
                "Ген. Директор компании - Анастасия Галай, девушка, заработавшая первый миллион в 17 лет.", "Вас может заинтересовать...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GOODNS - знаменитая сеть магазинов техники в России! Здесь вы найдете все от зарядного устройства до самого мощного игрового ПК. А также любой электронный прибор, который пригодится в хозяйстве." +
                            "Владелец сети - Артем Витенберг. В данный момент открывает новую сеть своих магазинов, но уже в Бразилии.", "Вам может пригодиться...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 newForm = new Form4();
            newForm.Show();
        }
    }
}

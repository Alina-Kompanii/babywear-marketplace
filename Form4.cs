using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace крокодил
{
    public partial class Form4 : Form
    {
        private Form15 _form15 = null;
        private Form16 _form16 = null;
        private Form17 _form17 = null;
        private Form18 _form18 = null;
        private Form19 _form19 = null;
        private Form20 _form20 = null;
        private Form21 _form21 = null;
        private Form22 _form22 = null;
        private Form23 _form23 = null;
        private Form24 _form24 = null;
        private Form25 _form25 = null;
        private Form26 _form26 = null;
        private Form27 _form27 = null;
        private Form28 _form28 = null;
        private Form29 _form29 = null;
        private Form30 _form30 = null;
        private Form31 _form31 = null;
        private Form32 _form32 = null;
        private Form33 _form33 = null;
        private Form34 _form34 = null;
        private Form35 _form35 = null;
        private Form36 _form36 = null;
        private Form37 _form37 = null;
        private Form38 _form38 = null;
        private Form39 _form39 = null;
        private Form40 _form40 = null;
        private Form41 _form41 = null;
        private Form42 _form42 = null;
        public Form4()
        {
            InitializeComponent();

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string gifFilePath = Path.Combine(appDirectory, "QSAW0414.GIF"); 

            try
            {
                bannerPictureBox.Image = Image.FromFile(gifFilePath);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show($"Файл не найден: {ex.Message}");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке GIF: {ex.Message}");
            }

            bannerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 newForm = new Form5();
            newForm.Show();
        }

      

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form11 newForm = new Form11();
            newForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы получили скидку 17% на любой товар!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form6 newForm = new Form6();
            newForm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form15 == null || _form15.IsDisposed)
            {
                _form15 = new Form15();
                _form15.FormClosed += Form15_FormClosed;
            }
            _form15.Show();
            _form15.Activate(); 
        }
        private void Form15_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            _form15 = null;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form16 == null || _form16.IsDisposed)
            {
                _form16 = new Form16();
                _form16.FormClosed += Form16_FormClosed;
            }
            _form16.Show();
            _form16.Activate();
        }
        private void Form16_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form16 = null;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form17 == null || _form17.IsDisposed)
            {
                _form17 = new Form17();
                _form17.FormClosed += Form17_FormClosed;
            }
            _form17.Show();
            _form17.Activate();
        }
        private void Form17_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form17 = null;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form18 == null || _form18.IsDisposed)
            {
                _form18 = new Form18();
                _form18.FormClosed += Form18_FormClosed;
            }
            _form18.Show();
            _form18.Activate();
        }
        private void Form18_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form18 = null;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form19 == null || _form19.IsDisposed)
            {
                _form19 = new Form19();
                _form19.FormClosed += Form19_FormClosed;
            }
            _form19.Show();
            _form19.Activate();
        }
        private void Form19_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form19 = null;
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form20 == null || _form20.IsDisposed)
            {
                _form20 = new Form20();
                _form20.FormClosed += Form20_FormClosed;
            }
            _form20.Show();
            _form20.Activate();
        }
        private void Form20_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form20 = null;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form21 == null || _form21.IsDisposed)
            {
                _form21 = new Form21();
                _form21.FormClosed += Form21_FormClosed;
            }
            _form21.Show();
            _form21.Activate();
        }
        private void Form21_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form21 = null;
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form22 == null || _form22.IsDisposed)
            {
                _form22 = new Form22();
                _form22.FormClosed += Form22_FormClosed;
            }
            _form22.Show();
            _form22.Activate();
        }
        private void Form22_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form22 = null;
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form23 == null || _form23.IsDisposed)
            {
                _form23 = new Form23();
                _form23.FormClosed += Form23_FormClosed;
            }
            _form23.Show();
            _form23.Activate();
        }
        private void Form23_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form23 = null;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form24 == null || _form24.IsDisposed)
            {
                _form24 = new Form24();
                _form24.FormClosed += Form24_FormClosed;
            }
            _form24.Show();
            _form24.Activate();
        }
        private void Form24_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form24 = null;
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form25 == null || _form25.IsDisposed)
            {
                _form25 = new Form25();
                _form25.FormClosed += Form25_FormClosed;
            }
            _form25.Show();
            _form25.Activate();
        }
        private void Form25_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form25 = null;
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form26 == null || _form26.IsDisposed)
            {
                _form26 = new Form26();
                _form26.FormClosed += Form26_FormClosed;
            }
            _form26.Show();
            _form26.Activate();
        }
        private void Form26_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form26 = null;
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form27 == null || _form27.IsDisposed)
            {
                _form27 = new Form27();
                _form27.FormClosed += Form27_FormClosed;
            }
            _form27.Show();
            _form27.Activate();
        }
        private void Form27_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form27 = null;
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form28 == null || _form28.IsDisposed)
            {
                _form28 = new Form28();
                _form28.FormClosed += Form28_FormClosed;
            }
            _form28.Show();
            _form28.Activate();
        }
        private void Form28_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form28 = null;
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form29 == null || _form29.IsDisposed)
            {
                _form29 = new Form29();
                _form29.FormClosed += Form29_FormClosed;
            }
            _form29.Show();
            _form29.Activate();
        }
        private void Form29_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form29 = null;
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form30 == null || _form30.IsDisposed)
            {
                _form30 = new Form30();
                _form30.FormClosed += Form30_FormClosed;
            }
            _form30.Show();
            _form30.Activate();
        }
        private void Form30_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form30 = null;
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form31 == null || _form31.IsDisposed)
            {
                _form31 = new Form31();
                _form31.FormClosed += Form31_FormClosed;
            }
            _form31.Show();
            _form31.Activate();
        }
        private void Form31_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form31 = null;
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form32 == null || _form32.IsDisposed)
            {
                _form32 = new Form32();
                _form32.FormClosed += Form32_FormClosed;
            }
            _form32.Show();
            _form32.Activate();
        }
        private void Form32_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form32 = null;
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form33 == null || _form33.IsDisposed)
            {
                _form33 = new Form33();
                _form33.FormClosed += Form33_FormClosed;
            }
            _form33.Show();
            _form33.Activate();
        }
        private void Form33_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form33 = null;
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form34 == null || _form34.IsDisposed)
            {
                _form34 = new Form34();
                _form34.FormClosed += Form34_FormClosed;
            }
            _form34.Show();
            _form34.Activate();
        }
        private void Form34_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form34 = null;
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form35 == null || _form35.IsDisposed)
            {
                _form35 = new Form35();
                _form35.FormClosed += Form35_FormClosed;
            }
            _form35.Show();
            _form35.Activate();
        }
        private void Form35_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form35 = null;
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form36 == null || _form36.IsDisposed)
            {
                _form36 = new Form36();
                _form36.FormClosed += Form36_FormClosed;
            }
            _form36.Show();
            _form36.Activate();
        }
        private void Form36_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form36 = null;
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form37 == null || _form37.IsDisposed)
            {
                _form37 = new Form37();
                _form37.FormClosed += Form37_FormClosed;
            }
            _form37.Show();
            _form37.Activate();
        }
        private void Form37_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form37 = null;
        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form38 == null || _form38.IsDisposed)
            {
                _form38 = new Form38();
                _form38.FormClosed += Form38_FormClosed;
            }
            _form38.Show();
            _form38.Activate();
        }
        private void Form38_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form38 = null;
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel28_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel29_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel27_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel30_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel30_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form39 == null || _form39.IsDisposed)
            {
                _form39 = new Form39();
                _form39.FormClosed += Form39_FormClosed;
            }
            _form39.Show();
            _form39.Activate();
        }
        private void Form39_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form39 = null;
        }

        private void linkLabel29_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form40 == null || _form40.IsDisposed)
            {
                _form40 = new Form40();
                _form40.FormClosed += Form40_FormClosed;
            }
            _form40.Show();
            _form40.Activate();
        }
        private void Form40_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form40 = null;
        }

        private void linkLabel28_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form41 == null || _form41.IsDisposed)
            {
                _form41 = new Form41();
                _form41.FormClosed += Form41_FormClosed;
            }
            _form41.Show();
            _form41.Activate();
        }
        private void Form41_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form41 = null;
        }

        private void linkLabel27_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_form42 == null || _form42.IsDisposed)
            {
                _form42 = new Form42();
                _form42.FormClosed += Form42_FormClosed;
            }
            _form42.Show();
            _form42.Activate();
        }
        private void Form42_FormClosed(object sender, FormClosedEventArgs e)
        {

            _form42 = null;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form43 newForm = new Form43();
            newForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form43 newForm = new Form43();
            newForm.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form43 newForm = new Form43();
            newForm.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form43 newForm = new Form43();
            newForm.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form43 newForm = new Form43();
            newForm.Show();
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form43 newForm = new Form43();
            newForm.Show();
        }

        private void linkLabel31_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}





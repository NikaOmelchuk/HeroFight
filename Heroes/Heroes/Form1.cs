using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroLib;

namespace Heroes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int countW = 0;
        public int countA = 0;
        YourEquip y;

        private void Form1_Load(object sender, EventArgs e)
        {
            y = new YourEquip();
            y.saveEquipment(countW, countA);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox5.BackgroundImage = imageList2.Images[countW];
            pictureBox4.BackgroundImage = imageList1.Images[countA];
            butW();
            butA();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        void butW()
        {
            if(pictureBox5.Tag.ToString() == y.weapon.ToString())
            {
                button3.Text = "Обрано";
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                button3.Text = "Обрати";
            }
        }

        void butA()
        {
            if (pictureBox4.Tag.ToString() == y.armor.ToString())
            {
                button7.Text = "Вдягнено";
                button7.Enabled = false;
            }
            else
            {
                button7.Enabled = true;
                button7.Text = "Вдягнути";
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (countW < 2)
            {
                countW++;
                pictureBox5.BackgroundImage = imageList2.Images[countW];
                pictureBox5.Tag = countW;
            }
            else
            {
                countW = 0;
                pictureBox5.BackgroundImage = imageList2.Images[countW];
                pictureBox5.Tag = countW;
            }
            butW();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (countW > 0)
            {
                countW--;
                pictureBox5.BackgroundImage = imageList2.Images[countW];
                pictureBox5.Tag = countW;
            }
            else
            {
                countW = 2;
                pictureBox5.BackgroundImage = imageList2.Images[countW];
                pictureBox5.Tag = countW;
            }
            butW();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            y.weapon = countW;
            butW();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            y.armor = countA;
            butA();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (countA < 3)
            {
                countA++;
                pictureBox4.BackgroundImage = imageList1.Images[countA];
                pictureBox4.Tag = countA;
            }
            else
            {
                countA = 0;
                pictureBox4.BackgroundImage = imageList1.Images[countA];
                pictureBox4.Tag = countA;
            }
            butA();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (countA > 0)
            {
                countA--;
                pictureBox4.BackgroundImage = imageList1.Images[countA];
                pictureBox4.Tag = countA;
            }
            else
            {
                countA = 3;
                pictureBox4.BackgroundImage = imageList1.Images[countA];
                pictureBox4.Tag = countA;
            }
            butA();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Text = "Битва з боссом";
            f.countA = countA;
            f.countW = countW;
            f.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide(); 
            f.Text = "Турнір";
            f.countA = countA;
            f.countW = countW;
            f.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.Text = "Режим випадку";
            f.ShowDialog();
            this.Close();
        }
    }
}

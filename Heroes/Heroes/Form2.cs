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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        EHero eh;
        YHero yh;
        AbstractMode am;
        int ce = 1;
        public int countW = 0;
        public int countA = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            nach();
        }

        void nach()
        {
            label1.Text = "Раунд "+ ce;
            stopy = false;
            stope = false;
            py.Clear();
            pe.Clear();
            if (this.Text == "Битва з боссом")
            {
                am = new BossFightMode();
                eh = am.createEnemyHero(ce);
                yh = new YHeroBossFightMode();
                yh.createHero(countW, countA);
            }
            else if (this.Text == "Режим випадку")
            {
                yh = new YHeroRandomMode();
                yh.createHero(countW, countA);
                am = new RandomMode();
                eh = am.createEnemyHero(countA);
            }
            else
            {
                yh = new YHeroTourneyMode();
                yh.createHero(countW, countA);
                am = new TourneyMode();
                eh = am.createEnemyHero(countA);
            }

            ce++;

            pictureBox2.BackgroundImage = imageList1.Images[eh.armor];
            pictureBox3.BackgroundImage = imageList4.Images[eh.weapon];
            pictureBox6.BackgroundImage = imageList1.Images[eh.armor];
            pictureBox1.BackgroundImage = imageList2.Images[yh.armor];
            pictureBox5.BackgroundImage = imageList3.Images[yh.weapon];
            pictureBox4.BackgroundImage = imageList2.Images[yh.armor];

            adlist();
        }

        void adlist()
        {
            sypron();

            py.Add(pictureBox12);
            py.Add(pictureBox11);
            py.Add(pictureBox10);
            py.Add(pictureBox9);
            py.Add(pictureBox8);
            py.Add(pictureBox7);

            for (int i = 0; i < py.Count; i++)
                py[i].Visible = true;


            pe.Add(pictureBox18);
            pe.Add(pictureBox17);
            pe.Add(pictureBox16);
            pe.Add(pictureBox15);
            pe.Add(pictureBox14);
            pe.Add(pictureBox13);

            for (int i = 0; i < pe.Count; i++)
                pe[i].Visible = true;
        }

        int ysyp = 0, yyron = 0, esyp = 0, eyron = 0;

        Point p1 = new Point(270, 175);

        Point py2 = new Point(395, 195);
        Point pe2 = new Point(170, 195);

        Point pyp = new Point(170, 108);
        Point pep = new Point(398, 108);

        int o = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (o == 0)
            {
                button1.Enabled = false;
                
                pictureBox5.Location = p1;
                o++;
            }
            else if (o == 1)
            {
                pictureBox5.Location = py2;
                picm("y");
                o++;
                if(stope || pe.Count == 0)
                {
                    pictureBox5.Location = pyp;
                    // if (this.Text == "Битва з боссом" && ce <= 3)
                    //{
                    o = 0;
                        raunds();
                        button1.Enabled = true;
                    //}
                    timer1.Enabled = false;
                }
            }
            else if (o == 2)
            {
                pictureBox5.Location = pyp;
                o++;
            }
            else if (o == 3 || o == 4)
            {
                o++;
            }
            else if (o == 5)
            {
                pictureBox3.Location = p1;
                o++;
            }
            else if (o == 6)
            {
                
                pictureBox3.Location = pe2;
                picm("e");
                o++;
                if (stopy || py.Count == 0)
                {
                    pictureBox3.Location = pep;
                    o = 0;
                    button1.Enabled = true;
                    timer1.Enabled = false;
                    panel1.Visible = true;
                    panel1.Enabled = true;
                }
            }
            else if (o == 7)
            {
                pictureBox3.Location = pep;
                o=0;
                button1.Enabled = true;
                timer1.Enabled = false;
            }
        }

        void raunds()
        {
            if ((this.Text == "Битва з боссом" || this.Text == "Режим випадку") && ce > 3 )
            {
                o = 0;
                button1.Enabled = true;
                timer1.Enabled = false;
                panel1.Visible = true;
                panel1.Enabled = true;
            }
            else
            {
                nach();
            }
        }

        List<PictureBox> py = new List<PictureBox>();
        List<PictureBox> pe = new List<PictureBox>();

        bool stopy = false;
        bool stope = false;

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            ce = 1;
            nach();
        }

        void picm(string n)
        {
            if(n=="y")
            {
                int co = yyron + ysyp / 2 - esyp;
                while (co>0)
                {
                    if (pe.Count > 0)
                    {
                        pe[pe.Count - 1].Visible = false;
                        pe.Remove(pe[pe.Count - 1]);
                    }
                    else
                        stope = true;
                    co--;
                }

            }
            else
            {
                int co = eyron + esyp / 2 - ysyp;
                while (co > 0)
                {
                    if (py.Count > 0)
                    {
                        py[py.Count - 1].Visible = false;
                        py.Remove(py[py.Count - 1]);
                    }
                    else
                        stopy = true;
                    co--;
                }
            }
        }

        void sypron()
        {
            if(yh.armor == 0)
                ysyp = 0;
            else if (yh.armor == 1 || yh.armor == 2)
                ysyp = 1;
            else if (yh.armor == 3)
                ysyp = 2;

            if (eh.armor == 0 || eh.armor == 2)
                esyp = 0;
            else if (eh.armor == 1  || eh.armor == 3)
                esyp = 1;
            else if (eh.armor == 4)
                esyp = 2;

            if (yh.weapon == 0 || yh.weapon == 1)
                yyron = 3;
            else if (yh.weapon == 2)
                yyron = 4;

            if (eh.weapon == 0 || eh.weapon == 1)
                eyron = 3;
            else if (eh.weapon == 2)
                eyron = 4;
            else if (eh.weapon == 3)
            {
                eyron = 6;
                esyp += 4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}

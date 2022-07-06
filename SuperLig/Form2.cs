using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int gspuan=0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a=random.Next(0,5);
            int b=random.Next(0,5);
            int c=random.Next(0,5);
            int d=random.Next(0,5);

            label4.Text=a.ToString();
            label5.Text=b.ToString();
            label8.Text=c.ToString();
            label6.Text=d.ToString();

            if(Convert.ToInt32(label4.Text)>Convert.ToInt32(label5.Text))
            {
                gspuan = gspuan + 3;
                label17.Text=gspuan.ToString();
            }
            if(Convert.ToInt32(label5.Text)>Convert.ToInt32(label4.Text))
            {
                fbpuan = fbpuan + 3;
                label12.Text=fbpuan.ToString();
            }
            if(Convert.ToString(label4.Text)==Convert.ToString(label5.Text))
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                label17.Text = gspuan.ToString();
                label12.Text=fbpuan.ToString();
            }
            
            if(Convert.ToInt32(label8.Text)>Convert.ToInt32(label6.Text))
            {
                bjkpuan = bjkpuan + 3;
                label14.Text=bjkpuan.ToString();
            }
            if(Convert.ToInt32(label6.Text)>Convert.ToInt32(label8.Text))
            {
                tspuan = tspuan + 3;
                label11.Text=tspuan.ToString();
            }
            if(Convert.ToInt32(label6.Text)==Convert.ToInt32(label8.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                label14.Text=bjkpuan.ToString() ;
                label11.Text=tspuan.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a=random.Next(0,5);
            int b=random.Next(0,5);
            int c=random.Next(0,5);
            int d=random.Next(0,5);

            label25.Text = a.ToString();
            label20.Text = b.ToString();
            label22.Text = c.ToString();
            label18.Text = d.ToString();

            if(Convert.ToInt32(label25.Text)>Convert.ToInt32(label20.Text))
            {
                gspuan = gspuan + 3;
                label17.Text=gspuan.ToString();
            }
            if(Convert.ToInt32(label20.Text)>Convert.ToInt32(label25.Text))
            {
                fbpuan = fbpuan + 3;
                label12.Text=fbpuan.ToString();
            }
            if(Convert.ToInt32(label20.Text)==Convert.ToInt32(label25.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label17.Text=gspuan.ToString();
                label12.Text=fbpuan.ToString();
            }
            if (Convert.ToInt32(label22.Text) > Convert.ToInt32(label18.Text))
            {
                bjkpuan = bjkpuan + 3;
                label14.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label22.Text))
            {
                tspuan = tspuan + 3;
                label11.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label18.Text) == Convert.ToInt32(label22.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                label14.Text = bjkpuan.ToString();
                label11.Text = fbpuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;
            int a = random.Next(0, 5);
            int b = random.Next(0, 5);
            int c = random.Next(0, 5);
            int d = random.Next(0, 5);

            label35.Text = a.ToString();
            label30.Text = b.ToString();
            label32.Text = c.ToString();
            label29.Text = d.ToString();

            if (Convert.ToInt32(label35.Text) > Convert.ToInt32(label30.Text))
            {
                gspuan = gspuan + 3;
                label17.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label35.Text))
            {
                fbpuan = fbpuan + 3;
                label12.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label35.Text) == Convert.ToInt32(label30.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                label17.Text = gspuan.ToString();
                label12.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label32.Text) > Convert.ToInt32(label29.Text))
            {
                bjkpuan = bjkpuan + 3;
                label14.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label29.Text) > Convert.ToInt32(label32.Text))
            {
                tspuan = tspuan + 3;
                label11.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label32.Text) == Convert.ToInt32(label29.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                label14.Text = bjkpuan.ToString();
                label11.Text = fbpuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(label17.Text) > Convert.ToInt32(label14.Text) && Convert.ToInt32(label17.Text) > Convert.ToInt32(label12.Text) && Convert.ToInt32(label17.Text) > Convert.ToInt32(label11.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Aslı Nur Karaman\\Desktop\\gss.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\Aslı Nur Karaman\\Desktop\\gs.png";
                label39.Text = "Şampiyon Galatasaray";
            }
            if (Convert.ToInt32(label14.Text) > Convert.ToInt32(label17.Text) && Convert.ToInt32(label14.Text) > Convert.ToInt32(label12.Text) && Convert.ToInt32(label14.Text) > Convert.ToInt32(label11.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Aslı Nur Karaman\\Desktop\\bjkk.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\Aslı Nur Karaman\\Desktop\\bjk.png";
                label39.Text = "Şampiyon Beşiktaş";
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label17.Text) && Convert.ToInt32(label12.Text) > Convert.ToInt32(label14.Text) && Convert.ToInt32(label12.Text) > Convert.ToInt32(label11.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Aslı Nur Karaman\\Desktop\\fbb.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\Aslı Nur Karaman\\Desktop\\fb.png";
                label39.Text = "Şampiyon Fenerbahçe";
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label12.Text) && Convert.ToInt32(label11.Text) > Convert.ToInt32(label14.Text) && Convert.ToInt32(label11.Text) > Convert.ToInt32(label17.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Aslı Nur Karaman\\Desktop\\tss.mp3";
                pictureBox1.ImageLocation = "C:\\Users\\Aslı Nur Karaman\\Desktop\\ts.png";
                label39.Text = "Şampiyon Trabzonspor";
                label39.Text = "Şampiyon Trabzonspor";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

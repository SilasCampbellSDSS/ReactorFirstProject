using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;//allows the use of Thread.Sleep()
using System.Media; //allows the use of SoundPlayer

namespace ReactorFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            ReactorI.BackColor = Color.Red
                ;   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //create a sound player and load the alert.wav sound, then play it
            SoundPlayer alertplayer = new SoundPlayer(Properties.Resources.alert);
            alertplayer.Play();
            
            //change the color of label5
            label5.BackColor = Color.Red;

            //change the message in label5
            label5.Text = "MELTDOWN!!!";

            //change the message in label6
            label6.Text = "WHAT DID YOU DO?!?";
            
            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor= Color.Red; 
            label3.BackColor= Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor= Color.White;
            ReactorII.BackColor= Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor= Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.Red;
            ReactorII.BackColor = Color.Red;
            label5.BackColor = Color.White;
            label2.BackColor = Color.White;
            label3.BackColor = Color.White;

            Refresh();
            Thread.Sleep(1000);

            ReactorI.BackColor = Color.White;
            ReactorII.BackColor = Color.White;
            label5.BackColor = Color.Red;
            label2.BackColor = Color.Red;
            label3.BackColor = Color.Red;
        }

        private void ReactorII_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

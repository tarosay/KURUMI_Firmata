using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Firmata.NET;

namespace KURUMI_Firmata
{
    public partial class Form1 : Form
    {
        private Arduino Kurumi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kurumi = new Arduino("COM21", 115200, true, 1000);

            Kurumi.pinMode(2, Arduino.INPUT);
            Kurumi.pinMode(3, Arduino.INPUT);
            Kurumi.pinMode(4, Arduino.INPUT);
            Kurumi.pinMode(5, Arduino.INPUT);
            Kurumi.pinMode(6, Arduino.INPUT);
            Kurumi.pinMode(7, Arduino.INPUT);
            Kurumi.pinMode(8, Arduino.INPUT);
            Kurumi.pinMode(9, Arduino.INPUT);

            Kurumi.digitalWrite(22, Arduino.LOW);
            Kurumi.digitalWrite(23, Arduino.LOW);
            Kurumi.digitalWrite(24, Arduino.LOW);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Kurumi != null)
            {
                Kurumi.Close();
            }
        }

        private void Black_Click(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(22, Arduino.HIGH);
            Kurumi.digitalWrite(23, Arduino.HIGH);
            Kurumi.digitalWrite(24, Arduino.HIGH);
        }

        private void White_Click(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(22, Arduino.LOW);
            Kurumi.digitalWrite(23, Arduino.LOW);
            Kurumi.digitalWrite(24, Arduino.LOW);
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(22, Arduino.HIGH);
            Kurumi.digitalWrite(23, Arduino.HIGH);
            Kurumi.digitalWrite(24, Arduino.LOW);
        }

        private void Red_Click(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(22, Arduino.LOW);
            Kurumi.digitalWrite(23, Arduino.HIGH);
            Kurumi.digitalWrite(24, Arduino.HIGH);
        }

        private void SkyBlue_Click(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(22, Arduino.HIGH);
            Kurumi.digitalWrite(23, Arduino.LOW);
            Kurumi.digitalWrite(24, Arduino.LOW);
        }

        private void Green_Click(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(22, Arduino.HIGH);
            Kurumi.digitalWrite(23, Arduino.LOW);
            Kurumi.digitalWrite(24, Arduino.HIGH);
        }

        private void Violet_Click(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(22, Arduino.LOW);
            Kurumi.digitalWrite(23, Arduino.HIGH);
            Kurumi.digitalWrite(24, Arduino.LOW);
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(22, Arduino.LOW);
            Kurumi.digitalWrite(23, Arduino.LOW);
            Kurumi.digitalWrite(24, Arduino.HIGH);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Kurumi == null)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (Kurumi == null)
            {
                this.Close();
            }
        }

        private void btnRead22_Click(object sender, EventArgs e)
        {
            string j = "";
            for (int i = 0; i <4; i++)
            {
                int a = Kurumi.analogRead(i);
                j = j + a.ToString().Trim() + " ";
            }
            this.textBox1.Text = j;
        }

        private void btnDigitalRead_Click(object sender, EventArgs e)
        {
            digiread();
        }

        private void digiread()
        {
            string j = "";
            for (int i = 2; i <= 9; i++)
            {
                int a = Kurumi.digitalRead(i);
                j = j + a.ToString().Trim() + " ";
            }
            this.textBox1.Text = j;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            Kurumi.pinMode(2, Arduino.OUTPUT);

            int m = Kurumi.digitalRead(2);
            if (m == 0)
            {
                Kurumi.digitalWrite(2, Arduino.HIGH);
            }
            else
            {
                Kurumi.digitalWrite(2, Arduino.LOW);
            }

            digiread();
        }
    }
}

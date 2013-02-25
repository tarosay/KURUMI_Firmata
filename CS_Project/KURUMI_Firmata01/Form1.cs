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
            for (int i = 0; i < 8; i++)
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
            for (int i = 0; i < 25; i++)
            {
                int a = Kurumi.digitalRead(i);
                j = j + a.ToString().Trim() + " ";
            }
            this.textBox2.Text = j;
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            Kurumi.pinMode(2, Arduino.OUTPUT);
            Kurumi.pinMode(3, Arduino.OUTPUT);
            Kurumi.pinMode(4, Arduino.OUTPUT);
            Kurumi.pinMode(5, Arduino.OUTPUT);
            Kurumi.pinMode(6, Arduino.OUTPUT);
            Kurumi.pinMode(7, Arduino.OUTPUT);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(2, checkBox1.Checked == true ? Arduino.HIGH : Arduino.LOW);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(3, checkBox2.Checked == true ? Arduino.HIGH : Arduino.LOW);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(4, checkBox3.Checked == true ? Arduino.HIGH : Arduino.LOW);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(5, checkBox4.Checked == true ? Arduino.HIGH : Arduino.LOW);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(6, checkBox5.Checked == true ? Arduino.HIGH : Arduino.LOW);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Kurumi.digitalWrite(7, checkBox6.Checked == true ? Arduino.HIGH : Arduino.LOW);
        }
    }
}

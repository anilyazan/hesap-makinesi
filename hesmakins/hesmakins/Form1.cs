﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesmakins
{
    public partial class Form1 : Form
    {
        private char _islem;
       private bool _ekranTemizlenecekMi;
        private int _ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi=false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi=false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
             if(ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi=false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi=false;
            }
            if(ekranLabel.Text == "0")ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";

        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;

            }
            if (ekranLabel.Text == "9") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi=false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {

        }

        private void artiButton_Click(object sender, EventArgs e)
        {
             _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranLabel.Text);

        }

        private void boluButton_Click(object sender, EventArgs e)
        {

        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int ikincisayi= Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikincisayi;
                    break;
                case '-': 
                    sonuc= _ilkSayi - ikincisayi;
                    break;

                case '*':
                    sonuc= _ilkSayi * ikincisayi;
                    break;

                case '/':
                    sonuc= _ilkSayi / ikincisayi;
                    break;
                default:
                    sonuc= 0;
                    break;

            }
            ekranLabel.Text=Convert.ToString(sonuc);

        }
    }
}

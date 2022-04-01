using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REG_MARK_LIB;
using VIN_LIB;

namespace marka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Moibjak a = new Moibjak();  // ввод класса библиотеки для вывода метода 
            bool ex = a.CheckMark(textBox1.Text); 
            if(ex == true)
            {
                label1.Text = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Не правильно");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Moibjak a = new Moibjak(); // ввод класса библиотеки для вывода метода 
            string l = a.GetNextMarkAfter(textBox1.Text);
            string c = textBox1.Text.Substring(0, 6);
            string j = l.Substring(1,3);
            int i = Convert.ToInt32(j);
            int by = i + 1;
            if(i == 999)
            {
                label2.Text = textBox1.Text.Replace(c, "а452сн");
            }
            else if (i == 000)
            {
                MessageBox.Show("Номер сериии равен 0");
            }
            else
            {
                    label2.Text = by.ToString();              
            }  
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Moibjak a = new Moibjak(); // ввод класса библиотеки для вывода метода 
            string ge;
            string h = textBox2.Text;
            string g = textBox3.Text;
            string l = a.GetNextMarkAfterRange(textBox1.Text, textBox2.Text, textBox3.Text);
            string ytq = textBox1.Text.Substring(1, 3);
            int h1 = Convert.ToInt32(textBox2.Text);
            int h2 = Convert.ToInt32(textBox3.Text);
            int yte = Convert.ToInt32(ytq);
            if(h1 > yte || yte < h2)
            {
                    ge = (yte + h1).ToString(); 
                    label3.Text = ge;
            }
            else if (h2 < yte)
            {
                label3.Text = "out of stock";
            }
            else
            {
                MessageBox.Show("out of stock");
            }

        }


        private void button5_Click(object sender, EventArgs e)
        {
            Kle a = new Kle(); // ввод класса библиотеки для вывода метода 
            bool l = a.CheckVIN(textBox4.Text);
            int bv = textBox4.TextLength;
            string hf= bv.ToString();
            if (l == true)
            {
                label5.Text = textBox4.Text;
                label8.Text=hf;
            }
            else
            {
                MessageBox.Show("Не правильно");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kle a = new Kle(); // ввод класса библиотеки для вывода метода 
            string l = a.GetVINCountry(textBox4.Text);
            string buv = l.Substring(0, 2);
            if(buv == "SA" || buv == "SM" || buv == "SN" || buv == "ST" || buv == "SU" || buv == "SZ" || buv == "S1" || buv == "S4" || buv == "TA"
                || buv == "TH" || buv == "TJ" || buv == "TP" || buv == "TR" || buv == "TV" || buv == "TW" || buv == "T1" || buv == "T2" || buv == "T0" || buv == "UA"
                || buv == "UG" || buv == "UH" || buv == "UM" || buv == "UN" || buv == "UT" || buv == "UU" || buv == "UZ" || buv == "U1" || buv == "U4" || buv == "U5" || buv == "U7"
                || buv == "U8" || buv == "U0" || buv == "VA" || buv == "VE" || buv == "VF" || buv == "VR" || buv == "VS" || buv == "VW" || buv == "VX" || buv == "V2" || buv == "V3" || buv == "V5" || buv == "V6"
                || buv == "V0" || buv == "WA" || buv == "W0" || buv == "XA" || buv == "XE" || buv == "XF" || buv == "XK" || buv == "XL" || buv == "XR" || buv == "XS"
                || buv == "XW" || buv == "XX" || buv == "X2" || buv == "X3" || buv == "X0" || buv == "YA" || buv == "YE" || buv == "YF" || buv == "YK" || buv == "YL"
                || buv == "YR" || buv == "YS" || buv == "YW" || buv == "YX" || buv == "Y2" || buv == "Y3" || buv == "Y5" || buv == "Y6" || buv == "Y0" || buv == "ZA"
                || buv == "ZR" || buv == "ZS" || buv == "ZW" || buv == "ZX" || buv == "Z2" || buv == "Z3" || buv == "Z5" || buv == "Z6" || buv == "Z0")
            {
                label6.Text = "Европа";
            }
            else if(buv == "AA" || buv == "AH" || buv == "AJ" || buv == "AP" || buv == "A0" || buv == "BA" || buv == "BE" || buv == "BF" || buv == "BK"
                || buv == "BL" || buv == "BR" || buv == "BS" || buv == "B0" || buv == "CA" || buv == "CE" || buv == "CF" || buv == "CK" || buv == "CL" || buv == "CR"
                || buv == "CS" || buv == "C0" || buv == "DA" || buv == "DE" || buv == "DF" || buv == "DK" || buv == "DL" || buv == "DR" || buv == "DS" || buv == "D0" || buv == "EA"
                || buv == "EE" || buv == "EF" || buv == "EK" || buv == "EL" || buv == "E0" || buv == "FA" || buv == "FE" || buv == "FF" || buv == "FK" || buv == "FL" || buv == "F0" || buv == "GA" || buv == "G0"
                || buv == "HA" || buv == "H0" )
            {
                label6.Text = "Африка";
            }
            else if (buv == "JA" || buv == "JT" || buv == "KA" || buv == "KE" || buv == "KF" || buv == "KK" || buv == "KL" || buv == "KR" || buv == "KS"
                || buv == "K0" || buv == "LA" || buv == "L0" || buv == "MA" || buv == "ME" || buv == "MF" || buv == "MK" || buv == "ML" || buv == "MR" || buv == "MS"
                || buv == "M0" || buv == "NF" || buv == "NK" || buv == "NL" || buv == "NR" || buv == "NT" || buv == "N0" || buv == "PA" || buv == "PE" || buv == "PF" || buv == "PK"
                || buv == "PL" || buv == "PR" || buv == "PS" || buv == "P0" || buv == "RA" || buv == "RE" || buv == "RF" || buv == "RK" || buv == "RL" || buv == "RR" || buv == "RS" || buv == "R0")
            {
                label6.Text = "Азия";
            }
            else if (buv == "1A" || buv == "10" || buv == "2A" || buv == "20" || buv == "3A" || buv == "3W" || buv == "3X" || buv == "37" || buv == "38"
                || buv == "30" || buv == "4A" || buv == "40" || buv == "5A" || buv == "50")
            {
                label6.Text = "Северная Америка";
            }
            else if (buv == "8A" || buv == "8E" || buv == "8F" || buv == "8K" || buv == "8L" || buv == "8R" || buv == "8S" || buv == "8W" || buv == "8X"
                || buv == "82" || buv == "83" || buv == "80" || buv == "9A" || buv == "9E" || buv == "9F" || buv == "9K" || buv == "9L" || buv == "9R" || buv == "9S"
                || buv == "9W" || buv == "9X" || buv == "92" || buv == "93" || buv == "99" || buv == "90")
            {
                label6.Text = "Южная Америка";
            }
            else if (buv == "6A" || buv == "6W" || buv == "6X" || buv == "60" || buv == "7A" || buv == "7E" || buv == "7F" || buv == "70")
            {
                label6.Text = "Океания";
            }
            else
            {
                MessageBox.Show("Такого региона нет");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Kle a = new Kle(); // ввод класса библиотеки для вывода метода 
            string l = a.GetTransportYear(textBox4.Text);
            string buv = l.Substring(10);
            if(buv == "A" || buv == "B" || buv == "C" || buv == "D" || buv == "E" || buv == "F" || buv == "G" || buv == "H" || buv == "J" || buv == "K" || buv == "L" || buv == "M" || buv == "N" || buv == "P" || buv == "R"
                || buv == "S" || buv == "T" || buv == "V" || buv == "W" || buv == "X" || buv == "Y")
            {
                label7.Text = "Автомобиль выпущен раньее 2000 года";
            }
            else if(buv == "1")
            {
                label7.Text = "Автомобиль выпущен в 2001 году";
            }
            else if (buv == "2")
            {
                label7.Text = "Автомобиль выпущен в 2002 году";
            }
            else if (buv == "3")
            {
                label7.Text = "Автомобиль выпущен в 2003 году";
            }
            else if (buv == "4")
            {
                label7.Text = "Автомобиль выпущен в 2004 году";
            }
            else if (buv == "5")
            {
                label7.Text = "Автомобиль выпущен в 2005 году";
            }
            else if (buv == "6")
            {
                label7.Text = "Автомобиль выпущен в 2006 году";
            }
            else if (buv == "7")
            {
                label7.Text = "Автомобиль выпущен в 2007 году";
            }
            else if (buv == "8")
            {
                label7.Text = "Автомобиль выпущен в 2008 году";
            }
            else if (buv == "9")
            {
                label7.Text = "Автомобиль выпущен в 2009 году";
            }
            else if (buv == "A")
            {
                label7.Text = "Автомобиль выпущен в 2010 году";
            }
            else if (buv == "B")
            {
                label7.Text = "Автомобиль выпущен в 2011 году";
            }
            else if (buv == "C")
            {
                label7.Text = "Автомобиль выпущен в 2012 году";
            }
            else if (buv == "D")
            {
                label7.Text = "Автомобиль выпущен в 2013 году";
            }
            else if (buv == "E")
            {
                label7.Text = "Автомобиль выпущен в 2014 году";
            }
            else if (buv == "F")
            {
                label7.Text = "Автомобиль выпущен в 2015 году";
            }
            else if (buv == "G")
            {
                label7.Text = "Автомобиль выпущен в 2016 году";
            }
            else if (buv == "T")
            {
                label7.Text = "Автомобиль выпущен в 2017 году";
            }
            else if (buv == "J")
            {
                label7.Text = "Автомобиль выпущен в 2018 году";
            }
            else if (buv == "K")
            {
                label7.Text = "Автомобиль выпущен в 2019 году";
            }
            else if (buv == "L")
            {
                label7.Text = "Автомобиль выпущен в 2020 году";
            }
            else if (buv == "M")
            {
                label7.Text = "Автомобиль выпущен в 2021 году";
            }
            else
            {
                label7.Text = "Автомобиль выпущен раньше 2022 года";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Moibjak a = new Moibjak();
            int l = a.GetCombinationsCountlnRange(textBox5.Text, textBox6.Text);
            label4.Text = l.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //formumuz çalıştırıldığı zaman bu metot çalışmaktadır.

        }

        private void btn_ortalamaHesapla_Click(object sender, EventArgs e)
        {
            double ortalama = (Convert.ToDouble(txt_birinciNot.Text) + Convert.ToDouble(txt_ikinciNot.Text))/2;

            lbl_ortalamaSonuc.Text = ortalama.ToString();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kocaeli_Travel_App
{
    public partial class AddExpedition : Form
    {
        public Expedition expedition;
          public static int x = 1;

        public AddExpedition()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Todo Sefer ekle

            x = x + 1;
        
            expedition = new Expedition(
                id.Text,
                road.Text,
                date.Text,
                time.Text,
                capacity.Text,
                price.Text,
                licancePlate.Text,
                captain.Text
                );

            for (int i = 0; i < int.Parse(capacity.Text); i++)
            {
                expedition.Armchairs.myAdd(new Armchair((i+1).ToString(), "", "", "Boş", price.Text));
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

            
        }

        private void AddExpedition_Load(object sender, EventArgs e)
        {
            id.Text = x.ToString();

            //   x++;
            //    MessageBox.Show(x.ToString());
        }
    }
}

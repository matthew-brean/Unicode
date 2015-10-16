
/*
Created by: Matthew Brean
Created on: 2015-10-16
Created for: ICS3U
Daily Assignment: Unit #3-10
This program shows you how to write letters in unicode.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowUnicode_Click(object sender, EventArgs e)
        {
            //variable

            this.lstUnicode.Items.Clear();

            for (int loop = 65; loop <= 90; loop++)

            {
                this.lstUnicode.Items.Add(Char.ConvertFromUtf32(loop) + " --> " + loop);
            }

            

        }
    }
}

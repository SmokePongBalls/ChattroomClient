﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattrumClient2
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
            public string LabelText
        {
            get
            {
                return this.lblError.Text;
            }
            set
            {
                this.lblError.Text = value;
            }
        }
    
        
    

        private void btnError_Click(object sender, EventArgs e)
        {

           
            this.Close();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Csharp_passwordhash
{
    public partial class Form1 : Form
    {
        static string shaHash256(string unHashedString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(unHashedString));
            foreach(byte singlebyte in crypto)
            {
                hash.Append(singlebyte.ToString("x2"));
            }
            return hash.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hashedMessage2_Click(object sender, EventArgs e)
        {

        }
    }
}
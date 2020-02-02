using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        short numberOfEnteredPasswords = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            numberOfEnteredPasswords++;
            string filepath = @"C:\Users\Bruno\Desktop\passwordStorage\password.txt";
            string hashedPassword = enteredPasswordTB.Text;
            if (hashedPassword == string.Empty)
                numberOfEnteredPasswords--;
            hashedPassword = shaHash256(hashedPassword);
            enteredPasswordTB.Text = "";
            hashedMessage2.Text = "Hashed and entered successfully.";
            hashedMessage2.Visible = true;
            if (numberOfEnteredPasswords > 1)
            {
                numberOfTimes.Text = "You entered " + numberOfEnteredPasswords + " passwords.";
                numberOfTimes.Visible = true;
            }
            using (StreamWriter writer = File.AppendText(filepath))
            {
                writer.WriteLine(hashedPassword);
                hashedPassword = string.Empty;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            passwordExistsLabel.Visible = false;
            passwordDoesntExistLabel.Visible = false;
            string filepath=@"C:\Users\Bruno\Desktop\passwordStorage\password.txt";
            string passwordForChecking = textBox1.Text;
            passwordForChecking = shaHash256(passwordForChecking);
            short doesPassExistFlag = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filepath);
            while ((line = file.ReadLine()) != null)
            {
                string tempDoesPassExist = string.Compare(line, passwordForChecking, false) == 0 ? "yes" : "no";
                if (tempDoesPassExist == "yes")
                    doesPassExistFlag = 1;
            }
            if (doesPassExistFlag == 1)
                passwordExistsLabel.Visible = true;
            else
                passwordDoesntExistLabel.Visible = true;
        }

        private void databaseButton_Click(object sender, EventArgs e)
        {
            Form2 databaseAccess = new Form2();
            databaseAccess.ShowDialog();
        }
    }
}

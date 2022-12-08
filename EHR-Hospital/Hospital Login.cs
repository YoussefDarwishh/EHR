﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EHR_Hospital
{
    public partial class Hospital_Login : Form
    {
        public Hospital_Login()
        {
            InitializeComponent();
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email (example@email.com)")
            {
                Email.Text = "";
                Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email (example@email.com)";
                Email.StateActive.Content.Color1 = System.Drawing.Color.Silver;
            }
            else
            {
                Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            Regex expression = new Regex("^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)$");

            if (!expression.IsMatch(Email.Text))
            {
                //emailerror.SetError(Email, "Enter a Correct Email");
            }
            else
            {
                //emailerror.SetError(Email, "");
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.StateActive.Content.Color1 = System.Drawing.Color.Black;
                Password.PasswordChar = '*';
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.StateActive.Content.Color1 = System.Drawing.Color.Silver;
                Password.PasswordChar = Email.PasswordChar;
            }
            else
            {
                Password.StateActive.Content.Color1 = System.Drawing.Color.Black;
            }
        }

        private void Password_Validating(object sender, CancelEventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hospital_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat1._0
{
    public partial class FormLoginSignup : Form
    {
        public FormLoginSignup()
        {
            InitializeComponent();
        }
        //TODO Add verify password field and associated code for sign up attempts

        private void FormLoginSignup_Load(object sender, EventArgs e)
        {
            // I have these hidden on form load instead of on design view
            // so the labels can be seen and modified without going under all controls
            lblDisplayUsernameError.Visible = false;
            lblDisplayPasswordError.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Resize the form to allow for addition of a verify password field
            // when the user selects sign up 
            this.Height += 51;

            // Adjusts the controls of the form
            Point p = new Point(9, 161);
            this.btnExit.Location = p;
            p = new Point(111, 161);
            this.btnSignUp.Location = p;
            this.btnLogin.Visible = false;

            // Adds the confirm password control label
            Label lblPasswordConfirm = new Label();
            lblPasswordConfirm.Width = 58;
            lblPasswordConfirm.Height = 26;
            p = new Point(12,112);
            lblPasswordConfirm.Location = p;
            lblPasswordConfirm.Text = "Confirm Password:";
            this.Controls.Add(lblPasswordConfirm);

            // Adds the Password confirmation box
            TextBox txtPasswordConfirm = new TextBox();
            txtPasswordConfirm.Width = 100;
            txtPasswordConfirm.Height = 20;
            p = new Point(74, 124);
            txtPasswordConfirm.Location = p;
            txtPasswordConfirm.PasswordChar = '*';
            this.Controls.Add(txtPasswordConfirm);

            // Changes the click event on Signup button
            this.btnSignUp.Click -= btnSignUp_Click;
            this.btnSignUp.Click += btnSignUp_SecondClick;
        }

        // New signup method button click
        private void btnSignUp_SecondClick(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
            // Add the signup protocall to this method;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

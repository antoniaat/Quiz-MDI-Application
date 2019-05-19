﻿using Quiz_MDI_Application.Data;
using System;
using System.Windows.Forms;

namespace Quiz_MDI_Application.Forms
{
    public partial class AdminHomeForm : System.Windows.Forms.Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Database.Logout();
        }

        private void CreateQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateQuizForm quizForm = new CreateQuizForm();
            quizForm.ShowDialog();
        }

        private void AllQuizesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HomeForm allQuizesForm = new HomeForm();
            allQuizesForm.ShowDialog();
        }
    }
}

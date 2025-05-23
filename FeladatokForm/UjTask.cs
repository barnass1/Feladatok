﻿using FeladatokForm.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FeladatokForm
{
    public partial class UjTask : Form
    {
        private FeladatokDbContext _context;
        private bool _taskSaved = false;

        public UjTask()
        {
            InitializeComponent();
            UjTask_Load(null, null);
        }

        private void UjTask_Load(object sender, EventArgs e)
        {
            _context = new FeladatokDbContext();
            var felhasznalok = _context.Users.ToList();

            comboBox3.DataSource = felhasznalok;
            comboBox3.DisplayMember = "Username";
            comboBox3.ValueMember = "Id";

            var priorityList = new[] { "Alacsony", "Közepes", "Magas" };
            comboBox1.DataSource = priorityList;

            var statusList = new[] { "Új", "Folyamatban", "Kész" };
            comboBox2.DataSource = statusList;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker1.ShowUpDown = true;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newTask = new Models.Task
            {
                Title = textBox1.Text,
                Description = textBox2.Text,
                DueDate = dateTimePicker1.Value,
                UserId = (int)comboBox3.SelectedValue,
                Priority = comboBox1.Text,
                Status = comboBox2.Text,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Tasks.Add(newTask);
            _context.SaveChanges();

            MessageBox.Show("Task saved successfully!");
            _taskSaved = true;
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!_taskSaved && e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("A nem mentett adatok elvesznek, biztosan bezárod?", "Ablak bezárása", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            base.OnFormClosing(e);

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "A cím nem lehet üres!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "A leírás nem lehet üres");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {
                errorProvider1.SetError(dateTimePicker1, "A határidő nem lehet a múltban!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, null);
            }
        }
    }
}

using FeladatokForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FeladatokForm
{
    public partial class FeladatSzerkesztes : Form
    {
        private FeladatokDbContext _context;
        private Models.Task _task;
        private bool _taskSaved = false;

        public FeladatSzerkesztes(Models.Task task)
        {
            InitializeComponent();
            _context = new FeladatokDbContext();
            _task = task;
            LoadTaskDetails();
        }

        private void LoadTaskDetails()
        {
            var priorityList = new[] { "Alacsony", "Közepes", "Magas" };
            comboBox1.DataSource = priorityList;

            var statusList = new[] { "Új", "Folyamatban", "Kész" };
            comboBox2.DataSource = statusList;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker1.ShowUpDown = true;

            textBox1.Text = _task.Title;
            textBox2.Text = _task.Description;
            dateTimePicker1.Value = _task.DueDate ?? DateTime.Now;
            comboBox1.SelectedItem = _task.Priority;
            comboBox2.SelectedItem = _task.Status;

            
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _task.Title = textBox1.Text;
            _task.Description = textBox2.Text;
            _task.DueDate = dateTimePicker1.Value;
            _task.Priority = comboBox1.Text;
            _task.Status = comboBox2.Text;
            _task.UpdatedAt = DateTime.Now;

            _context.Tasks.Update(_task);
            _context.SaveChanges();

            MessageBox.Show("Task updated successfully!");
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
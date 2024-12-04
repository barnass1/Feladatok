using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeladatokForm
{
    public partial class FelhasznaloHozzaadas : Form
    {
        private bool _taskSaved = false;
        public FelhasznaloHozzaadas()
        {
            InitializeComponent();
            textBox3.UseSystemPasswordChar = true;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var context = new Models.FeladatokDbContext())
            {
                var existingUser = context.Users.FirstOrDefault(u => u.Username == textBox1.Text);
                if (existingUser != null)
                {
                    MessageBox.Show("A felhasználónév már létezik, kérjük válasszon másikat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newFelhasznalo = new Models.User
                {
                    Username = textBox1.Text,
                    PasswordHash = textBox3.Text,
                    Email = textBox2.Text,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                context.Users.Add(newFelhasznalo);
                context.SaveChanges();
            }

            MessageBox.Show("Felhasználó sikeresen hozzáadva!");
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
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "A felhasználónév nem lehet üres!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Az email cím nem lehet üres!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, null);
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.IsMatch(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Az email cím formátuma nem megfelelő!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, null);
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "A jelszó nem lehet üres!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, null);
            }
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
            if (!regex.IsMatch(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "A jelszó formátuma nem megfelelő!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, null);
            }

        }
    }
}

using FeladatokForm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FeladatokForm
{
    public partial class UjTask : Form
    {
        private FeladatokDbContext _context;

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
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newTask = new Models.Task
            {
                Title = textBox1.Text,
                Description = textBox2.Text,
                DueDate = dateTimePicker1.Value,
                UserId = (int)comboBox3.SelectedValue,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Tasks.Add(newTask);
            _context.SaveChanges();

            MessageBox.Show("Task saved successfully!");
            this.Close();
        }

    }
}

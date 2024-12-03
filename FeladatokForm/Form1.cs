using FeladatokForm.Models;

namespace FeladatokForm
{
    public partial class Form1 : Form
    {
        private FeladatokDbContext _context;
        public Form1()
        {
            InitializeComponent();
            Load_Feladatok();
            Load_Felhasznalok();
        }

        private void Load_Feladatok()
        {
            _context = new FeladatokDbContext();
            var feladatok = _context.Tasks.ToList();

            FeladatokDataGridView1.AutoGenerateColumns = false;
            FeladatokDataGridView1.DataSource = feladatok;

            FeladatokDataGridView1.Columns.Clear();
            AddColumn("Title", "Cím");
            AddColumn("Description", "Leírás");
            AddColumn("DueDate", "Határidõ");
            AddColumn("Priority", "Fontosság");
            AddColumn("Status", "Státusz");
            AddColumn("CreatedAt", "Létrehozva");
            AddColumn("UpdatedAt", "Frissítve");
        }

        private void AddColumn(string dataPropertyName, string headerText)
        {
            FeladatokDataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText
            });
        }


        private void Load_Felhasznalok()
        {
            _context = new FeladatokDbContext();
            var felhasznalok = _context.Users.ToList();
            userBindingSource.DataSource = felhasznalok;
        }

        private void listBoxFelhasznalok_SelectedIndexChanged(object sender, EventArgs e)
        {
            var felhasznalo = (User)listBoxFelhasznalok.SelectedItem;
            if (felhasznalo != null)
            {
                var feladatok = _context.Tasks.Where(t => t.UserId == felhasznalo.Id).ToList();
                FeladatokDataGridView1.DataSource = feladatok;
            }
            else
            {
                FeladatokDataGridView1.DataSource = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = textBox1.Text.ToLower();
            var filtereddata = _context.Users.Where(u => u.Username.ToLower().Contains(filter)).ToList();
            userBindingSource.DataSource = filtereddata;
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            UjTask ujTaskForm = new UjTask();
            ujTaskForm.ShowDialog();
        }
    }
}

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
            AddColumn("Title", "C�m");
            AddColumn("Description", "Le�r�s");
            AddColumn("DueDate", "Hat�rid�");
            AddColumn("Priority", "Fontoss�g");
            AddColumn("Status", "St�tusz");
            AddColumn("CreatedAt", "L�trehozva");
            AddColumn("UpdatedAt", "Friss�tve");
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Biztosan bez�rod?", "Ablak bez�r�sa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            base.OnFormClosing(e);
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (FeladatokDataGridView1.CurrentRow != null && FeladatokDataGridView1.CurrentRow.DataBoundItem != null)
            {
                var selectedTask = (Models.Task)FeladatokDataGridView1.CurrentRow.DataBoundItem;
                _context.Tasks.Remove(selectedTask);
                _context.SaveChanges();
                Load_Feladatok();
            }
            else
            {
                MessageBox.Show("Nincs t�r�lhet� feladat");
            }
        }


        private void buttonSzerk_Click(object sender, EventArgs e)
        {
            if (FeladatokDataGridView1.CurrentRow != null)
            {
                var selectedTask = (Models.Task)FeladatokDataGridView1.CurrentRow.DataBoundItem;
                FeladatSzerkesztes feladatSzerkesztesForm = new FeladatSzerkesztes(selectedTask);
                feladatSzerkesztesForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nincs fealadat kijel�lve");
            }
        }


        private void FelhasznaloTorles_Click(object sender, EventArgs e)
        {
            var selectedUser = (User)listBoxFelhasznalok.SelectedItem;
            if (selectedUser != null)
            {
                var result = MessageBox.Show(
                    "Biztosan kit�rl�d a felhaszn�l�t �s minden hozz� tartoz� feladatot?",
                    "Felhaszn�l� t�rl�se",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    var userTasks = _context.Tasks.Where(t => t.UserId == selectedUser.Id).ToList();
                    _context.Tasks.RemoveRange(userTasks);
                    _context.Users.Remove(selectedUser);
                    _context.SaveChanges();
                    Load_Felhasznalok();
                    Load_Feladatok();
                }
            }
            else
            {
                MessageBox.Show("Nincs kijel�lve felhaszn�l�");
            }
        }

        private void UjFelhasznalo_Click(object sender, EventArgs e)
        {
            FelhasznaloHozzaadas felhasznaloHozzaadasForm = new FelhasznaloHozzaadas();
            felhasznaloHozzaadasForm.ShowDialog();
            Load_Felhasznalok();
        }
    }
}

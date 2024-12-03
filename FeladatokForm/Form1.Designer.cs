namespace FeladatokForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CimText = new Label();
            FeladatokDataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatedAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            taskBindingSource = new BindingSource(components);
            UserChange = new Button();
            buttonUj = new Button();
            buttonSzerk = new Button();
            buttonTorles = new Button();
            listBoxFelhasznalok = new ListBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)FeladatokDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CimText
            // 
            CimText.AutoSize = true;
            CimText.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            CimText.Location = new Point(9, 7);
            CimText.Margin = new Padding(2, 0, 2, 0);
            CimText.Name = "CimText";
            CimText.Size = new Size(208, 54);
            CimText.TabIndex = 0;
            CimText.Text = "Feladatok";
            // 
            // FeladatokDataGridView1
            // 
            FeladatokDataGridView1.AutoGenerateColumns = false;
            FeladatokDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FeladatokDataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dueDateDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, createdAtDataGridViewTextBoxColumn, updatedAtDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, userDataGridViewTextBoxColumn });
            FeladatokDataGridView1.DataBindings.Add(new Binding("DataContext", userBindingSource, "Username", true));
            FeladatokDataGridView1.DataSource = taskBindingSource;
            FeladatokDataGridView1.Location = new Point(258, 78);
            FeladatokDataGridView1.Margin = new Padding(2);
            FeladatokDataGridView1.Name = "FeladatokDataGridView1";
            FeladatokDataGridView1.RowHeadersWidth = 82;
            FeladatokDataGridView1.RowTemplate.Height = 41;
            FeladatokDataGridView1.Size = new Size(952, 603);
            FeladatokDataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 10;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 200;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.MinimumWidth = 10;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            dueDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            dueDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
            priorityDataGridViewTextBoxColumn.HeaderText = "Priority";
            priorityDataGridViewTextBoxColumn.MinimumWidth = 10;
            priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            priorityDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 200;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            createdAtDataGridViewTextBoxColumn.MinimumWidth = 10;
            createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            createdAtDataGridViewTextBoxColumn.Width = 200;
            // 
            // updatedAtDataGridViewTextBoxColumn
            // 
            updatedAtDataGridViewTextBoxColumn.DataPropertyName = "UpdatedAt";
            updatedAtDataGridViewTextBoxColumn.HeaderText = "UpdatedAt";
            updatedAtDataGridViewTextBoxColumn.MinimumWidth = 10;
            updatedAtDataGridViewTextBoxColumn.Name = "updatedAtDataGridViewTextBoxColumn";
            updatedAtDataGridViewTextBoxColumn.Width = 200;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.HeaderText = "User";
            userDataGridViewTextBoxColumn.MinimumWidth = 10;
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            userDataGridViewTextBoxColumn.Width = 200;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // taskBindingSource
            // 
            taskBindingSource.DataSource = typeof(Models.Task);
            // 
            // UserChange
            // 
            UserChange.Location = new Point(9, 698);
            UserChange.Margin = new Padding(2);
            UserChange.Name = "UserChange";
            UserChange.Size = new Size(233, 36);
            UserChange.TabIndex = 3;
            UserChange.Text = "Felhasználók kezelése";
            UserChange.UseVisualStyleBackColor = true;
            // 
            // buttonUj
            // 
            buttonUj.Location = new Point(468, 698);
            buttonUj.Margin = new Padding(2);
            buttonUj.Name = "buttonUj";
            buttonUj.Size = new Size(244, 36);
            buttonUj.TabIndex = 4;
            buttonUj.Text = "Új feladat";
            buttonUj.UseVisualStyleBackColor = true;
            buttonUj.Click += buttonUj_Click;
            // 
            // buttonSzerk
            // 
            buttonSzerk.Location = new Point(717, 698);
            buttonSzerk.Margin = new Padding(2);
            buttonSzerk.Name = "buttonSzerk";
            buttonSzerk.Size = new Size(244, 36);
            buttonSzerk.TabIndex = 5;
            buttonSzerk.Text = "Feladat szerkesztése";
            buttonSzerk.UseVisualStyleBackColor = true;
            // 
            // buttonTorles
            // 
            buttonTorles.Location = new Point(965, 698);
            buttonTorles.Margin = new Padding(2);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(244, 36);
            buttonTorles.TabIndex = 6;
            buttonTorles.Text = "Feladat törlése";
            buttonTorles.UseVisualStyleBackColor = true;
            // 
            // listBoxFelhasznalok
            // 
            listBoxFelhasznalok.DataSource = userBindingSource;
            listBoxFelhasznalok.DisplayMember = "Username";
            listBoxFelhasznalok.FormattingEnabled = true;
            listBoxFelhasznalok.ItemHeight = 25;
            listBoxFelhasznalok.Location = new Point(9, 128);
            listBoxFelhasznalok.Margin = new Padding(2);
            listBoxFelhasznalok.Name = "listBoxFelhasznalok";
            listBoxFelhasznalok.Size = new Size(234, 554);
            listBoxFelhasznalok.TabIndex = 7;
            listBoxFelhasznalok.SelectedIndexChanged += listBoxFelhasznalok_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 31);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 743);
            Controls.Add(textBox1);
            Controls.Add(listBoxFelhasznalok);
            Controls.Add(buttonTorles);
            Controls.Add(buttonSzerk);
            Controls.Add(buttonUj);
            Controls.Add(UserChange);
            Controls.Add(FeladatokDataGridView1);
            Controls.Add(CimText);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)FeladatokDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)taskBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CimText;
        private DataGridView FeladatokDataGridView1;
        private Button UserChange;
        private Button buttonUj;
        private Button buttonSzerk;
        private Button buttonTorles;
        private ListBox listBoxFelhasznalok;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updatedAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private BindingSource taskBindingSource;
        private BindingSource userBindingSource;
        private TextBox textBox1;
    }
}

namespace FeladatokForm
{
    partial class UjTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            CimText = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(531, 31);
            textBox1.TabIndex = 0;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(32, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(531, 31);
            textBox2.TabIndex = 1;
            textBox2.Validating += textBox2_Validating;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 401);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(531, 33);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(32, 511);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(531, 33);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(32, 634);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(531, 33);
            comboBox3.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(35, 299);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(528, 31);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(32, 742);
            button1.Name = "button1";
            button1.Size = new Size(531, 57);
            button1.TabIndex = 8;
            button1.Text = "Mentés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSave_Click;
            // 
            // CimText
            // 
            CimText.AutoSize = true;
            CimText.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            CimText.Location = new Point(11, 9);
            CimText.Margin = new Padding(2, 0, 2, 0);
            CimText.Name = "CimText";
            CimText.Size = new Size(207, 54);
            CimText.TabIndex = 9;
            CimText.Text = "Új feladat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 97);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 10;
            label1.Text = "Cím";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 182);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 11;
            label2.Text = "Leírás";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 271);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 12;
            label3.Text = "Határidő";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 373);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 13;
            label4.Text = "Fontosság";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 483);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 14;
            label5.Text = "Státusz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 606);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 15;
            label6.Text = "Felhasználó";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UjTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 835);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CimText);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "UjTask";
            Text = "UjTask";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label CimText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ErrorProvider errorProvider1;
    }
}
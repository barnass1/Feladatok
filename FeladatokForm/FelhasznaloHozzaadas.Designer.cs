namespace FeladatokForm
{
    partial class FelhasznaloHozzaadas
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
            CimText = new Label();
            buttonSave = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // CimText
            // 
            CimText.AutoSize = true;
            CimText.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            CimText.Location = new Point(11, 9);
            CimText.Margin = new Padding(2, 0, 2, 0);
            CimText.Name = "CimText";
            CimText.Size = new Size(469, 54);
            CimText.TabIndex = 24;
            CimText.Text = "Felhasználó hozzáadása";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(37, 423);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(526, 59);
            buttonSave.TabIndex = 25;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(526, 31);
            textBox1.TabIndex = 26;
            textBox1.Validating += textBox1_Validating;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(526, 31);
            textBox2.TabIndex = 27;
            textBox2.Validating += textBox2_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 323);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(526, 31);
            textBox3.TabIndex = 28;
            textBox3.Validating += textBox3_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 81);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 29;
            label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 186);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 30;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 295);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 31;
            label3.Text = "Jelszó";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FelhasznaloHozzaadas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 494);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonSave);
            Controls.Add(CimText);
            Name = "FelhasznaloHozzaadas";
            Text = "FelhasznaloHozzaadas";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CimText;
        private Button buttonSave;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}
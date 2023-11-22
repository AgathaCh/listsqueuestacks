namespace Cola
{
    partial class Cola2
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
            registersBox = new DataGridView();
            doc = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            consulta = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnRegister = new Button();
            deleteBtn = new Button();
            reportBtn = new Button();
            txtID = new TextBox();
            label1 = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            date = new DateTimePicker();
            label4 = new Label();
            appnmntBox = new ComboBox();
            label5 = new Label();
            txtCount = new TextBox();
            ageBox = new NumericUpDown();
            lblError = new Label();
            ((System.ComponentModel.ISupportInitialize)registersBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ageBox).BeginInit();
            SuspendLayout();
            // 
            // registersBox
            // 
            registersBox.BackgroundColor = Color.LightBlue;
            registersBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registersBox.Columns.AddRange(new DataGridViewColumn[] { doc, name, age, consulta, dataGridViewTextBoxColumn1 });
            registersBox.GridColor = SystemColors.ActiveBorder;
            registersBox.Location = new Point(12, 12);
            registersBox.Name = "registersBox";
            registersBox.RowTemplate.Height = 25;
            registersBox.Size = new Size(572, 181);
            registersBox.TabIndex = 0;
            // 
            // doc
            // 
            doc.HeaderText = "Documento";
            doc.Name = "doc";
            // 
            // name
            // 
            name.HeaderText = "Nombre Completo";
            name.Name = "name";
            // 
            // age
            // 
            age.HeaderText = "Edad";
            age.Name = "age";
            // 
            // consulta
            // 
            consulta.HeaderText = "Tipo de Consulta";
            consulta.Name = "consulta";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Fecha Cita";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(253, 394);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(608, 12);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Eliminar";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // reportBtn
            // 
            reportBtn.Location = new Point(608, 136);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(75, 23);
            reportBtn.TabIndex = 3;
            reportBtn.Text = "Reportes";
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(16, 228);
            txtID.Name = "txtID";
            txtID.Size = new Size(257, 23);
            txtID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 210);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 5;
            label1.Text = "Número de Identificación";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(300, 228);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(284, 23);
            nameBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 210);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 271);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 8;
            label3.Text = "Edad";
            // 
            // date
            // 
            date.Location = new Point(16, 344);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 326);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha para la Cita";
            // 
            // appnmntBox
            // 
            appnmntBox.FormattingEnabled = true;
            appnmntBox.Items.AddRange(new object[] { "Prioritaria", "General", "Urgencia" });
            appnmntBox.Location = new Point(300, 289);
            appnmntBox.Name = "appnmntBox";
            appnmntBox.Size = new Size(284, 23);
            appnmntBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 271);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 13;
            label5.Text = "Tipo de Consulta";
            // 
            // txtCount
            // 
            txtCount.BackColor = Color.Aquamarine;
            txtCount.Location = new Point(608, 170);
            txtCount.Name = "txtCount";
            txtCount.ReadOnly = true;
            txtCount.Size = new Size(75, 23);
            txtCount.TabIndex = 14;
            // 
            // ageBox
            // 
            ageBox.Location = new Point(16, 289);
            ageBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(257, 23);
            ageBox.TabIndex = 15;
            ageBox.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(300, 352);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(710, 429);
            Controls.Add(lblError);
            Controls.Add(ageBox);
            Controls.Add(txtCount);
            Controls.Add(label5);
            Controls.Add(appnmntBox);
            Controls.Add(label4);
            Controls.Add(date);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(reportBtn);
            Controls.Add(deleteBtn);
            Controls.Add(btnRegister);
            Controls.Add(registersBox);
            Name = "Form1";
            Text = "EPS SanarteYa";
            ((System.ComponentModel.ISupportInitialize)registersBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView registersBox;
        private Button btnRegister;
        private Button deleteBtn;
        private Button reportBtn;
        private TextBox txtID;
        private Label label1;
        private TextBox nameBox;
        private Label label2;
        private Label label3;
        private DateTimePicker date;
        private Label label4;
        private ComboBox appnmntBox;
        private Label label5;
        private TextBox txtCount;
        private NumericUpDown ageBox;
        private Label lblError;
        private DataGridViewTextBoxColumn doc;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn consulta;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
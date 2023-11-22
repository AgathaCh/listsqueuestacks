namespace Lista
{
    partial class Lista3
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
            gridEstudiantes = new DataGridView();
            rcivil = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            condEsp = new DataGridViewTextBoxColumn();
            Estrato = new DataGridViewTextBoxColumn();
            fecNac = new DataGridViewTextBoxColumn();
            Terapia = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            lblError = new Label();
            btnRegister = new Button();
            label6 = new Label();
            noRadio = new RadioButton();
            siRadio = new RadioButton();
            label5 = new Label();
            boxDate = new DateTimePicker();
            label4 = new Label();
            boxEstrato = new ComboBox();
            label3 = new Label();
            boxCondicion = new ComboBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtCivil = new TextBox();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            label7 = new Label();
            txtCivildel = new TextBox();
            errorLbl2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridEstudiantes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gridEstudiantes
            // 
            gridEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEstudiantes.Columns.AddRange(new DataGridViewColumn[] { rcivil, name, condEsp, Estrato, fecNac, Terapia });
            gridEstudiantes.Location = new Point(21, 16);
            gridEstudiantes.Name = "gridEstudiantes";
            gridEstudiantes.RowTemplate.Height = 25;
            gridEstudiantes.Size = new Size(645, 174);
            gridEstudiantes.TabIndex = 0;
            // 
            // rcivil
            // 
            rcivil.HeaderText = "Registro Civil";
            rcivil.Name = "rcivil";
            // 
            // name
            // 
            name.HeaderText = "Nombre Completo";
            name.Name = "name";
            // 
            // condEsp
            // 
            condEsp.HeaderText = "Condición Especial";
            condEsp.Name = "condEsp";
            // 
            // Estrato
            // 
            Estrato.HeaderText = "Estrato";
            Estrato.Name = "Estrato";
            // 
            // fecNac
            // 
            fecNac.HeaderText = "Fecha Nacimiento";
            fecNac.Name = "fecNac";
            // 
            // Terapia
            // 
            Terapia.HeaderText = "Terapia";
            Terapia.Name = "Terapia";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblError);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(noRadio);
            groupBox1.Controls.Add(siRadio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(boxDate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(boxEstrato);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(boxCondicion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCivil);
            groupBox1.Location = new Point(21, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 253);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(208, 196);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 13;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(208, 214);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 23);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 186);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "Terapia";
            // 
            // noRadio
            // 
            noRadio.AutoSize = true;
            noRadio.Location = new Point(68, 204);
            noRadio.Name = "noRadio";
            noRadio.Size = new Size(41, 19);
            noRadio.TabIndex = 10;
            noRadio.TabStop = true;
            noRadio.Text = "No";
            noRadio.UseVisualStyleBackColor = true;
            // 
            // siRadio
            // 
            siRadio.AutoSize = true;
            siRadio.Location = new Point(6, 204);
            siRadio.Name = "siRadio";
            siRadio.Size = new Size(34, 19);
            siRadio.TabIndex = 3;
            siRadio.TabStop = true;
            siRadio.Text = "Si";
            siRadio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 128);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha Nacimiento";
            // 
            // boxDate
            // 
            boxDate.Location = new Point(8, 146);
            boxDate.MaxDate = new DateTime(2023, 10, 25, 12, 39, 7, 0);
            boxDate.MinDate = new DateTime(1910, 12, 25, 0, 0, 0, 0);
            boxDate.Name = "boxDate";
            boxDate.Size = new Size(227, 23);
            boxDate.TabIndex = 8;
            boxDate.Value = new DateTime(2023, 10, 25, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 73);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Estrato";
            // 
            // boxEstrato
            // 
            boxEstrato.FormattingEnabled = true;
            boxEstrato.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            boxEstrato.Location = new Point(187, 91);
            boxEstrato.Name = "boxEstrato";
            boxEstrato.Size = new Size(48, 23);
            boxEstrato.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 73);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 5;
            label3.Text = "Condición Especial";
            // 
            // boxCondicion
            // 
            boxCondicion.FormattingEnabled = true;
            boxCondicion.Items.AddRange(new object[] { "Autismo", "Hiperactividad", "Discapacidad" });
            boxCondicion.Location = new Point(8, 91);
            boxCondicion.Name = "boxCondicion";
            boxCondicion.Size = new Size(152, 23);
            boxCondicion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 19);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre Completo";
            // 
            // txtName
            // 
            txtName.Location = new Point(187, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(142, 23);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 20);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Registro Civil";
            // 
            // txtCivil
            // 
            txtCivil.Location = new Point(8, 38);
            txtCivil.Name = "txtCivil";
            txtCivil.Size = new Size(135, 23);
            txtCivil.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(errorLbl2);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCivildel);
            groupBox2.Location = new Point(385, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 132);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(88, 69);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 19);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 13;
            label7.Text = "Registro Civil";
            // 
            // txtCivildel
            // 
            txtCivildel.Location = new Point(76, 37);
            txtCivildel.Name = "txtCivildel";
            txtCivildel.Size = new Size(135, 23);
            txtCivildel.TabIndex = 12;
            // 
            // errorLbl2
            // 
            errorLbl2.AutoSize = true;
            errorLbl2.ForeColor = Color.Red;
            errorLbl2.Location = new Point(6, 99);
            errorLbl2.Name = "errorLbl2";
            errorLbl2.Size = new Size(0, 15);
            errorLbl2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 492);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gridEstudiantes);
            Name = "Form1";
            Text = " Los Millenials";
            ((System.ComponentModel.ISupportInitialize)gridEstudiantes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridEstudiantes;
        private DataGridViewTextBoxColumn rcivil;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn condEsp;
        private DataGridViewTextBoxColumn Estrato;
        private DataGridViewTextBoxColumn fecNac;
        private DataGridViewTextBoxColumn Terapia;
        private GroupBox groupBox1;
        private Label label5;
        private DateTimePicker boxDate;
        private Label label4;
        private ComboBox boxEstrato;
        private Label label3;
        private ComboBox boxCondicion;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private TextBox txtCivil;
        private GroupBox groupBox2;
        private Button btnRegister;
        private Label label6;
        private RadioButton noRadio;
        private RadioButton siRadio;
        private Button btnDelete;
        private Label label7;
        private TextBox txtCivildel;
        private Label lblError;
        private Label errorLbl2;
    }
}
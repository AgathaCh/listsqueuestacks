namespace Pila
{
    partial class Pila
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
            label1 = new Label();
            totalbutton = new Button();
            removeregisters = new Button();
            label9 = new Label();
            affiliatefalse = new RadioButton();
            affiliatetrue = new RadioButton();
            label8 = new Label();
            date = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            numberbowling = new ComboBox();
            numberplayers = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            idnumber = new TextBox();
            address = new TextBox();
            fullname = new TextBox();
            sendform = new Button();
            total = new TextBox();
            dataReservas = new DataGridView();
            nombreCol = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            numPlayers = new DataGridViewTextBoxColumn();
            numBowling = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            afiliado = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            totalRec = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)numberplayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataReservas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(270, 22);
            label1.Name = "label1";
            label1.Size = new Size(270, 37);
            label1.TabIndex = 4;
            label1.Text = "Bolera Robles S.A.S ";
            // 
            // totalbutton
            // 
            totalbutton.BackColor = Color.Indigo;
            totalbutton.FlatStyle = FlatStyle.Popup;
            totalbutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalbutton.ForeColor = Color.AliceBlue;
            totalbutton.Location = new Point(186, 81);
            totalbutton.Name = "totalbutton";
            totalbutton.Size = new Size(204, 56);
            totalbutton.TabIndex = 6;
            totalbutton.Text = "Total Recaudado";
            totalbutton.UseVisualStyleBackColor = false;
            totalbutton.Click += totalbutton_Click;
            // 
            // removeregisters
            // 
            removeregisters.BackColor = Color.Indigo;
            removeregisters.FlatAppearance.BorderSize = 0;
            removeregisters.FlatStyle = FlatStyle.Popup;
            removeregisters.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            removeregisters.ForeColor = Color.AliceBlue;
            removeregisters.Location = new Point(409, 81);
            removeregisters.Name = "removeregisters";
            removeregisters.Size = new Size(196, 56);
            removeregisters.TabIndex = 7;
            removeregisters.Text = "Eliminar Ultimo Registro";
            removeregisters.UseVisualStyleBackColor = false;
            removeregisters.Click += removeregisters_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(455, 348);
            label9.Name = "label9";
            label9.Size = new Size(114, 21);
            label9.TabIndex = 43;
            label9.Text = "Total a pagar:";
            // 
            // affiliatefalse
            // 
            affiliatefalse.AutoSize = true;
            affiliatefalse.Location = new Point(99, 397);
            affiliatefalse.Name = "affiliatefalse";
            affiliatefalse.Size = new Size(41, 19);
            affiliatefalse.TabIndex = 42;
            affiliatefalse.TabStop = true;
            affiliatefalse.Text = "No";
            affiliatefalse.UseVisualStyleBackColor = true;
            affiliatefalse.CheckedChanged += affiliatefalse_CheckedChanged;
            // 
            // affiliatetrue
            // 
            affiliatetrue.AutoSize = true;
            affiliatetrue.Location = new Point(99, 372);
            affiliatetrue.Name = "affiliatetrue";
            affiliatetrue.Size = new Size(34, 19);
            affiliatetrue.TabIndex = 41;
            affiliatetrue.TabStop = true;
            affiliatetrue.Text = "Sí";
            affiliatetrue.UseVisualStyleBackColor = true;
            affiliatetrue.CheckedChanged += affiliatetrue_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(99, 348);
            label8.Name = "label8";
            label8.Size = new Size(186, 21);
            label8.TabIndex = 40;
            label8.Text = "¿Se encuentra afiliado?";
            // 
            // date
            // 
            date.Location = new Point(455, 303);
            date.Name = "date";
            date.Size = new Size(200, 23);
            date.TabIndex = 39;
            date.ValueChanged += date_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(455, 279);
            label7.Name = "label7";
            label7.Size = new Size(163, 21);
            label7.TabIndex = 38;
            label7.Text = "Fecha de la Reserva:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(455, 211);
            label6.Name = "label6";
            label6.Size = new Size(271, 21);
            label6.TabIndex = 37;
            label6.Text = "Número Pista de Bolos a Reservar:";
            // 
            // numberbowling
            // 
            numberbowling.FormattingEnabled = true;
            numberbowling.Items.AddRange(new object[] { "1", "2", "3", "4" });
            numberbowling.Location = new Point(455, 235);
            numberbowling.Name = "numberbowling";
            numberbowling.Size = new Size(121, 23);
            numberbowling.TabIndex = 36;
            numberbowling.SelectedIndexChanged += numberbowling_SelectedIndexChanged;
            // 
            // numberplayers
            // 
            numberplayers.Location = new Point(455, 164);
            numberplayers.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numberplayers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberplayers.Name = "numberplayers";
            numberplayers.Size = new Size(120, 23);
            numberplayers.TabIndex = 35;
            numberplayers.Value = new decimal(new int[] { 6, 0, 0, 0 });
            numberplayers.ValueChanged += numberplayers_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(455, 140);
            label5.Name = "label5";
            label5.Size = new Size(188, 21);
            label5.TabIndex = 34;
            label5.Text = "Cantidad de Jugadores:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(98, 279);
            label4.Name = "label4";
            label4.Size = new Size(187, 21);
            label4.TabIndex = 33;
            label4.Text = "Numero Identificación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(98, 211);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 32;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(98, 140);
            label2.Name = "label2";
            label2.Size = new Size(156, 21);
            label2.TabIndex = 31;
            label2.Text = "Nombre Completo:";
            // 
            // idnumber
            // 
            idnumber.Location = new Point(98, 306);
            idnumber.Name = "idnumber";
            idnumber.Size = new Size(272, 23);
            idnumber.TabIndex = 30;
            idnumber.TextChanged += idnumber_TextChanged;
            // 
            // address
            // 
            address.Location = new Point(98, 235);
            address.Name = "address";
            address.Size = new Size(272, 23);
            address.TabIndex = 29;
            address.TextChanged += address_TextChanged;
            // 
            // fullname
            // 
            fullname.Location = new Point(98, 164);
            fullname.Name = "fullname";
            fullname.Size = new Size(272, 23);
            fullname.TabIndex = 28;
            fullname.TextChanged += fullname_TextChanged;
            // 
            // sendform
            // 
            sendform.BackColor = Color.Indigo;
            sendform.FlatStyle = FlatStyle.Popup;
            sendform.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sendform.ForeColor = Color.AliceBlue;
            sendform.Location = new Point(331, 417);
            sendform.Name = "sendform";
            sendform.Size = new Size(152, 40);
            sendform.TabIndex = 45;
            sendform.Text = "Enviar formulario";
            sendform.UseVisualStyleBackColor = false;
            sendform.Click += sendform_Click;
            // 
            // total
            // 
            total.BackColor = Color.Gainsboro;
            total.Cursor = Cursors.IBeam;
            total.Location = new Point(455, 368);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(200, 23);
            total.TabIndex = 46;
            // 
            // dataReservas
            // 
            dataReservas.AllowUserToDeleteRows = false;
            dataReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataReservas.Columns.AddRange(new DataGridViewColumn[] { nombreCol, dataGridViewTextBoxColumn1, id, numPlayers, numBowling, dataGridViewTextBoxColumn2, afiliado, price });
            dataReservas.Location = new Point(772, 81);
            dataReservas.Name = "dataReservas";
            dataReservas.ReadOnly = true;
            dataReservas.RowTemplate.Height = 25;
            dataReservas.Size = new Size(271, 335);
            dataReservas.TabIndex = 47;
            // 
            // nombreCol
            // 
            nombreCol.HeaderText = "Nombre";
            nombreCol.Name = "nombreCol";
            nombreCol.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Dirección";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "Identificación";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // numPlayers
            // 
            numPlayers.HeaderText = "Jugadores";
            numPlayers.Name = "numPlayers";
            numPlayers.ReadOnly = true;
            // 
            // numBowling
            // 
            numBowling.HeaderText = "Pista";
            numBowling.Name = "numBowling";
            numBowling.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // afiliado
            // 
            afiliado.HeaderText = "Afiliado";
            afiliado.Name = "afiliado";
            afiliado.ReadOnly = true;
            // 
            // price
            // 
            price.HeaderText = "Precio";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // totalRec
            // 
            totalRec.BackColor = Color.Gainsboro;
            totalRec.Cursor = Cursors.IBeam;
            totalRec.Location = new Point(772, 439);
            totalRec.Name = "totalRec";
            totalRec.ReadOnly = true;
            totalRec.Size = new Size(200, 23);
            totalRec.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(772, 419);
            label10.Name = "label10";
            label10.Size = new Size(137, 21);
            label10.TabIndex = 49;
            label10.Text = "Total recaudado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1055, 480);
            Controls.Add(totalRec);
            Controls.Add(label10);
            Controls.Add(dataReservas);
            Controls.Add(total);
            Controls.Add(sendform);
            Controls.Add(label9);
            Controls.Add(affiliatefalse);
            Controls.Add(affiliatetrue);
            Controls.Add(label8);
            Controls.Add(date);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numberbowling);
            Controls.Add(numberplayers);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(idnumber);
            Controls.Add(address);
            Controls.Add(fullname);
            Controls.Add(removeregisters);
            Controls.Add(totalbutton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numberplayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button totalbutton;
        private Button removeregisters;
        private Label label9;
        private RadioButton affiliatefalse;
        private RadioButton affiliatetrue;
        private Label label8;
        private DateTimePicker date;
        private Label label7;
        private Label label6;
        private ComboBox numberbowling;
        private NumericUpDown numberplayers;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox idnumber;
        private TextBox address;
        private TextBox fullname;
        private Button sendform;
        private TextBox total;
        private DataGridView dataReservas;
        private DataGridViewTextBoxColumn nombreCol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn numPlayers;
        private DataGridViewTextBoxColumn numBowling;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn afiliado;
        private DataGridViewTextBoxColumn price;
        private TextBox totalRec;
        private Label label10;
    }
}
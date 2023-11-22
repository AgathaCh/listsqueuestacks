namespace Pila
{
    partial class Ingreso
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
            txtPwd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(159, 121);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(182, 23);
            txtPwd.TabIndex = 0;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(477, 37);
            label1.TabIndex = 1;
            label1.Text = "Unidad 2 - Fase 3 - Prácticas simuladas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 46);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 2;
            label2.Text = "Raquel Alejandra Bonilla Rincón";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 103);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 3;
            label3.Text = "Ingrese Clave:";
            // 
            // button1
            // 
            button1.Location = new Point(206, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(344, 170);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 5;
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 194);
            Controls.Add(lblError);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPwd);
            Name = "Ingreso";
            Text = "Ingreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPwd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label lblError;
    }
}
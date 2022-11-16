namespace UltimoTrabajo.Forms
{
    partial class FormCajero
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RetirarCincuenta = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.RetirarDoscientos = new System.Windows.Forms.Button();
            this.btnTrescientos = new System.Windows.Forms.Button();
            this.RetirarQuinientos = new System.Windows.Forms.Button();
            this.RetirarDoscientosCin = new System.Windows.Forms.Button();
            this.RetirarCien = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.RetirarDosMil = new System.Windows.Forms.Button();
            this.RetirarMil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.btnSaldo);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(25, 34);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(75, 44);
            this.btnSaldo.TabIndex = 0;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RetirarDosMil);
            this.groupBox2.Controls.Add(this.RetirarMil);
            this.groupBox2.Controls.Add(this.RetirarQuinientos);
            this.groupBox2.Controls.Add(this.RetirarDoscientosCin);
            this.groupBox2.Controls.Add(this.RetirarCien);
            this.groupBox2.Controls.Add(this.btnTrescientos);
            this.groupBox2.Controls.Add(this.RetirarDoscientos);
            this.groupBox2.Controls.Add(this.RetirarCincuenta);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // RetirarCincuenta
            // 
            this.RetirarCincuenta.Location = new System.Drawing.Point(6, 34);
            this.RetirarCincuenta.Name = "RetirarCincuenta";
            this.RetirarCincuenta.Size = new System.Drawing.Size(94, 50);
            this.RetirarCincuenta.TabIndex = 0;
            this.RetirarCincuenta.Text = "50";
            this.RetirarCincuenta.UseVisualStyleBackColor = true;
            this.RetirarCincuenta.Click += new System.EventHandler(this.RetirarCincuenta_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(149, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(17, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "\"\"";
            // 
            // RetirarDoscientos
            // 
            this.RetirarDoscientos.Location = new System.Drawing.Point(6, 90);
            this.RetirarDoscientos.Name = "RetirarDoscientos";
            this.RetirarDoscientos.Size = new System.Drawing.Size(94, 45);
            this.RetirarDoscientos.TabIndex = 1;
            this.RetirarDoscientos.Text = "200";
            this.RetirarDoscientos.UseVisualStyleBackColor = true;
            this.RetirarDoscientos.Click += new System.EventHandler(this.RetirarDoscientos_Click);
            // 
            // btnTrescientos
            // 
            this.btnTrescientos.Location = new System.Drawing.Point(6, 141);
            this.btnTrescientos.Name = "btnTrescientos";
            this.btnTrescientos.Size = new System.Drawing.Size(94, 49);
            this.btnTrescientos.TabIndex = 2;
            this.btnTrescientos.Text = "300";
            this.btnTrescientos.UseVisualStyleBackColor = true;
            this.btnTrescientos.Click += new System.EventHandler(this.button4_Click);
            // 
            // RetirarQuinientos
            // 
            this.RetirarQuinientos.Location = new System.Drawing.Point(137, 143);
            this.RetirarQuinientos.Name = "RetirarQuinientos";
            this.RetirarQuinientos.Size = new System.Drawing.Size(94, 49);
            this.RetirarQuinientos.TabIndex = 5;
            this.RetirarQuinientos.Text = "500";
            this.RetirarQuinientos.UseVisualStyleBackColor = true;
            this.RetirarQuinientos.Click += new System.EventHandler(this.RetirarQuinientos_Click);
            // 
            // RetirarDoscientosCin
            // 
            this.RetirarDoscientosCin.Location = new System.Drawing.Point(137, 92);
            this.RetirarDoscientosCin.Name = "RetirarDoscientosCin";
            this.RetirarDoscientosCin.Size = new System.Drawing.Size(94, 45);
            this.RetirarDoscientosCin.TabIndex = 4;
            this.RetirarDoscientosCin.Text = "250";
            this.RetirarDoscientosCin.UseVisualStyleBackColor = true;
            this.RetirarDoscientosCin.Click += new System.EventHandler(this.RetirarDoscientosCin_Click);
            // 
            // RetirarCien
            // 
            this.RetirarCien.Location = new System.Drawing.Point(137, 36);
            this.RetirarCien.Name = "RetirarCien";
            this.RetirarCien.Size = new System.Drawing.Size(94, 50);
            this.RetirarCien.TabIndex = 3;
            this.RetirarCien.Text = "100";
            this.RetirarCien.UseVisualStyleBackColor = true;
            this.RetirarCien.Click += new System.EventHandler(this.RetirarCien_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Location = new System.Drawing.Point(264, 423);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(17, 15);
            this.LblMensaje.TabIndex = 3;
            this.LblMensaje.Text = "\"\"";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(183, 49);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(17, 15);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "\"\"";
            // 
            // RetirarDosMil
            // 
            this.RetirarDosMil.Location = new System.Drawing.Point(137, 198);
            this.RetirarDosMil.Name = "RetirarDosMil";
            this.RetirarDosMil.Size = new System.Drawing.Size(94, 49);
            this.RetirarDosMil.TabIndex = 7;
            this.RetirarDosMil.Text = "2000";
            this.RetirarDosMil.UseVisualStyleBackColor = true;
            this.RetirarDosMil.Click += new System.EventHandler(this.RetirarDosMil_Click);
            // 
            // RetirarMil
            // 
            this.RetirarMil.Location = new System.Drawing.Point(6, 196);
            this.RetirarMil.Name = "RetirarMil";
            this.RetirarMil.Size = new System.Drawing.Size(94, 49);
            this.RetirarMil.TabIndex = 6;
            this.RetirarMil.Text = "1000";
            this.RetirarMil.UseVisualStyleBackColor = true;
            this.RetirarMil.Click += new System.EventHandler(this.RetirarMil_Click);
            // 
            // FormCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 447);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCajero";
            this.Text = "FormCajero";
            this.Load += new System.EventHandler(this.FormCajero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSaldo;
        private GroupBox groupBox2;
        private Button RetirarCincuenta;
        private Label lblNombre;
        private Button btnTrescientos;
        private Button RetirarDoscientos;
        private Label lblSaldo;
        private Button RetirarQuinientos;
        private Button RetirarDoscientosCin;
        private Button RetirarCien;
        private Label LblMensaje;
        private Button RetirarDosMil;
        private Button RetirarMil;
    }
}
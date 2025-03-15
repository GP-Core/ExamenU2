namespace ExamenU2
{
    partial class frmAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarUsuario));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAgregar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtAMaterno = new TextBox();
            label3 = new Label();
            txtAPaterno = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAgregar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCancelar, 0, 1);
            tableLayoutPanel1.Location = new Point(100, 515);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.0769234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.9230766F));
            tableLayoutPanel1.Size = new Size(259, 85);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnAgregar.Location = new Point(3, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(253, 34);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "AGREGAR USUARIO";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnCancelar.Location = new Point(3, 43);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(253, 39);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(100, 437);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 25;
            label5.Text = "CORREO ";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial Narrow", 10.8F);
            txtCorreo.Location = new Point(100, 468);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(259, 28);
            txtCorreo.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(100, 370);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 23;
            label6.Text = "TELEFONO";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial Narrow", 10.8F);
            txtTelefono.Location = new Point(100, 401);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(259, 28);
            txtTelefono.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(100, 301);
            label4.Name = "label4";
            label4.Size = new Size(210, 28);
            label4.TabIndex = 21;
            label4.Text = "APELLIDO MATERNO";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Arial Narrow", 10.8F);
            txtAMaterno.Location = new Point(100, 332);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(259, 28);
            txtAMaterno.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 227);
            label3.Name = "label3";
            label3.Size = new Size(202, 28);
            label3.TabIndex = 19;
            label3.Text = "APELLIDO PATERNO";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Arial Narrow", 10.8F);
            txtAPaterno.Location = new Point(100, 258);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(259, 28);
            txtAPaterno.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 159);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 17;
            label2.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial Narrow", 10.8F);
            txtNombre.Location = new Point(100, 190);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 28);
            txtNombre.TabIndex = 16;
            // 
            // frmAgregarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 237, 237);
            ClientSize = new Size(465, 601);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtAMaterno);
            Controls.Add(label3);
            Controls.Add(txtAPaterno);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Name = "frmAgregarUsuario";
            Text = "frmAgregarUsuario";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAgregar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtAMaterno;
        private Label label3;
        private TextBox txtAPaterno;
        private Label label2;
        private TextBox txtNombre;
    }
}
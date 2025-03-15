namespace ExamenU2
{
    partial class frmActualizarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarUsuario));
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtAPaterno = new TextBox();
            label4 = new Label();
            txtAMaterno = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(93, 163);
            txtID.Name = "txtID";
            txtID.Size = new Size(259, 28);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 132);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 203);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial Narrow", 10.8F);
            txtNombre.Location = new Point(93, 234);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(259, 28);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(93, 271);
            label3.Name = "label3";
            label3.Size = new Size(202, 28);
            label3.TabIndex = 5;
            label3.Text = "APELLIDO PATERNO";
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Arial Narrow", 10.8F);
            txtAPaterno.Location = new Point(93, 302);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.Size = new Size(259, 28);
            txtAPaterno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 345);
            label4.Name = "label4";
            label4.Size = new Size(210, 28);
            label4.TabIndex = 7;
            label4.Text = "APELLIDO MATERNO";
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Arial Narrow", 10.8F);
            txtAMaterno.Location = new Point(93, 376);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.Size = new Size(259, 28);
            txtAMaterno.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(93, 481);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 11;
            label5.Text = "CORREO ";
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Arial Narrow", 10.8F);
            txtCorreo.Location = new Point(93, 512);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(259, 28);
            txtCorreo.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(93, 414);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 9;
            label6.Text = "TELEFONO";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial Narrow", 10.8F);
            txtTelefono.Location = new Point(93, 445);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(259, 28);
            txtTelefono.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(160, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnActualizar, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEliminar, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCancelar, 0, 2);
            tableLayoutPanel1.Location = new Point(93, 576);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.0769234F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.9230766F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Size = new Size(259, 125);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnActualizar.Location = new Point(3, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(253, 34);
            btnActualizar.TabIndex = 0;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnEliminar.Location = new Point(3, 43);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(253, 37);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold);
            btnCancelar.Location = new Point(3, 86);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(253, 36);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 237, 237);
            ClientSize = new Size(453, 713);
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
            Controls.Add(label1);
            Controls.Add(txtID);
            Name = "frmActualizarUsuario";
            Text = "Actualizar Información";
            Load += frmActualizarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtAPaterno;
        private Label label4;
        private TextBox txtAMaterno;
        private Label label5;
        private TextBox txtCorreo;
        private Label label6;
        private TextBox txtTelefono;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}
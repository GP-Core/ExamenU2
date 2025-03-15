namespace ExamenU2
{
    partial class frmUsuarios
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvUsuarios = new DataGridView();
            label1 = new Label();
            btnAgregarUsuario = new Button();
            btnMenu = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvUsuarios, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAgregarUsuario, 0, 2);
            tableLayoutPanel1.Controls.Add(btnMenu, 0, 3);
            tableLayoutPanel1.Location = new Point(1, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9437943F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.0562057F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Size = new Size(860, 487);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvUsuarios.BackgroundColor = SystemColors.WindowFrame;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.GridColor = Color.FromArgb(128, 64, 64);
            dgvUsuarios.Location = new Point(3, 52);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(854, 358);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(854, 49);
            label1.TabIndex = 1;
            label1.Text = "USUARIOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregarUsuario.Cursor = Cursors.Hand;
            btnAgregarUsuario.Location = new Point(3, 416);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(854, 33);
            btnAgregarUsuario.TabIndex = 2;
            btnAgregarUsuario.Text = "INGRESAR NUEVO USUARIO";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // btnMenu
            // 
            btnMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Location = new Point(3, 455);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(854, 29);
            btnMenu.TabIndex = 3;
            btnMenu.Text = "REGRESAR AL MENU";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 237, 237);
            ClientSize = new Size(863, 492);
            Controls.Add(tableLayoutPanel1);
            Name = "frmUsuarios";
            Text = "USUARIOS";
            Activated += frmUsuarios_Activated;
            Load += frmUsuarios_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvUsuarios;
        private Label label1;
        private Button btnAgregarUsuario;
        private Button btnMenu;
    }
}
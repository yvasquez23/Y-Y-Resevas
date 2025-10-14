namespace Y_YReservas.Forms
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            FramePersonales = new GroupBox();
            FrameBusqueda = new GroupBox();
            dtgClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtBusqueda = new TextBox();
            cmbbuqueda = new Button();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtNommbre = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CmdBoton3 = new Button();
            CmdBoton2 = new Button();
            CmdBoton1 = new Button();
            CmdBoton0 = new Button();
            FramePersonales.SuspendLayout();
            FrameBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).BeginInit();
            SuspendLayout();
            // 
            // FramePersonales
            // 
            FramePersonales.Controls.Add(FrameBusqueda);
            FramePersonales.Controls.Add(cmbbuqueda);
            FramePersonales.Controls.Add(txtDireccion);
            FramePersonales.Controls.Add(txtTelefono);
            FramePersonales.Controls.Add(txtNommbre);
            FramePersonales.Controls.Add(txtCodigo);
            FramePersonales.Controls.Add(label4);
            FramePersonales.Controls.Add(label3);
            FramePersonales.Controls.Add(label2);
            FramePersonales.Controls.Add(label1);
            FramePersonales.Location = new Point(2, 2);
            FramePersonales.Name = "FramePersonales";
            FramePersonales.Size = new Size(410, 181);
            FramePersonales.TabIndex = 0;
            FramePersonales.TabStop = false;
            // 
            // FrameBusqueda
            // 
            FrameBusqueda.Controls.Add(dtgClientes);
            FrameBusqueda.Controls.Add(txtBusqueda);
            FrameBusqueda.Location = new Point(2, 16);
            FrameBusqueda.Name = "FrameBusqueda";
            FrameBusqueda.Size = new Size(402, 93);
            FrameBusqueda.TabIndex = 9;
            FrameBusqueda.TabStop = false;
            FrameBusqueda.Text = "Busqueda";
            FrameBusqueda.Visible = false;
            // 
            // dtgClientes
            // 
            dtgClientes.AllowUserToAddRows = false;
            dtgClientes.AllowUserToDeleteRows = false;
            dtgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dtgClientes.Location = new Point(4, 51);
            dtgClientes.Name = "dtgClientes";
            dtgClientes.ReadOnly = true;
            dtgClientes.Size = new Size(392, 102);
            dtgClientes.TabIndex = 1;
            dtgClientes.CellClick += dtgClientes_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Cliente_ID";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Cliente_Codigo";
            Column2.HeaderText = "Codigo";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "Cliente_Nombre";
            Column3.HeaderText = "Nombre";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Cliente_Telefono";
            Column4.HeaderText = "Telefono";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Cliente_Direccion";
            Column5.HeaderText = "Direccion";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(6, 22);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(390, 23);
            txtBusqueda.TabIndex = 0;
            txtBusqueda.KeyPress += txtbusqueda_KeyPress;
            // 
            // cmbbuqueda
            // 
            cmbbuqueda.Image = (Image)resources.GetObject("cmbbuqueda.Image");
            cmbbuqueda.Location = new Point(359, 16);
            cmbbuqueda.Name = "cmbbuqueda";
            cmbbuqueda.Size = new Size(45, 33);
            cmbbuqueda.TabIndex = 8;
            cmbbuqueda.UseVisualStyleBackColor = true;
            cmbbuqueda.Click += cmbbuqueda_Click;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(75, 128);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(186, 23);
            txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(75, 86);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(186, 23);
            txtTelefono.TabIndex = 6;
            // 
            // txtNommbre
            // 
            txtNommbre.Location = new Point(75, 54);
            txtNommbre.Name = "txtNommbre";
            txtNommbre.Size = new Size(186, 23);
            txtNommbre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(75, 16);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(186, 23);
            txtCodigo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 131);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 94);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // CmdBoton3
            // 
            CmdBoton3.Enabled = false;
            CmdBoton3.Image = (Image)resources.GetObject("CmdBoton3.Image");
            CmdBoton3.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton3.Location = new Point(325, 189);
            CmdBoton3.Name = "CmdBoton3";
            CmdBoton3.Size = new Size(87, 47);
            CmdBoton3.TabIndex = 9;
            CmdBoton3.Text = "&Borrar";
            CmdBoton3.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton3.UseVisualStyleBackColor = true;
            CmdBoton3.Click += CmdBoton0_Click;
            // 
            // CmdBoton2
            // 
            CmdBoton2.Enabled = false;
            CmdBoton2.Image = (Image)resources.GetObject("CmdBoton2.Image");
            CmdBoton2.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton2.Location = new Point(208, 189);
            CmdBoton2.Name = "CmdBoton2";
            CmdBoton2.Size = new Size(111, 47);
            CmdBoton2.TabIndex = 8;
            CmdBoton2.Text = "&Editar";
            CmdBoton2.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton2.UseVisualStyleBackColor = true;
            CmdBoton2.Click += CmdBoton0_Click;
            // 
            // CmdBoton1
            // 
            CmdBoton1.Image = (Image)resources.GetObject("CmdBoton1.Image");
            CmdBoton1.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton1.Location = new Point(102, 189);
            CmdBoton1.Name = "CmdBoton1";
            CmdBoton1.Size = new Size(100, 47);
            CmdBoton1.TabIndex = 7;
            CmdBoton1.Text = "&Agregar";
            CmdBoton1.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton1.UseVisualStyleBackColor = true;
            CmdBoton1.Click += CmdBoton0_Click;
            // 
            // CmdBoton0
            // 
            CmdBoton0.Image = (Image)resources.GetObject("CmdBoton0.Image");
            CmdBoton0.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton0.Location = new Point(4, 189);
            CmdBoton0.Name = "CmdBoton0";
            CmdBoton0.Size = new Size(92, 47);
            CmdBoton0.TabIndex = 6;
            CmdBoton0.Text = "&Salir";
            CmdBoton0.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton0.UseVisualStyleBackColor = true;
            CmdBoton0.Click += CmdBoton0_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(418, 251);
            Controls.Add(CmdBoton3);
            Controls.Add(CmdBoton2);
            Controls.Add(CmdBoton1);
            Controls.Add(CmdBoton0);
            Controls.Add(FramePersonales);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            FramePersonales.ResumeLayout(false);
            FramePersonales.PerformLayout();
            FrameBusqueda.ResumeLayout(false);
            FrameBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FramePersonales;
        private Label label1;
        private Button CmdBoton3;
        private Button CmdBoton2;
        private Button CmdBoton1;
        private Button CmdBoton0;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtNommbre;
        private TextBox txtCodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox FrameBusqueda;
        private DataGridView dtgClientes;
        private TextBox txtBusqueda;
        private Button cmbbuqueda;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
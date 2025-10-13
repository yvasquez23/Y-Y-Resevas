namespace Y_YReservas.Forms
{
    partial class FrmTipoServicio
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoServicio));
            groupBox1 = new GroupBox();
            txtID = new TextBox();
            framePersonales = new GroupBox();
            frameBusqueda = new GroupBox();
            dgvTipoServicio = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            txtbusqueda = new TextBox();
            cmbbuqueda = new Button();
            txtTipoServicio = new TextBox();
            label1 = new Label();
            CmdBoton0 = new Button();
            CmdBoton1 = new Button();
            CmdBoton2 = new Button();
            CmdBoton3 = new Button();
            groupBox1.SuspendLayout();
            framePersonales.SuspendLayout();
            frameBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoServicio).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtID);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 40);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(8, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            // 
            // framePersonales
            // 
            framePersonales.Controls.Add(frameBusqueda);
            framePersonales.Controls.Add(cmbbuqueda);
            framePersonales.Controls.Add(txtTipoServicio);
            framePersonales.Controls.Add(label1);
            framePersonales.Location = new Point(5, 12);
            framePersonales.Name = "framePersonales";
            framePersonales.Size = new Size(408, 240);
            framePersonales.TabIndex = 1;
            framePersonales.TabStop = false;
            // 
            // frameBusqueda
            // 
            frameBusqueda.Controls.Add(dgvTipoServicio);
            frameBusqueda.Controls.Add(txtbusqueda);
            frameBusqueda.ForeColor = SystemColors.ControlText;
            frameBusqueda.Location = new Point(6, 16);
            frameBusqueda.Name = "frameBusqueda";
            frameBusqueda.Size = new Size(345, 103);
            frameBusqueda.TabIndex = 3;
            frameBusqueda.TabStop = false;
            frameBusqueda.Text = "Busqueda";
            frameBusqueda.Visible = false;
            // 
            // dgvTipoServicio
            // 
            dgvTipoServicio.AllowUserToAddRows = false;
            dgvTipoServicio.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dgvTipoServicio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTipoServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoServicio.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvTipoServicio.Location = new Point(6, 62);
            dgvTipoServicio.Name = "dgvTipoServicio";
            dgvTipoServicio.ReadOnly = true;
            dgvTipoServicio.Size = new Size(339, 156);
            dgvTipoServicio.TabIndex = 1;
            dgvTipoServicio.CellClick += dgvTipoServicio_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TipoServicio_ID";
            Column1.HeaderText = "iD";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "Tipo_Servicio";
            Column2.HeaderText = "TipoServicio";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(6, 30);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(339, 23);
            txtbusqueda.TabIndex = 0;
            txtbusqueda.KeyPress += txtbusqueda_KeyPress;
            // 
            // cmbbuqueda
            // 
            cmbbuqueda.Image = (Image)resources.GetObject("cmbbuqueda.Image");
            cmbbuqueda.Location = new Point(357, 33);
            cmbbuqueda.Name = "cmbbuqueda";
            cmbbuqueda.Size = new Size(45, 36);
            cmbbuqueda.TabIndex = 2;
            cmbbuqueda.UseVisualStyleBackColor = true;
            cmbbuqueda.Click += cmbbuqueda_Click;
            // 
            // txtTipoServicio
            // 
            txtTipoServicio.Location = new Point(7, 46);
            txtTipoServicio.Name = "txtTipoServicio";
            txtTipoServicio.Size = new Size(341, 23);
            txtTipoServicio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 0;
            label1.Text = "Tipo Servicio";
            // 
            // CmdBoton0
            // 
            CmdBoton0.Image = (Image)resources.GetObject("CmdBoton0.Image");
            CmdBoton0.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton0.Location = new Point(5, 269);
            CmdBoton0.Name = "CmdBoton0";
            CmdBoton0.Size = new Size(92, 47);
            CmdBoton0.TabIndex = 2;
            CmdBoton0.Text = "&Salir";
            CmdBoton0.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton0.UseVisualStyleBackColor = true;
            CmdBoton0.Click += CmdBoton0_Click;
            // 
            // CmdBoton1
            // 
            CmdBoton1.Image = (Image)resources.GetObject("CmdBoton1.Image");
            CmdBoton1.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton1.Location = new Point(103, 269);
            CmdBoton1.Name = "CmdBoton1";
            CmdBoton1.Size = new Size(100, 47);
            CmdBoton1.TabIndex = 3;
            CmdBoton1.Text = "&Agregar";
            CmdBoton1.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton1.UseVisualStyleBackColor = true;
            CmdBoton1.Click += CmdBoton0_Click;
            // 
            // CmdBoton2
            // 
            CmdBoton2.Enabled = false;
            CmdBoton2.Image = (Image)resources.GetObject("CmdBoton2.Image");
            CmdBoton2.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton2.Location = new Point(209, 269);
            CmdBoton2.Name = "CmdBoton2";
            CmdBoton2.Size = new Size(111, 47);
            CmdBoton2.TabIndex = 4;
            CmdBoton2.Text = "&Editar";
            CmdBoton2.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton2.UseVisualStyleBackColor = true;
            CmdBoton2.Click += CmdBoton0_Click;
            // 
            // CmdBoton3
            // 
            CmdBoton3.Enabled = false;
            CmdBoton3.Image = (Image)resources.GetObject("CmdBoton3.Image");
            CmdBoton3.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton3.Location = new Point(326, 269);
            CmdBoton3.Name = "CmdBoton3";
            CmdBoton3.Size = new Size(87, 47);
            CmdBoton3.TabIndex = 5;
            CmdBoton3.Text = "&Borrar";
            CmdBoton3.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton3.UseVisualStyleBackColor = true;
            CmdBoton3.Click += CmdBoton0_Click;
            // 
            // FrmTipoServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(420, 325);
            Controls.Add(CmdBoton3);
            Controls.Add(CmdBoton2);
            Controls.Add(CmdBoton1);
            Controls.Add(CmdBoton0);
            Controls.Add(framePersonales);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTipoServicio";
            Text = "FrmTipoServicio";
            Load += FrmTipoServicio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            framePersonales.ResumeLayout(false);
            framePersonales.PerformLayout();
            frameBusqueda.ResumeLayout(false);
            frameBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoServicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox framePersonales;
        private TextBox txtID;
        private Label label1;
        private TextBox txtTipoServicio;
        private GroupBox frameBusqueda;
        private TextBox txtbusqueda;
        private Button cmbbuqueda;
        private DataGridView dgvTipoServicio;
        private Button CmdBoton0;
        private Button CmdBoton1;
        private Button CmdBoton2;
        private Button CmdBoton3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
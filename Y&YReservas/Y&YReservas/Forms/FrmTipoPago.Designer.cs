namespace Y_YReservas.Forms
{
    partial class FrmTipoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoPago));
            framePersonales = new GroupBox();
            franeBusqueda = new GroupBox();
            label2 = new Label();
            dgvBusqueda = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            cmbbuqueda = new Button();
            txtDesc = new TextBox();
            label1 = new Label();
            CmdBoton3 = new Button();
            CmdBoton2 = new Button();
            CmdBoton1 = new Button();
            CmdBoton0 = new Button();
            framePersonales.SuspendLayout();
            franeBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).BeginInit();
            SuspendLayout();
            // 
            // framePersonales
            // 
            framePersonales.Controls.Add(franeBusqueda);
            framePersonales.Controls.Add(cmbbuqueda);
            framePersonales.Controls.Add(txtDesc);
            framePersonales.Controls.Add(label1);
            framePersonales.Location = new Point(5, 12);
            framePersonales.Name = "framePersonales";
            framePersonales.Size = new Size(465, 318);
            framePersonales.TabIndex = 0;
            framePersonales.TabStop = false;
            // 
            // franeBusqueda
            // 
            franeBusqueda.Controls.Add(label2);
            franeBusqueda.Controls.Add(dgvBusqueda);
            franeBusqueda.Controls.Add(txtBuscar);
            franeBusqueda.Location = new Point(6, 13);
            franeBusqueda.Name = "franeBusqueda";
            franeBusqueda.Size = new Size(405, 117);
            franeBusqueda.TabIndex = 4;
            franeBusqueda.TabStop = false;
            franeBusqueda.Text = "Busqueda";
            franeBusqueda.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(8, 19);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 2;
            label2.Text = "Tipo pago";
            // 
            // dgvBusqueda
            // 
            dgvBusqueda.AllowUserToAddRows = false;
            dgvBusqueda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dgvBusqueda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBusqueda.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvBusqueda.Location = new Point(6, 75);
            dgvBusqueda.Name = "dgvBusqueda";
            dgvBusqueda.ReadOnly = true;
            dgvBusqueda.Size = new Size(393, 202);
            dgvBusqueda.TabIndex = 1;
            dgvBusqueda.CellClick += dgvBusqueda_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "TipoPago_iD";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "TipoPago_Desc";
            Column2.HeaderText = "Tipo Pago";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(8, 46);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(391, 23);
            txtBuscar.TabIndex = 0;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // cmbbuqueda
            // 
            cmbbuqueda.Image = (Image)resources.GetObject("cmbbuqueda.Image");
            cmbbuqueda.Location = new Point(417, 51);
            cmbbuqueda.Name = "cmbbuqueda";
            cmbbuqueda.Size = new Size(45, 36);
            cmbbuqueda.TabIndex = 3;
            cmbbuqueda.UseVisualStyleBackColor = true;
            cmbbuqueda.Click += cmbbuqueda_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(10, 59);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(401, 23);
            txtDesc.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 0;
            label1.Text = "Tipo Pago";
            // 
            // CmdBoton3
            // 
            CmdBoton3.Enabled = false;
            CmdBoton3.Image = (Image)resources.GetObject("CmdBoton3.Image");
            CmdBoton3.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton3.Location = new Point(326, 336);
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
            CmdBoton2.Location = new Point(209, 336);
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
            CmdBoton1.Location = new Point(103, 336);
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
            CmdBoton0.Location = new Point(5, 336);
            CmdBoton0.Name = "CmdBoton0";
            CmdBoton0.Size = new Size(92, 47);
            CmdBoton0.TabIndex = 6;
            CmdBoton0.Text = "&Salir";
            CmdBoton0.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton0.UseVisualStyleBackColor = true;
            CmdBoton0.Click += CmdBoton0_Click;
            // 
            // FrmTipoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(479, 393);
            Controls.Add(CmdBoton3);
            Controls.Add(CmdBoton2);
            Controls.Add(CmdBoton1);
            Controls.Add(CmdBoton0);
            Controls.Add(framePersonales);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTipoPago";
            Text = "FrmTipoPago";
            Load += FrmTipoPago_Load;
            framePersonales.ResumeLayout(false);
            framePersonales.PerformLayout();
            franeBusqueda.ResumeLayout(false);
            franeBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox framePersonales;
        private Label label1;
        private TextBox txtDesc;
        private Button cmbbuqueda;
        private GroupBox franeBusqueda;
        private DataGridView dgvBusqueda;
        private TextBox txtBuscar;
        private Button CmdBoton3;
        private Button CmdBoton2;
        private Button CmdBoton1;
        private Button CmdBoton0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Label label2;
    }
}
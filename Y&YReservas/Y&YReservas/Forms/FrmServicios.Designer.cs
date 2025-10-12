namespace Y_YReservas.Forms
{
    partial class FrmServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            CmdBoton3 = new Button();
            CmdBoton2 = new Button();
            CmdBoton1 = new Button();
            CmdBoton0 = new Button();
            FramePersonal = new GroupBox();
            cmbbuqueda = new Button();
            frameBusqueda = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            cmbTipoServicio = new ComboBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FramePersonal.SuspendLayout();
            frameBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CmdBoton3
            // 
            CmdBoton3.Enabled = false;
            CmdBoton3.Image = (Image)resources.GetObject("CmdBoton3.Image");
            CmdBoton3.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton3.Location = new Point(327, 181);
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
            CmdBoton2.Location = new Point(210, 181);
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
            CmdBoton1.Location = new Point(104, 181);
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
            CmdBoton0.Location = new Point(6, 181);
            CmdBoton0.Name = "CmdBoton0";
            CmdBoton0.Size = new Size(92, 47);
            CmdBoton0.TabIndex = 6;
            CmdBoton0.Text = "&Salir";
            CmdBoton0.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton0.UseVisualStyleBackColor = true;
            CmdBoton0.Click += CmdBoton0_Click;
            // 
            // FramePersonal
            // 
            FramePersonal.Controls.Add(cmbbuqueda);
            FramePersonal.Controls.Add(frameBusqueda);
            FramePersonal.Controls.Add(cmbTipoServicio);
            FramePersonal.Controls.Add(txtPrecio);
            FramePersonal.Controls.Add(txtNombre);
            FramePersonal.Controls.Add(label3);
            FramePersonal.Controls.Add(label2);
            FramePersonal.Controls.Add(label1);
            FramePersonal.Location = new Point(6, 7);
            FramePersonal.Name = "FramePersonal";
            FramePersonal.Size = new Size(408, 158);
            FramePersonal.TabIndex = 10;
            FramePersonal.TabStop = false;
            // 
            // cmbbuqueda
            // 
            cmbbuqueda.Image = (Image)resources.GetObject("cmbbuqueda.Image");
            cmbbuqueda.Location = new Point(364, 19);
            cmbbuqueda.Name = "cmbbuqueda";
            cmbbuqueda.Size = new Size(39, 25);
            cmbbuqueda.TabIndex = 9;
            cmbbuqueda.UseVisualStyleBackColor = true;
            cmbbuqueda.Click += cmbbuqueda_Click;
            // 
            // frameBusqueda
            // 
            frameBusqueda.Controls.Add(dataGridView1);
            frameBusqueda.Controls.Add(textBox1);
            frameBusqueda.Location = new Point(6, 19);
            frameBusqueda.Name = "frameBusqueda";
            frameBusqueda.Size = new Size(393, 62);
            frameBusqueda.TabIndex = 8;
            frameBusqueda.TabStop = false;
            frameBusqueda.Text = "busqueda";
            frameBusqueda.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(0, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(390, 80);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Servicio_ID";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.DataPropertyName = "Servicio_Nombre";
            Column2.HeaderText = "Nombre Servicio";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TipoServicio_ID";
            Column3.HeaderText = "Tipo Sercicio";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.DataPropertyName = "Precio_Servicios";
            Column4.HeaderText = "Precio";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 23);
            textBox1.TabIndex = 0;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // cmbTipoServicio
            // 
            cmbTipoServicio.FormattingEnabled = true;
            cmbTipoServicio.Location = new Point(107, 63);
            cmbTipoServicio.Name = "cmbTipoServicio";
            cmbTipoServicio.Size = new Size(251, 23);
            cmbTipoServicio.TabIndex = 7;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(107, 104);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(251, 23);
            txtPrecio.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 104);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo Servicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Servicio";
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(417, 235);
            Controls.Add(FramePersonal);
            Controls.Add(CmdBoton3);
            Controls.Add(CmdBoton2);
            Controls.Add(CmdBoton1);
            Controls.Add(CmdBoton0);
            Name = "FrmServicios";
            Text = "FrmServicios";
            Load += FrmServicios_Load;
            FramePersonal.ResumeLayout(false);
            FramePersonal.PerformLayout();
            frameBusqueda.ResumeLayout(false);
            frameBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CmdBoton3;
        private Button CmdBoton2;
        private Button CmdBoton1;
        private Button CmdBoton0;
        private GroupBox FramePersonal;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbTipoServicio;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private GroupBox frameBusqueda;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button cmbbuqueda;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
namespace Y_YReservas.Forms
{
    partial class FrmReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservas));
            FramePersonales = new GroupBox();
            cmbVendedor = new ComboBox();
            cmbClientes = new ComboBox();
            button2 = new Button();
            txtCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FrameDetalle = new GroupBox();
            ltsDetalle = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            cmbbuqueda = new Button();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            txtTipoServicio = new TextBox();
            txtPrecio = new TextBox();
            label5 = new Label();
            TxtServicio = new TextBox();
            label4 = new Label();
            CmdBoton3 = new Button();
            CmdBoton2 = new Button();
            CmdBoton0 = new Button();
            CmdBoton1 = new Button();
            FrameTipoPago = new GroupBox();
            txtTotal = new TextBox();
            label12 = new Label();
            txtCambio = new TextBox();
            label11 = new Label();
            lstPagos = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            txtCantidadResivida = new TextBox();
            label10 = new Label();
            txtMontoPagado = new TextBox();
            label9 = new Label();
            cmbTipoPago = new ComboBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            FrameBusqueda = new GroupBox();
            ltsServicios = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            FramePersonales.SuspendLayout();
            FrameDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ltsDetalle).BeginInit();
            FrameTipoPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstPagos).BeginInit();
            groupBox1.SuspendLayout();
            FrameBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ltsServicios).BeginInit();
            SuspendLayout();
            // 
            // FramePersonales
            // 
            FramePersonales.Controls.Add(cmbVendedor);
            FramePersonales.Controls.Add(cmbClientes);
            FramePersonales.Controls.Add(button2);
            FramePersonales.Controls.Add(txtCodigo);
            FramePersonales.Controls.Add(label3);
            FramePersonales.Controls.Add(label2);
            FramePersonales.Controls.Add(label1);
            FramePersonales.Location = new Point(5, 2);
            FramePersonales.Name = "FramePersonales";
            FramePersonales.Size = new Size(793, 126);
            FramePersonales.TabIndex = 0;
            FramePersonales.TabStop = false;
            // 
            // cmbVendedor
            // 
            cmbVendedor.FormattingEnabled = true;
            cmbVendedor.Location = new Point(79, 89);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(261, 23);
            cmbVendedor.TabIndex = 8;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(79, 51);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(261, 23);
            cmbClientes.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(244, 16);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 6;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(79, 16);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(159, 23);
            txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 92);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Vendedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 54);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Reserva No";
            // 
            // FrameDetalle
            // 
            FrameDetalle.Controls.Add(ltsDetalle);
            FrameDetalle.Controls.Add(cmbbuqueda);
            FrameDetalle.Controls.Add(label7);
            FrameDetalle.Controls.Add(dateTimePicker1);
            FrameDetalle.Controls.Add(label6);
            FrameDetalle.Controls.Add(txtTipoServicio);
            FrameDetalle.Controls.Add(txtPrecio);
            FrameDetalle.Controls.Add(label5);
            FrameDetalle.Controls.Add(TxtServicio);
            FrameDetalle.Controls.Add(label4);
            FrameDetalle.Location = new Point(11, 134);
            FrameDetalle.Name = "FrameDetalle";
            FrameDetalle.Size = new Size(792, 358);
            FrameDetalle.TabIndex = 1;
            FrameDetalle.TabStop = false;
            // 
            // ltsDetalle
            // 
            ltsDetalle.AllowUserToAddRows = false;
            ltsDetalle.AllowUserToDeleteRows = false;
            ltsDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ltsDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ltsDetalle.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            ltsDetalle.Location = new Point(6, 77);
            ltsDetalle.Name = "ltsDetalle";
            ltsDetalle.ReadOnly = true;
            ltsDetalle.Size = new Size(770, 272);
            ltsDetalle.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Servicio";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Tipo Servicio";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Precio";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Fecha";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // cmbbuqueda
            // 
            cmbbuqueda.Image = (Image)resources.GetObject("cmbbuqueda.Image");
            cmbbuqueda.Location = new Point(236, 48);
            cmbbuqueda.Name = "cmbbuqueda";
            cmbbuqueda.Size = new Size(50, 23);
            cmbbuqueda.TabIndex = 8;
            cmbbuqueda.UseVisualStyleBackColor = true;
            cmbbuqueda.Click += cmbbuqueda_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(576, 19);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 7;
            label7.Text = "Fecha Reserva";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(576, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(2025, 10, 12, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 19);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 5;
            label6.Text = "Tipo Servicio";
            // 
            // txtTipoServicio
            // 
            txtTipoServicio.Location = new Point(292, 48);
            txtTipoServicio.Name = "txtTipoServicio";
            txtTipoServicio.Size = new Size(136, 23);
            txtTipoServicio.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(434, 48);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(136, 23);
            txtPrecio.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 19);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 2;
            label5.Text = "Precio";
            // 
            // TxtServicio
            // 
            TxtServicio.Location = new Point(6, 48);
            TxtServicio.Name = "TxtServicio";
            TxtServicio.Size = new Size(230, 23);
            TxtServicio.TabIndex = 1;
            TxtServicio.Text = "s";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 19);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 0;
            label4.Text = "Servicio";
            // 
            // CmdBoton3
            // 
            CmdBoton3.Enabled = false;
            CmdBoton3.Image = (Image)resources.GetObject("CmdBoton3.Image");
            CmdBoton3.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton3.Location = new Point(20, 247);
            CmdBoton3.Name = "CmdBoton3";
            CmdBoton3.Size = new Size(105, 47);
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
            CmdBoton2.Location = new Point(20, 170);
            CmdBoton2.Name = "CmdBoton2";
            CmdBoton2.Size = new Size(105, 47);
            CmdBoton2.TabIndex = 8;
            CmdBoton2.Text = "&Imprimir";
            CmdBoton2.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton2.UseVisualStyleBackColor = true;
            CmdBoton2.Click += CmdBoton0_Click;
            // 
            // CmdBoton0
            // 
            CmdBoton0.Image = (Image)resources.GetObject("CmdBoton0.Image");
            CmdBoton0.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton0.Location = new Point(20, 99);
            CmdBoton0.Name = "CmdBoton0";
            CmdBoton0.Size = new Size(105, 47);
            CmdBoton0.TabIndex = 6;
            CmdBoton0.Text = "&Salir";
            CmdBoton0.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton0.UseVisualStyleBackColor = true;
            CmdBoton0.Click += CmdBoton0_Click;
            // 
            // CmdBoton1
            // 
            CmdBoton1.Image = (Image)resources.GetObject("CmdBoton1.Image");
            CmdBoton1.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton1.Location = new Point(20, 31);
            CmdBoton1.Name = "CmdBoton1";
            CmdBoton1.Size = new Size(105, 47);
            CmdBoton1.TabIndex = 10;
            CmdBoton1.Text = "&Agregar";
            CmdBoton1.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton1.UseVisualStyleBackColor = true;
            CmdBoton1.Click += CmdBoton0_Click;
            // 
            // FrameTipoPago
            // 
            FrameTipoPago.Controls.Add(txtTotal);
            FrameTipoPago.Controls.Add(label12);
            FrameTipoPago.Controls.Add(txtCambio);
            FrameTipoPago.Controls.Add(label11);
            FrameTipoPago.Controls.Add(lstPagos);
            FrameTipoPago.Controls.Add(button1);
            FrameTipoPago.Controls.Add(txtCantidadResivida);
            FrameTipoPago.Controls.Add(label10);
            FrameTipoPago.Controls.Add(txtMontoPagado);
            FrameTipoPago.Controls.Add(label9);
            FrameTipoPago.Controls.Add(cmbTipoPago);
            FrameTipoPago.Controls.Add(label8);
            FrameTipoPago.Location = new Point(5, 492);
            FrameTipoPago.Name = "FrameTipoPago";
            FrameTipoPago.Size = new Size(798, 283);
            FrameTipoPago.TabIndex = 11;
            FrameTipoPago.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(630, 189);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(162, 23);
            txtTotal.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(576, 189);
            label12.Name = "label12";
            label12.Size = new Size(33, 15);
            label12.TabIndex = 10;
            label12.Text = "Total";
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(631, 238);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(162, 23);
            txtCambio.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(576, 241);
            label11.Name = "label11";
            label11.Size = new Size(49, 15);
            label11.TabIndex = 8;
            label11.Text = "Cambio";
            // 
            // lstPagos
            // 
            lstPagos.AllowUserToAddRows = false;
            lstPagos.AllowUserToDeleteRows = false;
            lstPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lstPagos.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10 });
            lstPagos.Location = new Point(0, 66);
            lstPagos.Name = "lstPagos";
            lstPagos.ReadOnly = true;
            lstPagos.Size = new Size(456, 202);
            lstPagos.TabIndex = 7;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column9.HeaderText = "Tipo Pago";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column10.HeaderText = "Monto Pagado";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(376, 37);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 6;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCantidadResivida
            // 
            txtCantidadResivida.Location = new Point(270, 37);
            txtCantidadResivida.Name = "txtCantidadResivida";
            txtCantidadResivida.Size = new Size(100, 23);
            txtCantidadResivida.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(270, 19);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 4;
            label10.Text = "Cantidad Resivida";
            // 
            // txtMontoPagado
            // 
            txtMontoPagado.Location = new Point(164, 37);
            txtMontoPagado.Name = "txtMontoPagado";
            txtMontoPagado.Size = new Size(100, 23);
            txtMontoPagado.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(164, 19);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 2;
            label9.Text = "Monto Pagado";
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Location = new Point(6, 37);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(152, 23);
            cmbTipoPago.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 19);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 0;
            label8.Text = "Tipo Pago";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CmdBoton1);
            groupBox1.Controls.Add(CmdBoton0);
            groupBox1.Controls.Add(CmdBoton3);
            groupBox1.Controls.Add(CmdBoton2);
            groupBox1.Location = new Point(809, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(131, 763);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // FrameBusqueda
            // 
            FrameBusqueda.Controls.Add(ltsServicios);
            FrameBusqueda.Location = new Point(11, 134);
            FrameBusqueda.Name = "FrameBusqueda";
            FrameBusqueda.Size = new Size(792, 352);
            FrameBusqueda.TabIndex = 13;
            FrameBusqueda.TabStop = false;
            FrameBusqueda.Visible = false;
            // 
            // ltsServicios
            // 
            ltsServicios.AllowUserToAddRows = false;
            ltsServicios.AllowUserToDeleteRows = false;
            ltsServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ltsServicios.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8 });
            ltsServicios.Location = new Point(6, 19);
            ltsServicios.Name = "ltsServicios";
            ltsServicios.ReadOnly = true;
            ltsServicios.Size = new Size(774, 327);
            ltsServicios.TabIndex = 0;
            ltsServicios.CellClick += ltsServicios_CellClick;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Servicio_ID";
            Column5.HeaderText = "ID";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.DataPropertyName = "Servicio_Nombre";
            Column6.HeaderText = "Nombre";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.DataPropertyName = "Tipo_Servicio";
            Column7.HeaderText = "Tipo Servicio";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.DataPropertyName = "Precio_Servicios";
            Column8.HeaderText = "Precio";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(952, 787);
            Controls.Add(groupBox1);
            Controls.Add(FrameTipoPago);
            Controls.Add(FrameDetalle);
            Controls.Add(FramePersonales);
            Controls.Add(FrameBusqueda);
            Name = "FrmReservas";
            Text = "FrmReservas";
            Load += FrmReservas_Load;
            FramePersonales.ResumeLayout(false);
            FramePersonales.PerformLayout();
            FrameDetalle.ResumeLayout(false);
            FrameDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ltsDetalle).EndInit();
            FrameTipoPago.ResumeLayout(false);
            FrameTipoPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lstPagos).EndInit();
            groupBox1.ResumeLayout(false);
            FrameBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ltsServicios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FramePersonales;
        private Label label1;
        private TextBox txtCodigo;
        private Label label3;
        private Label label2;
        private GroupBox FrameDetalle;
        private Label label5;
        private TextBox TxtServicio;
        private Label label4;
        private TextBox txtPrecio;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txtTipoServicio;
        private Button cmbbuqueda;
        private Button CmdBoton3;
        private Button CmdBoton2;
        private Button CmdBoton0;
        private DataGridView ltsDetalle;
        private Button CmdBoton1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox FrameTipoPago;
        private Label label9;
        private ComboBox cmbTipoPago;
        private Label label8;
        private TextBox txtMontoPagado;
        private GroupBox groupBox1;
        private DataGridView lstPagos;
        private Button button1;
        private TextBox txtCantidadResivida;
        private Label label10;
        private TextBox txtTotal;
        private Label label12;
        private TextBox txtCambio;
        private Label label11;
        private Button button2;
        private ComboBox cmbVendedor;
        private ComboBox cmbClientes;
        private GroupBox FrameBusqueda;
        private DataGridView ltsServicios;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}
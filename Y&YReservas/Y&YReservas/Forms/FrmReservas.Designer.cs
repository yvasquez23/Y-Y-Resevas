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
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FrameDetalle = new GroupBox();
            dataGridView1 = new DataGridView();
            cmbbuqueda = new Button();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            CmdBoton3 = new Button();
            CmdBoton2 = new Button();
            CmdBoton0 = new Button();
            CmdBoton1 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            FremeTipoPago = new GroupBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            textBox6 = new TextBox();
            groupBox1 = new GroupBox();
            label10 = new Label();
            textBox7 = new TextBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            label11 = new Label();
            textBox8 = new TextBox();
            label12 = new Label();
            textBox9 = new TextBox();
            FramePersonales.SuspendLayout();
            FrameDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            FremeTipoPago.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // FramePersonales
            // 
            FramePersonales.Controls.Add(comboBox1);
            FramePersonales.Controls.Add(textBox2);
            FramePersonales.Controls.Add(textBox1);
            FramePersonales.Controls.Add(label3);
            FramePersonales.Controls.Add(label2);
            FramePersonales.Controls.Add(label1);
            FramePersonales.Location = new Point(5, 2);
            FramePersonales.Name = "FramePersonales";
            FramePersonales.Size = new Size(793, 126);
            FramePersonales.TabIndex = 0;
            FramePersonales.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 3;
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
            FrameDetalle.Controls.Add(dataGridView1);
            FrameDetalle.Controls.Add(cmbbuqueda);
            FrameDetalle.Controls.Add(label7);
            FrameDetalle.Controls.Add(dateTimePicker1);
            FrameDetalle.Controls.Add(label6);
            FrameDetalle.Controls.Add(textBox5);
            FrameDetalle.Controls.Add(textBox4);
            FrameDetalle.Controls.Add(label5);
            FrameDetalle.Controls.Add(textBox3);
            FrameDetalle.Controls.Add(label4);
            FrameDetalle.Location = new Point(5, 134);
            FrameDetalle.Name = "FrameDetalle";
            FrameDetalle.Size = new Size(798, 358);
            FrameDetalle.TabIndex = 1;
            FrameDetalle.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(0, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(793, 272);
            dataGridView1.TabIndex = 9;
            // 
            // cmbbuqueda
            // 
            cmbbuqueda.Image = (Image)resources.GetObject("cmbbuqueda.Image");
            cmbbuqueda.Location = new Point(236, 48);
            cmbbuqueda.Name = "cmbbuqueda";
            cmbbuqueda.Size = new Size(50, 23);
            cmbbuqueda.TabIndex = 8;
            cmbbuqueda.UseVisualStyleBackColor = true;
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
            // textBox5
            // 
            textBox5.Location = new Point(292, 48);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(136, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(434, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(136, 23);
            textBox4.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(0, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 23);
            textBox3.TabIndex = 1;
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
            CmdBoton3.Location = new Point(20, 241);
            CmdBoton3.Name = "CmdBoton3";
            CmdBoton3.Size = new Size(89, 47);
            CmdBoton3.TabIndex = 9;
            CmdBoton3.Text = "&Borrar";
            CmdBoton3.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton3.UseVisualStyleBackColor = true;
            // 
            // CmdBoton2
            // 
            CmdBoton2.Enabled = false;
            CmdBoton2.Image = (Image)resources.GetObject("CmdBoton2.Image");
            CmdBoton2.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton2.Location = new Point(20, 168);
            CmdBoton2.Name = "CmdBoton2";
            CmdBoton2.Size = new Size(89, 47);
            CmdBoton2.TabIndex = 8;
            CmdBoton2.Text = "&Editar";
            CmdBoton2.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton2.UseVisualStyleBackColor = true;
            // 
            // CmdBoton0
            // 
            CmdBoton0.Image = (Image)resources.GetObject("CmdBoton0.Image");
            CmdBoton0.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton0.Location = new Point(20, 101);
            CmdBoton0.Name = "CmdBoton0";
            CmdBoton0.Size = new Size(89, 47);
            CmdBoton0.TabIndex = 6;
            CmdBoton0.Text = "&Salir";
            CmdBoton0.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton0.UseVisualStyleBackColor = true;
            // 
            // CmdBoton1
            // 
            CmdBoton1.Image = (Image)resources.GetObject("CmdBoton1.Image");
            CmdBoton1.ImageAlign = ContentAlignment.MiddleLeft;
            CmdBoton1.Location = new Point(20, 31);
            CmdBoton1.Name = "CmdBoton1";
            CmdBoton1.Size = new Size(89, 47);
            CmdBoton1.TabIndex = 10;
            CmdBoton1.Text = "&Agregar";
            CmdBoton1.TextAlign = ContentAlignment.MiddleRight;
            CmdBoton1.UseVisualStyleBackColor = true;
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
            // FremeTipoPago
            // 
            FremeTipoPago.Controls.Add(textBox9);
            FremeTipoPago.Controls.Add(label12);
            FremeTipoPago.Controls.Add(textBox8);
            FremeTipoPago.Controls.Add(label11);
            FremeTipoPago.Controls.Add(dataGridView2);
            FremeTipoPago.Controls.Add(button1);
            FremeTipoPago.Controls.Add(textBox7);
            FremeTipoPago.Controls.Add(label10);
            FremeTipoPago.Controls.Add(textBox6);
            FremeTipoPago.Controls.Add(label9);
            FremeTipoPago.Controls.Add(comboBox2);
            FremeTipoPago.Controls.Add(label8);
            FremeTipoPago.Location = new Point(5, 492);
            FremeTipoPago.Name = "FremeTipoPago";
            FremeTipoPago.Size = new Size(798, 283);
            FremeTipoPago.TabIndex = 11;
            FremeTipoPago.TabStop = false;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(152, 23);
            comboBox2.TabIndex = 1;
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
            // textBox6
            // 
            textBox6.Location = new Point(164, 37);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 3;
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(270, 19);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 4;
            label10.Text = "Cantidad Resivida";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(270, 37);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 5;
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
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 66);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(456, 202);
            dataGridView2.TabIndex = 7;
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
            // textBox8
            // 
            textBox8.Location = new Point(631, 238);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(162, 23);
            textBox8.TabIndex = 9;
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
            // textBox9
            // 
            textBox9.Location = new Point(630, 189);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(162, 23);
            textBox9.TabIndex = 11;
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(952, 787);
            Controls.Add(groupBox1);
            Controls.Add(FremeTipoPago);
            Controls.Add(FrameDetalle);
            Controls.Add(FramePersonales);
            Name = "FrmReservas";
            Text = "FrmReservas";
            Load += FrmReservas_Load;
            FramePersonales.ResumeLayout(false);
            FramePersonales.PerformLayout();
            FrameDetalle.ResumeLayout(false);
            FrameDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            FremeTipoPago.ResumeLayout(false);
            FremeTipoPago.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FramePersonales;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private GroupBox FrameDetalle;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox textBox5;
        private Button cmbbuqueda;
        private Button CmdBoton3;
        private Button CmdBoton2;
        private Button CmdBoton0;
        private DataGridView dataGridView1;
        private Button CmdBoton1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox FremeTipoPago;
        private Label label9;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox textBox6;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private Button button1;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox9;
        private Label label12;
        private TextBox textBox8;
        private Label label11;
    }
}
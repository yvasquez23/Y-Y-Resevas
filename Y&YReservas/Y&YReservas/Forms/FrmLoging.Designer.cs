namespace Y_YReservas.Forms
{
    partial class FrmLoging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoging));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtusuario = new TextBox();
            txtpass = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 435);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(536, 60);
            label1.Name = "label1";
            label1.Size = new Size(116, 50);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(475, 159);
            txtusuario.Multiline = true;
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(251, 35);
            txtusuario.TabIndex = 2;
            txtusuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(475, 235);
            txtpass.Multiline = true;
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(251, 35);
            txtpass.TabIndex = 3;
            txtpass.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(475, 159);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(475, 233);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DodgerBlue;
            btnIngresar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ButtonFace;
            btnIngresar.Location = new Point(475, 309);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(263, 40);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmLoging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 444);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtpass);
            Controls.Add(txtusuario);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLoging";
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtusuario;
        private TextBox txtpass;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnIngresar;
    }
}
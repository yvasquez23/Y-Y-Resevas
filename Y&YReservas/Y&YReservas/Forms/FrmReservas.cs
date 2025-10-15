
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.Data.SqlClient;
using System.Data;
using Y_YReservas.Data;

namespace Y_YReservas.Forms
{
    public partial class FrmReservas : Form
    {
        DataTable rsReserva;
        DataTable rsVendedor;
        DataTable rsTipo_Pago;
        DataTable rsServicio;
        DataTable rsCliente;
        int Reserva_No = 0;
        int Reserva_ID = 0;
        SqlCommand cmdReserva;
        SqlCommand cmdVendedor;
        SqlCommand cmdTipo_Pago;
        SqlCommand cmdServicio;
        SqlCommand cmdCliente;

        SqlConnection Con = new SqlConnection(Conexion.ConnexionString());

        public FrmReservas()
        {
            InitializeComponent();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            Cargando();
            Limpiar();
        }

        private void Cargando()
        {

            string sql1 = "Select * from Cliente order by 1 desc";
            cmdCliente = new SqlCommand(sql1, Con);
            SqlDataAdapter data1 = new SqlDataAdapter(cmdCliente);
            rsCliente = new DataTable();
            data1.Fill(rsCliente);
            cmbClientes.DataSource = rsCliente;
            cmbClientes.DisplayMember = "Cliente_Nombre";
            cmbClientes.ValueMember = "Cliente_ID";

            string sql2 = "Select * from Usuarios order by 1 desc";
            cmdVendedor = new SqlCommand(sql2, Con);
            SqlDataAdapter data = new SqlDataAdapter(cmdVendedor);
            rsVendedor = new DataTable();
            data.Fill(rsVendedor);
            cmbVendedor.DataSource = rsVendedor;
            cmbVendedor.DisplayMember = "Nombre";
            cmbVendedor.ValueMember = "Usuario_ID";

            string sql3 = "Select * from TipoPago";
            cmdTipo_Pago = new SqlCommand(sql3, Con);
            SqlDataAdapter data3 = new SqlDataAdapter(cmdTipo_Pago);
            rsTipo_Pago = new DataTable();
            data3.Fill(rsTipo_Pago);
            cmbTipoPago.DataSource = rsTipo_Pago;
            cmbTipoPago.DisplayMember = "TipoPago_Desc";
            cmbTipoPago.ValueMember = "TipoPago_ID";

            string sql4 = "SELECT Servicios.Servicio_Nombre,TipoServicios.Tipo_servicio,Servicios.Precio_Servicios FROM Servicios INNER JOIN TipoServicios ON Servicios.TipoServicio_ID = TipoServicios.TipoServicio_ID";
            cmdServicio = new SqlCommand(sql4, Con);
            SqlDataAdapter servicios = new SqlDataAdapter(cmdServicio);
            rsServicio = new DataTable();
            servicios.Fill(rsServicio);
            cmdServicio.Dispose();


            FrameDetalle.Enabled = false;
            FrameTipoPago.Enabled = false;


        }
        private void Limpiar()
        {
            txtCodigo.Clear();
            cmbClientes.SelectedIndex = -1;
            cmbVendedor.SelectedIndex = -1;
            TxtServicio.Clear();
            txtTipoServicio.Clear();
            txtPrecio.Clear();
            cmbTipoPago.SelectedIndex = -1;
            txtMontoPagado.Clear();
            txtCantidadResivida.Clear();
            txtTotal.Clear();
            txtCambio.Clear();
            lstPagos.Rows.Clear();
            ltsDetalle.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string sql = "SELECT ISNULL(MAX(Reserva_No),0) + 1 FROM Reservas";
            using (SqlCommand comando = new SqlCommand(sql, Con))
            {
                Reserva_No = (Int32)comando.ExecuteScalar();
                txtCodigo.Text = Reserva_No.ToString();
                Con.Close();
            }

        }

        private void cmbbuqueda_Click(object sender, EventArgs e)
        {
            if (FrameBusqueda.Visible == false)
            {
                FrameBusqueda.Visible = true;
                FrameBusqueda.BringToFront();

                ltsServicios.DataSource = rsServicio;
            }
        }

        private void ltsServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtServicio.Tag = ltsServicios.CurrentRow.Cells[0].Value;
            TxtServicio.Text = ltsServicios.CurrentRow.Cells[1].Value.ToString();

            txtTipoServicio.Tag = ltsServicios.CurrentRow.Cells[2].Value;
            txtTipoServicio.Text = ltsServicios.CurrentRow.Cells[2].Value.ToString();

            txtPrecio.Tag = ltsServicios.CurrentRow.Cells[3].Value;
            txtPrecio.Text = ltsServicios.CurrentRow.Cells[3].Value.ToString();


            FrameBusqueda.SendToBack();
            FrameBusqueda.Visible = false;
        }

        private void CmdBoton0_Click(object sender, EventArgs e)
        {
            //frmConfiguraEnvioauto frm = new frmConfiguraEnvioauto();

            Button botoselecionado = (Button)sender;


            switch (botoselecionado.Text)
            {
                case "&Agregar":
                    if (FunAddNew() == true)
                    {
                        botoselecionado.Text = "&Salvar";
                        //formulario.Controls("").text=""
                        CmdBoton2.Text = "&Cancelar";
                        CmdBoton2.Enabled = true;
                    }
                    break;
                case "&Salvar":
                    if (FunSave() == true)
                    {
                        botoselecionado.Text = "&Agregar";
                        CmdBoton2.Text = "&Imprimir";
                        CmdBoton2.Enabled = false;
                    }
                    break;
                case "&Cancelar":
                    if (FunCancel() == true)
                    {
                        CmdBoton1.Text = "&Agregar";
                        CmdBoton2.Text = "&Editar";
                        CmdBoton2.Enabled = false;
                    }
                    break;

                case "&Imprimir":
                    if (Funprint() == true)
                    {
                        //CmdBoton1.Text = "&Salvar";
                        //botoselecionado.Text = "&Salvar";
                        CmdBoton2.Text = "&Cancelar";
                        //CmdBoton2.Enabled = true;
                    }
                    break;
                case "&Borrar":
                    if (FunDelete() == true)
                    {
                        //botoselecionado.Text = "&Salvar";
                        CmdBoton1.Text = "&Agregar";
                        CmdBoton2.Text = "&Editar";
                        //CmdBoton2.Enabled = false;
                    }
                    break;
                case "&Salir":
                    this.Hide();
                    break;

            }


        }

        private bool FunDelete()
        {
            throw new NotImplementedException();
        }


        public bool GenerarReportePDF()
        {
           
            string rutaReporte = @"C:\Reportes\MiReporte.rpt";
            string rutaSalidaPdf = @"C:\Reportes\Salida.pdf";

            
            if (!System.IO.File.Exists(rutaReporte))
            {
                MessageBox.Show("El archivo de la plantilla del reporte no se encuentra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           
            using (ReportDocument reporte = new ReportDocument())
            {
                try
                {
                    
                    reporte.Load(rutaReporte);

                   
                    reporte.ExportToDisk(ExportFormatType.PortableDocFormat, rutaSalidaPdf);

                    MessageBox.Show("El reporte PDF se ha generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    
                    CmdBoton2.Enabled = true;
                    Limpiar(); 
                }
            }
        }

        private bool Funprint()
        {
            CmdBoton2.Enabled = true;
            // GenerarReportePDF();

             Limpiar();
             return true;
        }

        private bool FunCancel()
        {
            throw new NotImplementedException();
        }

        private bool FunSave()
        {
            if (Reserva_ID != 0)
            {
                Con.Open();
                string consulta = @" INSERT INTO Reserva_Det (Reserva_ID, Servicio_ID, TipoPago_ID, Fecha_Reserva) VALUES (@Reserva_ID, @Servicio_ID, @TipoPago_ID, @Fecha_Reserva)";

                using (cmdReserva = new SqlCommand(consulta, Con))
                {
                    cmdReserva.Parameters.AddWithValue("@Reserva_ID", Reserva_ID);
                    cmdReserva.Parameters.AddWithValue("@Servicio_ID", Convert.ToInt32(TxtServicio.Tag));
                    cmdReserva.Parameters.AddWithValue("@TipoPago_ID", Convert.ToInt32(cmbTipoPago.SelectedValue));
                    cmdReserva.Parameters.AddWithValue("@Fecha_Reserva", dateTimePicker1.Value);

                    cmdReserva.ExecuteNonQuery();
                }

                Con.Close();


                DataGridViewRow filas = new DataGridViewRow();
                filas.CreateCells(ltsDetalle);

                filas.Cells[0].Value = TxtServicio.Text;
                filas.Cells[1].Value = txtTipoServicio.Text;
                filas.Cells[2].Value = txtPrecio.Text;
                filas.Cells[3].Value = dateTimePicker1.Value;

                ltsDetalle.Rows.Add(filas);

                txtTotal.Text = txtPrecio.Text;
                return true;
            }

            return false;

        }

        private bool FunAddNew()
        {
            if (Convert.ToInt32(txtCodigo.Text) != 0)
            {
                Con.Open();
                string consulta = @"INSERT INTO Reservas (Reserva_No, Usuario_ID, Cliente_ID) VALUES (@Reserva_No, @Usuario_ID, @Cliente_ID);SELECT SCOPE_IDENTITY();";

                using (cmdReserva = new SqlCommand(consulta, Con))
                {
                    cmdReserva.Parameters.AddWithValue("@Reserva_No", Convert.ToInt32(txtCodigo.Text));
                    cmdReserva.Parameters.AddWithValue("@Usuario_ID", Convert.ToInt32(cmbVendedor.SelectedValue));
                    cmdReserva.Parameters.AddWithValue("@Cliente_ID", Convert.ToInt32(cmbClientes.SelectedValue));

                    Reserva_ID = Convert.ToInt32(cmdReserva.ExecuteScalar());
                }
                Con.Close();

                FrameDetalle.Enabled = true;
                FrameTipoPago.Enabled = true;

                return true;
            }

            return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CmdBoton2.Enabled = true;
            Con.Open();

            string consulta = "update Reserva_Det set Monto='" + Convert.ToDecimal(txtMontoPagado.Text) + "',TipoPago_ID='" + Convert.ToInt32(cmbTipoPago.SelectedValue) + "' where Reserva_ID='"+Reserva_ID+"'";
            cmdReserva = new SqlCommand(consulta, Con);
            cmdReserva.ExecuteNonQuery();
            Con.Close();    


            DataGridViewRow filas = new DataGridViewRow();
            filas.CreateCells(lstPagos);

            filas.Cells[0].Value = cmbTipoPago.Text;
            filas.Cells[1].Value = txtMontoPagado.Text;

            lstPagos.Rows.Add(filas);

            txtCantidadResivida.Text = txtMontoPagado.Text;

            txtCambio.Text = (int.Parse(txtMontoPagado.Text) - float.Parse(txtTotal.Text)).ToString();

        }
    }
}

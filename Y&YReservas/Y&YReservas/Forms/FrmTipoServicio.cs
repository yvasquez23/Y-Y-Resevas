using Microsoft.Data.SqlClient;
using Microsoft.Reporting.NETCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Y_YReservas.Data;

namespace Y_YReservas.Forms
{
    public partial class FrmTipoServicio : Form
    {
        DataTable rsTipoServicio;
        SqlCommand cmdTipoServicio;
        SqlDataReader reader;
        SqlConnection Con = new SqlConnection(Conexion.ConnexionString());
        public FrmTipoServicio()
        {
            InitializeComponent();
        }

        private void FrmTipoServicio_Load(object sender, EventArgs e)
        {
            Cargando();

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaReporte = @"C:\Reportes\MiReporte.rdlc";

            // Crear el DataTable (necesario aunque sea vacío, si el RDLC espera un dataset)
            DataTable dt = new DataTable("DataSet1"); // el nombre debe coincidir con el del RDLC

            // Configurar el visor
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = rutaReporte;

            // Limpiar fuentes previas
            reportViewer1.LocalReport.DataSources.Clear();

            // Agregar la fuente de datos (aunque esté vacía)
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);

            // Refrescar para mostrar
            reportViewer1.RefreshReport();
        }

        private void Cargando()
        {
            string sql = "Select * From TipoServicios order by Tipo_servicio desc";
            cmdTipoServicio = new SqlCommand(sql, Con);
            SqlDataAdapter data = new SqlDataAdapter(cmdTipoServicio);
            rsTipoServicio = new DataTable();
            data.Fill(rsTipoServicio);
            cmdTipoServicio.Dispose();
        }

        private bool VerificarSiAlgoCambio()
        {
            if (txtTipoServicio.Text != txtTipoServicio.Tag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void LimpiarCampos()
        {
            txtTipoServicio.Clear();
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
                        CmdBoton2.Text = "&Editar";
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

                case "&Editar":
                    if (FunEdit() == true)
                    {
                        CmdBoton1.Text = "&Salvar";
                        //botoselecionado.Text = "&Salvar";
                        CmdBoton2.Text = "&Cancelar";
                        CmdBoton2.Enabled = true;
                    }
                    break;
                case "&Borrar":
                    if (FunDelete() == true)
                    {
                        //botoselecionado.Text = "&Salvar";
                        CmdBoton1.Text = "&Agregar";
                        CmdBoton2.Text = "&Editar";
                        CmdBoton2.Enabled = false;
                    }
                    break;
                case "&Salir":
                    this.Hide();
                    break;

            }


        }

        private bool FunDelete()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                DialogResult Result = MessageBox.Show("Esta Seguro que desea borrar este Servicio?", "Informacion", MessageBoxButtons.YesNo);
                
                if (Result == DialogResult.Yes)
                {
                    Con.Open();
                    string sql = "delete from TipoServicios where TipoServicio_ID=" +(Int32)txtTipoServicio.Tag;
                    SqlCommand comando = new SqlCommand(sql, Con);
                    comando.ExecuteNonQuery();
                    Con.Close();
                    LimpiarCampos();
                    Cargando();
                    return true;
                }
                else
                {
                    return false;
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private bool FunEdit()
        {
            CmdBoton1.Enabled = true;

            txtTipoServicio.Focus();
            return true;
        }

        private bool FunCancel()
        {
           if(Convert.ToInt32(txtTipoServicio.Tag) != 0)
            {
                if(VerificarSiAlgoCambio() == true)
                {
                    DialogResult Result = MessageBox.Show("Se han realizado Cambios que no han sido guardados", "Informacion", MessageBoxButtons.YesNo);
                    if(Result == DialogResult.No)
                    {
                        return false;
                    }
                }

            }

            return true;
        }

        private bool FunSave()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if(Validar() == true)
                {
                    if((Int32)txtTipoServicio.Tag == 0)
                    {
                        Con.Open();
                        string sql = "Insert into TipoServicios(Tipo_servicio) values('" + txtTipoServicio.Text + "')";
                        SqlCommand comondo = new SqlCommand (sql,Con);
                        comondo.ExecuteNonQuery();
                        Con.Close();
                    }
                    else
                    {
                        Con.Open();
                        string sql = "update TipoServicios set Tipo_servicio='" + txtTipoServicio.Text + "' where TipoServicio_ID='" + Convert.ToInt32(txtTipoServicio.Tag) + "'";
                        SqlCommand comondo = new SqlCommand ( sql,Con);
                        comondo.ExecuteNonQuery();  
                        Con.Close();

                    }

                    txtTipoServicio.Tag = 0;
                    LimpiarCampos();
                    Cargando();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Y&Y Reservas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private bool FunAddNew()
        {
            txtTipoServicio.Tag = 0;
            LimpiarCampos();
            txtTipoServicio.Focus();
            return true;
        }

        private void cmbbuqueda_Click(object sender, EventArgs e)
        {
            if (frameBusqueda.Visible == false)
            {
                Cargando();
                frameBusqueda.Height = 218;
                frameBusqueda.Width = 345;
                frameBusqueda.Visible = true;
                txtTipoServicio.Tag = 0;
                //FunCancel();


                dgvTipoServicio.DataSource = rsTipoServicio;
                txtbusqueda.Text = "";
                txtbusqueda.Focus();
            }
            else
            {
                frameBusqueda.Visible = false;

            }

        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtbusqueda.Text != "")
            {
                rsTipoServicio.DefaultView.RowFilter = $"Tipo_servicio LIKE '%{txtbusqueda.Text}%'";

            }
        }

        private void dgvTipoServicio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();

            txtTipoServicio.Tag = dgvTipoServicio.CurrentRow.Cells[0].Value;
            txtTipoServicio.Text = dgvTipoServicio.CurrentRow.Cells[1].Value.ToString();

            frameBusqueda.Visible = false;
            CmdBoton2.Enabled = true;
            CmdBoton3.Enabled = true;


        }

        private bool Validar()
        {

            if (txtTipoServicio.Text == "")
            {
                MessageBox.Show("Debe digitar la Descripcion", "S&S Reservas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTipoServicio.Focus();
                return false;
            }


            return true;

        }
    }



}

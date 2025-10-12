using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Y_YReservas.Data;

namespace Y_YReservas.Forms
{
    public partial class FrmServicios : Form
    {

        DataTable rsServicios;
        DataTable rsTipoServicios;
        SqlCommand cmdTipoServicios;
        SqlCommand cmdServicios;
        SqlConnection conn = new SqlConnection(Conexion.ConnexionString());

        public FrmServicios()
        {
            InitializeComponent();
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            Cargando();
            LimpiarCAmpos();
        }


        private void Cargando()
        {
            string sql = "Select * from Servicios order by 1 desc";
            cmdServicios = new SqlCommand(sql, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmdServicios);
            rsServicios = new DataTable();
            data.Fill(rsServicios);
            cmdServicios.Dispose();

            string sql1 = "Select * from TipoServicios";
            cmdTipoServicios = new SqlCommand(sql1, conn);
            SqlDataAdapter comando = new SqlDataAdapter(cmdTipoServicios);
            rsTipoServicios = new DataTable();
            comando.Fill(rsTipoServicios);
            cmbTipoServicio.DataSource = rsTipoServicios;
            cmbTipoServicio.DisplayMember = "Tipo_servicio";
            cmbTipoServicio.ValueMember = "TipoServicio_ID";



        }


        private bool VerifiacrSiAlgoCambio()
        {
            if (txtNombre.Text != txtNombre.Tag)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


        private void LimpiarCAmpos()
        {
            txtNombre.Clear();
            cmbTipoServicio.SelectedIndex = 0;
            txtPrecio.Clear();
        }


        private void cmbbuqueda_Click(object sender, EventArgs e)
        {
            if (frameBusqueda.Visible == false)
            {
                Cargando();
                frameBusqueda.Height = 133;
                frameBusqueda.Width = 393;
                frameBusqueda.Visible = true;
                txtNombre.Tag = 0;
                //FunCancel();


                dataGridView1.DataSource = rsServicios;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                frameBusqueda.Visible = false;

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCAmpos();

            txtNombre.Tag = dataGridView1.CurrentRow.Cells[0].Value;
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            cmbTipoServicio.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value;
            cmbTipoServicio.Tag = dataGridView1.CurrentRow.Cells[2].Value;

            txtPrecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Tag = dataGridView1.CurrentRow.Cells[3].Value;



            frameBusqueda.Visible = false;
            CmdBoton2.Enabled = true;
            CmdBoton3.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text != "")
            {
               rsTipoServicios.DefaultView.RowFilter = $"Tipo_servicio LIKE '%{textBox1.Text}%'";

            }
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
                    conn.Open();
                    string sql = "delete from Servicios where Servicio_ID=" + (Int32)txtNombre.Tag;
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.ExecuteNonQuery();
                    conn.Close();
                    LimpiarCAmpos();
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

            txtNombre.Focus();
            return true;
        }

        private bool FunCancel()
        {
            if (Convert.ToInt32(txtNombre.Tag) != 0)
            {
                if (VerifiacrSiAlgoCambio() == true)
                {
                    DialogResult Result = MessageBox.Show("Se han realizado Cambios que no han sido guardados", "Informacion", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.No)
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
                if(Validate() == true)
                {
                    if((Int32)txtNombre.Tag == 0)
                    {
                        conn.Open();
                        string sql = "Insert into Servicios(Servicio_Nombre,TipoServicio_ID,Precio_Servicios) values('" + txtNombre.Text + "','" + Convert.ToInt32(cmbTipoServicio.SelectedValue) + "','" + Convert.ToDecimal(txtPrecio.Text) + "')";
                        cmdServicios = new SqlCommand(sql, conn);
                        cmdServicios.ExecuteNonQuery();
                        conn.Close();

                    }
                    else
                    {
                        conn.Open();
                        string sql = "update Servicios set Servicio_Nombre='" + txtNombre.Text + "',TipoServicio_ID='" + Convert.ToInt32(cmbTipoServicio.SelectedValue) + "',Precio_Servicios='" + Convert.ToDecimal(txtPrecio.Text) + "' where Servicio_ID='"+Convert.ToInt32(txtNombre.Tag)+"'";
                        cmdServicios = new SqlCommand( sql, conn);
                        cmdServicios.ExecuteNonQuery();
                        conn.Close();
                    }

                    txtNombre.Tag = 0;
                    LimpiarCAmpos();
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
            txtNombre.Tag = 0;
            LimpiarCAmpos();
            txtNombre.Focus();
            return true;
        }
    }
}

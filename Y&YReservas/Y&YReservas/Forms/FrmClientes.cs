using Microsoft.Data.SqlClient;
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
    public partial class FrmClientes : Form
    {
        DataTable rsCliente;
        SqlCommand cmdCliente;
        SqlConnection Con = new SqlConnection(Conexion.ConnexionString());
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Cargando();
        }

        private void Cargando()
        {
            string sql = "Select * from Cliente order by 1 desc";
            cmdCliente = new SqlCommand(sql, Con);
            SqlDataAdapter data = new SqlDataAdapter(cmdCliente);
            rsCliente = new DataTable();
            data.Fill(rsCliente);
            cmdCliente.Dispose();
        }

        private bool VerificarSiAlgoCambio()
        {
            if (txtCodigo.Text != txtCodigo.Tag)
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
            txtCodigo.Clear();
            txtNommbre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private bool Validar()
        {

            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe digitarel codigo del cliente", "S&S Reservas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Focus();
                return false;
            }
            if (txtNommbre.Text == "")
            {
                MessageBox.Show("Debe digitar el nombre del cliente", "S&S Reservas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNommbre.Focus();
                return false;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe digitar el telefono del telefono", "S&S Reservas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefono.Focus();
                return false;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Debe digitar la direccion del cliente", "S&S Reservas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDireccion.Focus();
                return false;
            }
            return true;

        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgClientes.CurrentRow.Cells[1].Value.ToString();
            txtNommbre.Tag = dtgClientes.CurrentRow.Cells[0].Value;

            txtNommbre.Tag = dtgClientes.CurrentRow.Cells[0].Value;
            txtNommbre.Text = dtgClientes.CurrentRow.Cells[2].Value.ToString();

            txtTelefono.Tag = dtgClientes.CurrentRow.Cells[0].Value;
            txtTelefono.Text = dtgClientes.CurrentRow.Cells[3].Value.ToString();

            txtDireccion.Text = dtgClientes.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Tag = dtgClientes.CurrentRow.Cells[0].Value;


            FrameBusqueda.Visible = false;
            CmdBoton2.Enabled = true;
            CmdBoton3.Enabled = true;
        }

        private void cmbbuqueda_Click(object sender, EventArgs e)
        {
            if (FrameBusqueda.Visible == false)
            {
                Cargando();
                FrameBusqueda.Height = 218;
                FrameBusqueda.Width = 345;
                FrameBusqueda.Visible = true;
                txtCodigo.Tag = 0;
                //FunCancel();


                dtgClientes.DataSource = rsCliente;
                txtBusqueda.Text = "";
                txtBusqueda.Focus();
            }
            else
            {
                FrameBusqueda.Visible = false;

            }
        }
        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBusqueda.Text != "")
            {
                rsCliente.DefaultView.RowFilter = $"Cliente_Nombre LIKE '%{txtBusqueda.Text}%'";

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
                DialogResult Result = MessageBox.Show("Esta Seguro que desea borrar este Cliente?", "Informacion", MessageBoxButtons.YesNo);

                if (Result == DialogResult.Yes)
                {
                    Con.Open();
                    string sql = "delete from Cliente where Cliente_ID=" + (Int32)txtNommbre.Tag;
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

            txtCodigo.Focus();
            return true;
        }

        private bool FunCancel()
        {
            if (Convert.ToInt32(txtCodigo.Tag) != 0)
            {
                if (VerificarSiAlgoCambio() == true)
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

                if (Validar() == true)
                {
                    if ((Int32)txtNommbre.Tag == 0)
                    {
                        Con.Open();
                        string sql = "Insert into Cliente(CLiente_Codigo,Cliente_Nombre,Cliente_Telefono,Cliente_Direccion) values('"+txtCodigo.Text+"','"+txtNommbre.Text+"','"+txtTelefono.Text+"','"+txtDireccion.Text+"')";
                        cmdCliente = new SqlCommand(sql, Con);
                        cmdCliente.ExecuteNonQuery();
                        Con.Close();
                    }
                    else
                    {
                        Con.Open();
                        string sql = "update Cliente set Cliente_Codigo='"+txtCodigo.Text+"',Cliente_Nombre='"+txtNommbre.Text+"',Cliente_Telefono='"+txtTelefono.Text+"',Cliente_Direccion='"+txtDireccion.Text+"' where Cliente_ID='"+Convert.ToInt32(txtNommbre.Tag)+"'";
                        cmdCliente = new SqlCommand(sql, Con);
                        cmdCliente.ExecuteNonQuery();
                        Con.Close();

                    }

                    txtCodigo.Tag = 0;
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
           txtNommbre.Tag = 0;
            LimpiarCampos();
            txtCodigo.Focus();
            return true;
        }
    }
}

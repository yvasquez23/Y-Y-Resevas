using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
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
    public partial class FrmTipoPago : Form
    {
        DataTable rsTippoPago;
        SqlCommand cmdTipoPago;

        SqlConnection conn = new SqlConnection(Conexion.ConnexionString());
        public FrmTipoPago()
        {
            InitializeComponent();
        }

        private void FrmTipoPago_Load(object sender, EventArgs e)
        {
            Cargando();
        }

        private void Cargando()
        {

            string sql = "Select * from TipoPago order by TipoPago_Desc desc";
            cmdTipoPago = new SqlCommand(sql, conn);
            SqlDataAdapter data = new SqlDataAdapter(cmdTipoPago);
            rsTippoPago = new DataTable();
            data.Fill(rsTippoPago);
            cmdTipoPago.Dispose();


        }

        private void LimpiarCampos()
        {
            txtDesc.Clear();
        }

        private bool Validar()
        {
            if(txtDesc.Text == "")
            {
                MessageBox.Show("Debe digitar la Descripcion", "S&S Reservas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDesc.Focus();
                return false;
            }

            return true;
        }

        private bool VerificarSiAlgoCambio()
        {
            if (txtDesc.Text != txtDesc.Tag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cmbbuqueda_Click(object sender, EventArgs e)
        {
            if (franeBusqueda.Visible == false)
            {
                Cargando();
                franeBusqueda.Height = 285;
                franeBusqueda.Width = 405;
                franeBusqueda.Visible = true;
                txtDesc.Tag = 0;
                //FunCancel();


                dgvBusqueda.DataSource = rsTippoPago;
                txtBuscar.Text = "";
                txtBuscar.Focus();
            }
            else
            {
                franeBusqueda.Visible = false;

            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                rsTippoPago.DefaultView.RowFilter = $"TipoPago_Desc LIKE '%{txtBuscar.Text}%'";
            }
        }

        private void dgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();

            txtDesc.Tag = dgvBusqueda.CurrentRow.Cells[0].Value;
            txtDesc.Text = dgvBusqueda.CurrentRow.Cells[1].Value.ToString();

            franeBusqueda.Visible = false;
            CmdBoton2.Enabled = true;
            CmdBoton3.Enabled = true;
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
                DialogResult Result = MessageBox.Show("Esta seguro que desea borrar este tipo de pago?", "Informacion", MessageBoxButtons.YesNo);
                if(Result == DialogResult.Yes)
                {
                    conn.Open();
                    string sql = "delete from TipoPago where TipoPago_ID="+ (Int32)txtDesc.Tag;
                    cmdTipoPago = new SqlCommand(sql,conn);
                    cmdTipoPago.ExecuteNonQuery();
                    conn.Close();
                    Cargando();
                    LimpiarCampos();
                    return true;
                }

                return false;
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

        private bool FunEdit()
        {
            CmdBoton1.Enabled = true;

            txtDesc.Focus();
            return true;
        }

        private bool FunCancel()
        {
            if (Convert.ToInt32(txtDesc.Tag) != 0)
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

                if(Validar() == true)
                {
                    if((Int32)txtDesc.Tag == 0)
                    {
                        conn.Open();
                        string sql = "insert into TipoPago(TipoPago_Desc) values('" + txtDesc.Text + "')";
                        cmdTipoPago = new SqlCommand(sql, conn);
                        cmdTipoPago.ExecuteNonQuery();
                        conn.Close();

                    }
                    else
                    {
                        conn.Open();
                        string swl = "update TipoPago set TipoPago_Desc='" + txtDesc.Text + "' where TipoPago_iD='"+ Convert.ToInt32(txtDesc.Tag)+ "'";
                        cmdTipoPago = new SqlCommand(swl, conn);
                        cmdTipoPago.ExecuteNonQuery();
                        conn.Close();

                    }

                    txtDesc.Tag = 0;
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
                this.Cursor= Cursors.Default;
            }
        }

        private bool FunAddNew()
        {
            txtDesc.Tag = 0;
            LimpiarCampos();
            txtDesc.Focus();
            return true;
        }
    }
}

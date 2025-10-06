using Microsoft.Data.SqlClient;
using Y_YReservas.Data;

namespace Y_YReservas.Forms
{
    public partial class FrmLoging : Form
    {
        SqlConnection Con = new SqlConnection(Conexion.ConnexionString());
        public FrmLoging()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            btnIngresar.Enabled = false;
            try
            {
                if(Validar() == true)
                {
                   
                    Con.Open();
                    string query = "Select * from Usuarios where UsuarioDesc='" + txtusuario.Text + "' And contraseña='" + txtpass.Text + "'";
                    SqlCommand comando = new SqlCommand(query,Con);
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.Read())
                    {
                        
                        Menu menu = new Menu();
                        menu.Show();
                        Con.Close();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Clave Incorrecta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario o Clave Incorrecta" + ex.Message);
                Con.Close();
            }
            finally
            {
                progressBar1.Visible=false;
                btnIngresar.Enabled=true;
            }
        }

        

        private bool Validar()
        {
            if(txtusuario.Text == "")
            {
                MessageBox.Show("Debe dijitar el usuario");
                txtusuario.Focus();
                return false;
            }
            if(txtpass.Text == "")
            {
                MessageBox.Show("Debe dijitar su contraseña");
                txtpass.Focus(); 
                return false;
            }
            return true;
        }
    }
}

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
    public partial class FrmLoging : Form
    {
        SqlConnection Con = new SqlConnection(Conexion.ConnexionString());
        public FrmLoging()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
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
                        MessageBox.Show("Bienbenido Patron");
                        Con.Close();
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParetoKin.vista
{
    public partial class Loggin : Form
    {
        int contador = 0;
        public Loggin()
        {
            InitializeComponent();

            this.buttonIngresar.Text = Program.str.diccionario["buttonIngresar"];
            this.buttonSalir.Text = Program.str.diccionario["buttonSalir"];
            this.labelUser.Text = Program.str.diccionario["labelUser"];
            this.labelPassword.Text = Program.str.diccionario["labelPassword"];

           //Console.WriteLine(md5_string("root123"));

        }

        public string md5_string(string pass)
        {
            /// de la clase MD5 sirver para invocar las funciones de encriptación y hash de MD5 incluidas en las librerias de C#}}
            MD5 md5_convertor = MD5.Create();

            /// arreglo donde se almacena los en código ASCII los elementos de un string para un proceso de hash
            byte[] inputBytes;

            /// arreglo donde se almacena el resultado de la operación hash de MD5
            byte[] hash;
            StringBuilder builder_string;
            inputBytes = Encoding.ASCII.GetBytes(pass);
            hash = md5_convertor.ComputeHash(inputBytes);
            builder_string = new StringBuilder();
            for (byte i = 0; i < hash.Length; i++)
            {
                builder_string.Append(hash[i].ToString("X2"));
            }
            return builder_string.ToString();
        }


        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            if(contador == 3)
            {
                MessageBox.Show(Program.str.diccionario["msgUsuarioBloqueado"]);

                return;
            }
            using (var conn = new SqlConnection(Program.CONECCION_STRING))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("consultarUsuario", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@nombreUsuario", this.textBoxUsuario.Text));
                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        string hash = rdr["contrasenia"].ToString();

                        if (hash.Equals(this.md5_string(this.textBoxPassword.Text)))
                        {
                            this.Hide();
                            VistaPrincipal ventana = new VistaPrincipal(this);
                            ventana.Show();
                        }
                        else
                        {
                            MessageBox.Show(Program.str.diccionario["msgContraseniaIncorrecta"]);
                            contador++;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Program.str.diccionario["msgUsuarioIncorrecto"]);
                    }
                }

                conn.Close();
            }
        }
    }
}

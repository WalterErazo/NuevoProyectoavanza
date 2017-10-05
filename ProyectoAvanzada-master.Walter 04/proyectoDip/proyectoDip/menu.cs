using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDip
{
    public partial class menu : Form
    {
        Usuario[] users = new Usuario[999];
        string usuarioActualM;
        public menu()
        {
            InitializeComponent();
        }
        public menu(Usuario[] u, string UsuarioActual="")
        {
            InitializeComponent();

            users = u;
            usuarioActualM = UsuarioActual;

        }


        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            modificar_usuario mod = new modificar_usuario(users,usuarioActualM);
            mod.Show();
            this.Hide();
        }
    }
}

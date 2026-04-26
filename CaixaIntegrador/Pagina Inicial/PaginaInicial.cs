using CaixaIntegrador.Caixa;
using CaixaIntegrador.Pagina_Inicial;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaIntegrador
{
    public partial class PaginaInicial : MaterialForm
    {
        public PaginaInicial()
        {
            InitializeComponent();
            
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {
           CarregarCaixa();
        }

        public void MostrarLogin()
        {
            panelPrincipal.Controls.Clear();
            var login = new LoginControl(this);
            login.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(login);
        }

        public void MostrarRegistro()
        {
            panelPrincipal.Controls.Clear();
            var registro = new RegistroControl(this);
            registro.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(registro);
        }

        public void CarregarCaixa()
        {
            panelPrincipal.Controls.Clear();
            var caixaControl = new CaixaControl();
            caixaControl.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(caixaControl);
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteServico.ServiceReference1;

namespace TesteServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastre_Click(object sender, EventArgs e)
        {
            using (var servico = new ServiceReference1.CaronaClient())
            {
                servico.CadastreCarona(txtDescricao.Text, txtOrigem.Text, txtDestino.Text);
            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            using (var servico = new ServiceReference1.CaronaClient())
            {
                var caronas = servico.GetCaronas();
                grdCaronas.DataSource = servico.GetCaronas();
                
                //servico.GetCaronas();
                grdCaronas.Refresh();
            }
        }

        private void grdCaronas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

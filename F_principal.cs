using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class F_principal : Form
    {
        public F_principal()
        {
            InitializeComponent();
        }

       
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            F_cadastroFunc f_CadastroFunc = new F_cadastroFunc();
            f_CadastroFunc.ShowDialog();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            F_consultarFunc f_ConsultarFunc = new F_consultarFunc();
            f_ConsultarFunc.ShowDialog();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            F_calculoSalario f_CalculoSalario = new F_calculoSalario();
            f_CalculoSalario.ShowDialog();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

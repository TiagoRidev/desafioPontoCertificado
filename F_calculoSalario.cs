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
    public partial class F_calculoSalario : Form
    {
        public F_calculoSalario()
        {
            InitializeComponent();
        }

        private void btn_calcSal_Click(object sender, EventArgs e)
        {
            int salarioTotal = tb_salario;

            foreach (tb_cpf.text item in mtb_infCpf.Text)
            {
                if (mtb_infCpf.Text == item.tb_cpf.text)
                {
                    item.Selected = true;
                    MessageBox.Show("O valor a pagar do funcionário é " + salarioTotal);
                    break;
                }
                else
                {
                    MessageBox.Show("Funcionário não localizado!");
                }
            }
        }

        private void btn_limparCons_Click(object sender, EventArgs e)
        {
            mtb_cpfCalcSal.Clear();
            tb_nomeFuncCons.Clear();
            tb_salFunCons.Clear();
            tb_valTt.Clear();
        }

        private void btn_fecharCons_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

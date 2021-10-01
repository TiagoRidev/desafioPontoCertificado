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
    public partial class F_cadastroFunc : Form
    {
        public F_cadastroFunc()
        {
            InitializeComponent();
        }

        public void btn_addFunc_Click(object sender, EventArgs e)
        {
            string nomeCompleto = tb_nomeCompleto.Text;
            string sexo = tb_sexo.Text;
            string email = tb_email.Text;
            DateTime dataAdmissao = tb_dataAdmissão.Value;
            string turno = tb_turno.Text;
            string setor = tb_setor.Text;

            if (tb_nomeCompleto.Text == "")
            {
                MessageBox.Show("Digite o nome completo do funcionário.");
                tb_nomeCompleto.Focus();
                return;
                
            }            
           
            if (tb_sexo.Text == "")
            {
                MessageBox.Show("Digite o sexo do funcionário.");
                tb_sexo.Focus();
                return;
            }            

            if (mtb_pis.Text == "")
            {
                MessageBox.Show("Digite o PIS do funcionário.");
                mtb_pis.Focus();
                return;

                int pis = Convert.ToInt32(mtb_pis.Text);
            }             
            
            
            if (mtb_cpf.Text == "")
            {
                MessageBox.Show("Digite o CPF do funcionário.");
                mtb_cpf.Focus();
                return;

                int cpf = Convert.ToInt32(mtb_cpf.Text);
            }
            
            
            if (tb_salario.Text == "")
            {
                MessageBox.Show("Digite o salário do funcionário.");
                tb_salario.Focus();
                return;

                int salario = Convert.ToInt32(tb_salario.Text);
            }
            
            
            if (tb_email.Text == "")
            {
                MessageBox.Show("Digite o e-mail do funcionário.");
                tb_email.Focus();
                return;
            }
            
            if (tb_dataAdmissão.Text == "")
            {
                MessageBox.Show("Digite a data de admissão do funcionário.");
                tb_dataAdmissão.Focus();
                return;
            }                      

            if (tb_turno.Text == "")
            {
                MessageBox.Show("Informe o turno do funcionário.");
                tb_turno.Focus();
                return;
            }            

            if (tb_setor.Text == "")
            {
                MessageBox.Show("Informe o setor do funcionário.");
                tb_setor.Focus();
                return;
            }           
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_nomeCompleto.Clear();
            tb_sexo.SelectedIndex = -1;
            mtb_pis.Clear();
            mtb_cpf.Clear();
            tb_salario.Clear();
            tb_email.Clear();
            tb_dataAdmissão.Value = DateTime.Now.Date;
            tb_turno.SelectedIndex = -1;
            tb_setor.SelectedIndex = -1;

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

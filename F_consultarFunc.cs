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
    public partial class F_consultarFunc : Form
    {

        
        public F_consultarFunc()
        {
            InitializeComponent();
          
        }

       
        public void btn_consultarFunc_Click(object sender, EventArgs e)
        {
            foreach (tb_cpf.text item in mtb_infCpf.Text)
            {
                if (mtb_infCpf.Text == item.tb_cpf.text)
                {
                    item.Selected = true;
                    break;
                }
                else
                {
                    MessageBox.Show("Funcionário não localizado!");
                }
            }

            foreach (tb_nomeCompleto item in tb_nomeFuncCons.Text)
            {
                if (tb_nomeFuncCons.Text == item.tb_nomeCompleto)
                {
                    item.Selected = true;
                    break;
                }
                else
                {
                    MessageBox.Show("Funcionário não localizado!");
                }
            }
        }

        private void btn_limpar_Cons_Click(object sender, EventArgs e)
        {
            mtb_infCpf.Clear();
            tb_nomeFunCons.Clear();
            lv_dados = string.Empty;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

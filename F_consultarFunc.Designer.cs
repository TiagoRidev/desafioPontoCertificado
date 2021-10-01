
namespace main
{
    partial class F_consultarFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_tituloConsFunc = new System.Windows.Forms.Label();
            this.btn_consultarFunc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeFunCons = new System.Windows.Forms.TextBox();
            this.mtb_infCpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_limpar_Cons = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.lv_dados = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lb_tituloConsFunc
            // 
            this.lb_tituloConsFunc.AutoSize = true;
            this.lb_tituloConsFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tituloConsFunc.Location = new System.Drawing.Point(12, 36);
            this.lb_tituloConsFunc.Name = "lb_tituloConsFunc";
            this.lb_tituloConsFunc.Size = new System.Drawing.Size(524, 25);
            this.lb_tituloConsFunc.TabIndex = 0;
            this.lb_tituloConsFunc.Text = "PARA CONSULTAR OS DADOS DE UM FUNCIONÁRIO:";
            // 
            // btn_consultarFunc
            // 
            this.btn_consultarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarFunc.Location = new System.Drawing.Point(201, 271);
            this.btn_consultarFunc.Name = "btn_consultarFunc";
            this.btn_consultarFunc.Size = new System.Drawing.Size(149, 38);
            this.btn_consultarFunc.TabIndex = 1;
            this.btn_consultarFunc.Text = "&Consultar";
            this.btn_consultarFunc.UseVisualStyleBackColor = true;
            this.btn_consultarFunc.Click += new System.EventHandler(this.btn_consultarFunc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "INFORME O CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "OU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "INFORME O NOME";
            // 
            // tb_nomeFunCons
            // 
            this.tb_nomeFunCons.Location = new System.Drawing.Point(127, 226);
            this.tb_nomeFunCons.Name = "tb_nomeFunCons";
            this.tb_nomeFunCons.Size = new System.Drawing.Size(293, 20);
            this.tb_nomeFunCons.TabIndex = 6;
            // 
            // mtb_infCpf
            // 
            this.mtb_infCpf.Location = new System.Drawing.Point(234, 115);
            this.mtb_infCpf.Mask = "000.000.000-00";
            this.mtb_infCpf.Name = "mtb_infCpf";
            this.mtb_infCpf.Size = new System.Drawing.Size(84, 20);
            this.mtb_infCpf.TabIndex = 7;
            this.mtb_infCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_limpar_Cons
            // 
            this.btn_limpar_Cons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar_Cons.Location = new System.Drawing.Point(127, 661);
            this.btn_limpar_Cons.Name = "btn_limpar_Cons";
            this.btn_limpar_Cons.Size = new System.Drawing.Size(123, 37);
            this.btn_limpar_Cons.TabIndex = 9;
            this.btn_limpar_Cons.Text = "&Limpar";
            this.btn_limpar_Cons.UseVisualStyleBackColor = true;
            this.btn_limpar_Cons.Click += new System.EventHandler(this.btn_limpar_Cons_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.Location = new System.Drawing.Point(297, 661);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(123, 37);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.Text = "&Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lv_dados
            // 
            this.lv_dados.HideSelection = false;
            this.lv_dados.Location = new System.Drawing.Point(30, 345);
            this.lv_dados.Name = "lv_dados";
            this.lv_dados.Size = new System.Drawing.Size(479, 278);
            this.lv_dados.TabIndex = 11;
            this.lv_dados.UseCompatibleStateImageBehavior = false;
            // 
            // F_consultarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 724);
            this.Controls.Add(this.lv_dados);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_limpar_Cons);
            this.Controls.Add(this.mtb_infCpf);
            this.Controls.Add(this.tb_nomeFunCons);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_consultarFunc);
            this.Controls.Add(this.lb_tituloConsFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_consultarFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR FUNCIONÁRIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tituloConsFunc;
        private System.Windows.Forms.Button btn_consultarFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeFunCons;
        private System.Windows.Forms.MaskedTextBox mtb_infCpf;
        private System.Windows.Forms.Button btn_limpar_Cons;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.ListView lv_dados;
    }
}
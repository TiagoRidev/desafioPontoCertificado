
namespace main
{
    partial class F_calculoSalario
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
            this.lb_tituloCalcSal = new System.Windows.Forms.Label();
            this.mtb_cpfCalcSal = new System.Windows.Forms.MaskedTextBox();
            this.btn_calcSal = new System.Windows.Forms.Button();
            this.lb_nomeFuncCalc = new System.Windows.Forms.Label();
            this.tb_nomeFuncCons = new System.Windows.Forms.TextBox();
            this.tb_salFunCons = new System.Windows.Forms.TextBox();
            this.lb_salarioCons = new System.Windows.Forms.Label();
            this.tb_valTt = new System.Windows.Forms.TextBox();
            this.lb_vlTt = new System.Windows.Forms.Label();
            this.btn_limparCons = new System.Windows.Forms.Button();
            this.btn_fecharCons = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_tituloCalcSal
            // 
            this.lb_tituloCalcSal.AutoSize = true;
            this.lb_tituloCalcSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tituloCalcSal.Location = new System.Drawing.Point(12, 38);
            this.lb_tituloCalcSal.Name = "lb_tituloCalcSal";
            this.lb_tituloCalcSal.Size = new System.Drawing.Size(635, 25);
            this.lb_tituloCalcSal.TabIndex = 0;
            this.lb_tituloCalcSal.Text = "INFORME O CPF DO FUNCIONÁRIO PARA CALCULAR O SALÁRIO ";
            // 
            // mtb_cpfCalcSal
            // 
            this.mtb_cpfCalcSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_cpfCalcSal.Location = new System.Drawing.Point(269, 84);
            this.mtb_cpfCalcSal.Mask = "000.000.000-00";
            this.mtb_cpfCalcSal.Name = "mtb_cpfCalcSal";
            this.mtb_cpfCalcSal.Size = new System.Drawing.Size(94, 21);
            this.mtb_cpfCalcSal.TabIndex = 0;
            // 
            // btn_calcSal
            // 
            this.btn_calcSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcSal.Location = new System.Drawing.Point(256, 133);
            this.btn_calcSal.Name = "btn_calcSal";
            this.btn_calcSal.Size = new System.Drawing.Size(118, 33);
            this.btn_calcSal.TabIndex = 1;
            this.btn_calcSal.Text = "&Calcular";
            this.btn_calcSal.UseVisualStyleBackColor = true;
            this.btn_calcSal.Click += new System.EventHandler(this.btn_calcSal_Click);
            // 
            // lb_nomeFuncCalc
            // 
            this.lb_nomeFuncCalc.AutoSize = true;
            this.lb_nomeFuncCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomeFuncCalc.Location = new System.Drawing.Point(41, 206);
            this.lb_nomeFuncCalc.Name = "lb_nomeFuncCalc";
            this.lb_nomeFuncCalc.Size = new System.Drawing.Size(96, 20);
            this.lb_nomeFuncCalc.TabIndex = 3;
            this.lb_nomeFuncCalc.Text = "Funcionário:";
            // 
            // tb_nomeFuncCons
            // 
            this.tb_nomeFuncCons.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_nomeFuncCons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nomeFuncCons.Location = new System.Drawing.Point(139, 210);
            this.tb_nomeFuncCons.Name = "tb_nomeFuncCons";
            this.tb_nomeFuncCons.ReadOnly = true;
            this.tb_nomeFuncCons.Size = new System.Drawing.Size(289, 13);
            this.tb_nomeFuncCons.TabIndex = 4;
            // 
            // tb_salFunCons
            // 
            this.tb_salFunCons.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_salFunCons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_salFunCons.Location = new System.Drawing.Point(104, 250);
            this.tb_salFunCons.Name = "tb_salFunCons";
            this.tb_salFunCons.ReadOnly = true;
            this.tb_salFunCons.Size = new System.Drawing.Size(139, 13);
            this.tb_salFunCons.TabIndex = 6;
            // 
            // lb_salarioCons
            // 
            this.lb_salarioCons.AutoSize = true;
            this.lb_salarioCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salarioCons.Location = new System.Drawing.Point(39, 246);
            this.lb_salarioCons.Name = "lb_salarioCons";
            this.lb_salarioCons.Size = new System.Drawing.Size(62, 20);
            this.lb_salarioCons.TabIndex = 5;
            this.lb_salarioCons.Text = "Salário:";
            // 
            // tb_valTt
            // 
            this.tb_valTt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tb_valTt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_valTt.Location = new System.Drawing.Point(124, 289);
            this.tb_valTt.Name = "tb_valTt";
            this.tb_valTt.ReadOnly = true;
            this.tb_valTt.Size = new System.Drawing.Size(139, 13);
            this.tb_valTt.TabIndex = 8;
            // 
            // lb_vlTt
            // 
            this.lb_vlTt.AutoSize = true;
            this.lb_vlTt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vlTt.Location = new System.Drawing.Point(38, 285);
            this.lb_vlTt.Name = "lb_vlTt";
            this.lb_vlTt.Size = new System.Drawing.Size(85, 20);
            this.lb_vlTt.TabIndex = 7;
            this.lb_vlTt.Text = "Valor total:";
            // 
            // btn_limparCons
            // 
            this.btn_limparCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparCons.Location = new System.Drawing.Point(357, 326);
            this.btn_limparCons.Name = "btn_limparCons";
            this.btn_limparCons.Size = new System.Drawing.Size(118, 33);
            this.btn_limparCons.TabIndex = 2;
            this.btn_limparCons.Text = "&Limpar";
            this.btn_limparCons.UseVisualStyleBackColor = true;
            this.btn_limparCons.Click += new System.EventHandler(this.btn_limparCons_Click);
            // 
            // btn_fecharCons
            // 
            this.btn_fecharCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fecharCons.Location = new System.Drawing.Point(499, 326);
            this.btn_fecharCons.Name = "btn_fecharCons";
            this.btn_fecharCons.Size = new System.Drawing.Size(118, 33);
            this.btn_fecharCons.TabIndex = 3;
            this.btn_fecharCons.Text = "&Fechar";
            this.btn_fecharCons.UseVisualStyleBackColor = true;
            this.btn_fecharCons.Click += new System.EventHandler(this.btn_fecharCons_Click);
            // 
            // F_calculoSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 374);
            this.Controls.Add(this.btn_fecharCons);
            this.Controls.Add(this.btn_limparCons);
            this.Controls.Add(this.tb_valTt);
            this.Controls.Add(this.lb_vlTt);
            this.Controls.Add(this.tb_salFunCons);
            this.Controls.Add(this.lb_salarioCons);
            this.Controls.Add(this.tb_nomeFuncCons);
            this.Controls.Add(this.lb_nomeFuncCalc);
            this.Controls.Add(this.btn_calcSal);
            this.Controls.Add(this.mtb_cpfCalcSal);
            this.Controls.Add(this.lb_tituloCalcSal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_calculoSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULAR SALÁRIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tituloCalcSal;
        private System.Windows.Forms.MaskedTextBox mtb_cpfCalcSal;
        private System.Windows.Forms.Button btn_calcSal;
        private System.Windows.Forms.Label lb_nomeFuncCalc;
        private System.Windows.Forms.TextBox tb_nomeFuncCons;
        private System.Windows.Forms.TextBox tb_salFunCons;
        private System.Windows.Forms.Label lb_salarioCons;
        private System.Windows.Forms.TextBox tb_valTt;
        private System.Windows.Forms.Label lb_vlTt;
        private System.Windows.Forms.Button btn_limparCons;
        private System.Windows.Forms.Button btn_fecharCons;
    }
}
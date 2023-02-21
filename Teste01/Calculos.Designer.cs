namespace Teste01
{
    partial class Calculos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculos));
            this.label_Titulo = new System.Windows.Forms.Label();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Descricao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Titulo.Location = new System.Drawing.Point(153, 9);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(459, 19);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "Indique as dimensões dos lados do triângulo abaixo";
            this.label_Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(330, 325);
            this.textBox_C.MaxLength = 2;
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(118, 20);
            this.textBox_C.TabIndex = 1;
            this.textBox_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_C_KeyPress);
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(487, 159);
            this.textBox_B.MaxLength = 2;
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(100, 20);
            this.textBox_B.TabIndex = 2;
            this.textBox_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_B_KeyPress);
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(184, 159);
            this.textBox_A.MaxLength = 2;
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 20);
            this.textBox_A.TabIndex = 3;
            this.textBox_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_A_KeyPress);
            // 
            // button_Calcular
            // 
            this.button_Calcular.BackColor = System.Drawing.Color.Green;
            this.button_Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Calcular.FlatAppearance.BorderSize = 0;
            this.button_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Calcular.Location = new System.Drawing.Point(314, 399);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(150, 50);
            this.button_Calcular.TabIndex = 4;
            this.button_Calcular.TabStop = false;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = false;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.Location = new System.Drawing.Point(296, 364);
            this.label_Resultado.MinimumSize = new System.Drawing.Size(184, 16);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(184, 16);
            this.label_Resultado.TabIndex = 5;
            this.label_Resultado.Text = "Digite os valores do triângulo!";
            this.label_Resultado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "C";
            // 
            // button_Descricao
            // 
            this.button_Descricao.Cursor = System.Windows.Forms.Cursors.Help;
            this.button_Descricao.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Descricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Descricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Descricao.Location = new System.Drawing.Point(25, 420);
            this.button_Descricao.Name = "button_Descricao";
            this.button_Descricao.Size = new System.Drawing.Size(80, 29);
            this.button_Descricao.TabIndex = 9;
            this.button_Descricao.Text = "Descrição";
            this.button_Descricao.UseVisualStyleBackColor = true;
            this.button_Descricao.Click += new System.EventHandler(this.button_Descricao_Click);
            // 
            // Calculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 471);
            this.Controls.Add(this.button_Descricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.label_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Triângulo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Descricao;
    }
}


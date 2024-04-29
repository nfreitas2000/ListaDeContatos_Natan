namespace ListaDeContatos_NatanMoraes
{
    partial class Form1
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelCriador = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(3, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(94, 31);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSobrenome.Location = new System.Drawing.Point(3, 63);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(161, 31);
            this.labelSobrenome.TabIndex = 1;
            this.labelSobrenome.Text = "Sobrenome:";
            this.labelSobrenome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.Location = new System.Drawing.Point(3, 126);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(128, 31);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone:";
            this.labelTelefone.Click += new System.EventHandler(this.labelTelefone_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(93, 274);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(269, 82);
            this.buttonSalvar.TabIndex = 3;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 25;
            this.listBoxContatos.Location = new System.Drawing.Point(475, 12);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(313, 404);
            this.listBoxContatos.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelNome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTelefone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSobrenome, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(177, 191);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(218, 37);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(234, 31);
            this.textBoxNome.TabIndex = 7;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSobrenome.Location = new System.Drawing.Point(218, 100);
            this.textBoxSobrenome.Multiline = true;
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(234, 31);
            this.textBoxSobrenome.TabIndex = 8;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefone.Location = new System.Drawing.Point(218, 163);
            this.textBoxTelefone.Multiline = true;
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(234, 31);
            this.textBoxTelefone.TabIndex = 9;
            // 
            // labelCriador
            // 
            this.labelCriador.AutoSize = true;
            this.labelCriador.Location = new System.Drawing.Point(12, 428);
            this.labelCriador.Name = "labelCriador";
            this.labelCriador.Size = new System.Drawing.Size(51, 13);
            this.labelCriador.TabIndex = 10;
            this.labelCriador.Text = "By Natan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCriador);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelCriador;
    }
}



namespace petshop_banco_de_dados
{
    partial class petshop
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
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbEspecie = new System.Windows.Forms.TextBox();
            this.tbPet = new System.Windows.Forms.TextBox();
            this.tbCep = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.dgPetshop = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetshop)).BeginInit();
            this.SuspendLayout();
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(727, 32);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(31, 13);
            this.lb5.TabIndex = 9;
            this.lb5.Text = "CEP:";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(544, 32);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(71, 13);
            this.lb4.TabIndex = 8;
            this.lb4.Text = "Nome do pet:";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(351, 32);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(81, 13);
            this.lb3.TabIndex = 7;
            this.lb3.Text = "Espécie do pet:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(209, 32);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(30, 13);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "CPF:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 32);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(87, 13);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Nome do cliente:";
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(103, 29);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(100, 20);
            this.tbCliente.TabIndex = 10;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(245, 29);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(100, 20);
            this.tbCpf.TabIndex = 11;
            // 
            // tbEspecie
            // 
            this.tbEspecie.Location = new System.Drawing.Point(438, 29);
            this.tbEspecie.Name = "tbEspecie";
            this.tbEspecie.Size = new System.Drawing.Size(100, 20);
            this.tbEspecie.TabIndex = 12;
            // 
            // tbPet
            // 
            this.tbPet.Location = new System.Drawing.Point(621, 29);
            this.tbPet.Name = "tbPet";
            this.tbPet.Size = new System.Drawing.Size(100, 20);
            this.tbPet.TabIndex = 13;
            // 
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(764, 29);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(100, 20);
            this.tbCep.TabIndex = 14;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(103, 69);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 15;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(194, 69);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 16;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // dgPetshop
            // 
            this.dgPetshop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPetshop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCliente,
            this.colCpf,
            this.colEspecie,
            this.colPet,
            this.colCep});
            this.dgPetshop.Location = new System.Drawing.Point(15, 111);
            this.dgPetshop.Name = "dgPetshop";
            this.dgPetshop.Size = new System.Drawing.Size(933, 408);
            this.dgPetshop.TabIndex = 17;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 50;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Width = 250;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.Width = 130;
            // 
            // colEspecie
            // 
            this.colEspecie.HeaderText = "Espécie";
            this.colEspecie.Name = "colEspecie";
            this.colEspecie.Width = 150;
            // 
            // colPet
            // 
            this.colPet.HeaderText = "Pet";
            this.colPet.Name = "colPet";
            this.colPet.Width = 170;
            // 
            // colCep
            // 
            this.colCep.HeaderText = "CEP";
            this.colCep.Name = "colCep";
            this.colCep.Width = 130;
            // 
            // petshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 531);
            this.Controls.Add(this.dgPetshop);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbCep);
            this.Controls.Add(this.tbPet);
            this.Controls.Add(this.tbEspecie);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "petshop";
            this.Text = "PetShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPetshop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbEspecie;
        private System.Windows.Forms.TextBox tbPet;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.DataGridView dgPetshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCep;
    }
}


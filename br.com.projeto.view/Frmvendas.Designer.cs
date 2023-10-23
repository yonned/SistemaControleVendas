namespace Sistema_Controle_Vendas.br.com.projeto.view
{
    partial class Frmvendas
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
            System.Windows.Forms.Button btnpagamento;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.tabelaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            btnpagamento = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpagamento
            // 
            btnpagamento.Location = new System.Drawing.Point(508, 621);
            btnpagamento.Name = "btnpagamento";
            btnpagamento.Size = new System.Drawing.Size(124, 57);
            btnpagamento.TabIndex = 62;
            btnpagamento.Text = "Pagamento";
            btnpagamento.UseVisualStyleBackColor = true;
            btnpagamento.Click += new System.EventHandler(this.btnpagamento_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 154);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(20, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 23);
            this.label.TabIndex = 24;
            this.label.Text = "Data:";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Location = new System.Drawing.Point(87, 26);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(146, 29);
            this.txtdata.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(87, 107);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(291, 29);
            this.txtnome.TabIndex = 23;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // txtcpf
            // 
            this.txtcpf.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpf.Location = new System.Drawing.Point(87, 63);
            this.txtcpf.Mask = "###.###.###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(146, 29);
            this.txtcpf.TabIndex = 21;
            this.txtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtcpf_MaskInputRejected);
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "CPF:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtquantidade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.txtdesc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtpreco);
            this.groupBox2.Location = new System.Drawing.Point(12, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 229);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "QTD:";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(230, 38);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(100, 20);
            this.txtquantidade.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 65;
            this.label2.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 23);
            this.label8.TabIndex = 61;
            this.label8.Text = "Preço (R$)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(122, 32);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(47, 29);
            this.txtcodigo.TabIndex = 66;
            this.txtcodigo.Text = "00";
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(122, 80);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(258, 29);
            this.txtdesc.TabIndex = 60;
            this.txtdesc.TextChanged += new System.EventHandler(this.txtdesc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "Descrição:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtpreco
            // 
            this.txtpreco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreco.Location = new System.Drawing.Point(122, 118);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(258, 29);
            this.txtpreco.TabIndex = 62;
            this.txtpreco.TextChanged += new System.EventHandler(this.txtpreco_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 514);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(186, 84);
            this.btnadd.TabIndex = 59;
            this.btnadd.Text = "Adicionar Item";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(227, 514);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(186, 84);
            this.btnremover.TabIndex = 60;
            this.btnremover.Text = "Remover Item";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // tabelaProdutos
            // 
            this.tabelaProdutos.AccessibleName = "tabelaprodutos";
            this.tabelaProdutos.AllowUserToAddRows = false;
            this.tabelaProdutos.AllowUserToDeleteRows = false;
            this.tabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutos.Location = new System.Drawing.Point(445, 69);
            this.tabelaProdutos.Name = "tabelaProdutos";
            this.tabelaProdutos.ReadOnly = true;
            this.tabelaProdutos.Size = new System.Drawing.Size(720, 443);
            this.tabelaProdutos.TabIndex = 61;
            this.tabelaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaProdutos_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txttotal);
            this.groupBox3.Location = new System.Drawing.Point(445, 523);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 87);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total (R$):";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(125, 36);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(575, 29);
            this.txttotal.TabIndex = 23;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(723, 621);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(124, 57);
            this.btncancelar.TabIndex = 63;
            this.btncancelar.Text = "Remover Item";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 51);
            this.panel1.TabIndex = 56;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(203, 31);
            this.label19.TabIndex = 0;
            this.label19.Text = "Tela de Vendas";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // Frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 682);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(btnpagamento);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabelaProdutos);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmvendas";
            this.Text = "Tela de Vendas";
            this.Load += new System.EventHandler(this.Frmvendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.DataGridView tabelaProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
    }
}
namespace tela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCargo = new TextBox();
            txtDataNascimento = new MaskedTextBox();
            txtDataContato = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTelefone = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            bntSalvar = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnRecarregar = new Button();
            groupBoxUsuario = new GroupBox();
            btnNovoUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(15, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            txtNome.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(193, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(529, 48);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 3;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Location = new Point(15, 194);
            txtDataNascimento.Mask = "00/00/0000";
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(100, 23);
            txtDataNascimento.TabIndex = 7;
            txtDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // txtDataContato
            // 
            txtDataContato.Location = new Point(193, 194);
            txtDataContato.Mask = "00/00/0000";
            txtDataContato.Name = "txtDataContato";
            txtDataContato.Size = new Size(100, 23);
            txtDataContato.TabIndex = 8;
            txtDataContato.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 161);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 10;
            label1.Text = "Data nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 161);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 11;
            label2.Text = "Data de contato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 86);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 12;
            label3.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(347, 119);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 273);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(766, 165);
            dataGridView1.TabIndex = 17;
            // 
            // bntSalvar
            // 
            bntSalvar.Location = new Point(529, 193);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(100, 23);
            bntSalvar.TabIndex = 18;
            bntSalvar.Text = "Salvar";
            bntSalvar.UseVisualStyleBackColor = true;
            bntSalvar.Click += bntSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 86);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 21;
            label4.Text = "Observações";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 19);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 20;
            label5.Text = "Empresa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 86);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 19;
            label6.Text = "Endereço/Cep";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(529, 19);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 24;
            label7.Text = "Cargo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(193, 19);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 23;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 19);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 22;
            label9.Text = "Nome";
            // 
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(679, 244);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(100, 23);
            btnRecarregar.TabIndex = 25;
            btnRecarregar.Text = "recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            // 
            // groupBoxUsuario
            // 
            groupBoxUsuario.Controls.Add(label9);
            groupBoxUsuario.Controls.Add(txtNome);
            groupBoxUsuario.Controls.Add(label7);
            groupBoxUsuario.Controls.Add(txtEmail);
            groupBoxUsuario.Controls.Add(label8);
            groupBoxUsuario.Controls.Add(txtCargo);
            groupBoxUsuario.Controls.Add(txtDataNascimento);
            groupBoxUsuario.Controls.Add(label4);
            groupBoxUsuario.Controls.Add(txtDataContato);
            groupBoxUsuario.Controls.Add(label5);
            groupBoxUsuario.Controls.Add(label1);
            groupBoxUsuario.Controls.Add(label6);
            groupBoxUsuario.Controls.Add(label2);
            groupBoxUsuario.Controls.Add(bntSalvar);
            groupBoxUsuario.Controls.Add(label3);
            groupBoxUsuario.Controls.Add(txtTelefone);
            groupBoxUsuario.Controls.Add(textBox1);
            groupBoxUsuario.Controls.Add(textBox3);
            groupBoxUsuario.Controls.Add(textBox2);
            groupBoxUsuario.Location = new Point(22, 40);
            groupBoxUsuario.Name = "groupBoxUsuario";
            groupBoxUsuario.Size = new Size(651, 227);
            groupBoxUsuario.TabIndex = 26;
            groupBoxUsuario.TabStop = false;
            groupBoxUsuario.Text = "Novo Usuario";
            groupBoxUsuario.Visible = false;
            // 
            // btnNovoUsuario
            // 
            btnNovoUsuario.Location = new Point(22, 11);
            btnNovoUsuario.Name = "btnNovoUsuario";
            btnNovoUsuario.Size = new Size(100, 23);
            btnNovoUsuario.TabIndex = 25;
            btnNovoUsuario.Text = "NovoUsuario";
            btnNovoUsuario.UseVisualStyleBackColor = true;
            btnNovoUsuario.Click += btnNovoUsuario_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNovoUsuario);
            Controls.Add(groupBoxUsuario);
            Controls.Add(btnRecarregar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxUsuario.ResumeLayout(false);
            groupBoxUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCargo;
        private MaskedTextBox txtDataNascimento;
        private MaskedTextBox txtDataContato;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTelefone;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button bntSalvar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnRecarregar;
        private GroupBox groupBoxUsuario;
        private Button btnNovoUsuario;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}
namespace AdvAbc
{
    partial class x
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
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtEndereco = new TextBox();
            txtCargo = new TextBox();
            txtEmpresa = new TextBox();
            ttObservacao = new TextBox();
            btnSalvar = new Button();
            txtNascimento = new MaskedTextBox();
            txtDataDeContato = new MaskedTextBox();
            Data = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(247, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            txtNome.Text = "Nome";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(415, 73);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 2;
            txtTelefone.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(583, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "E-mail";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(69, 147);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(100, 23);
            txtEndereco.TabIndex = 4;
            txtEndereco.Text = "Endereço";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(247, 218);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(100, 23);
            txtCargo.TabIndex = 6;
            txtCargo.Text = "Cargo";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(415, 218);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(100, 23);
            txtEmpresa.TabIndex = 7;
            txtEmpresa.Text = "Empresa";
            // 
            // ttObservacao
            // 
            ttObservacao.Location = new Point(415, 147);
            ttObservacao.Name = "ttObservacao";
            ttObservacao.Size = new Size(100, 23);
            ttObservacao.TabIndex = 8;
            ttObservacao.Text = "Observações";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(568, 218);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 23);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtNascimento
            // 
            txtNascimento.Location = new Point(249, 152);
            txtNascimento.Mask = "00/00/0000";
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(100, 23);
            txtNascimento.TabIndex = 10;
            txtNascimento.ValidatingType = typeof(DateTime);
            // 
            // txtDataDeContato
            // 
            txtDataDeContato.Location = new Point(69, 218);
            txtDataDeContato.Mask = "00/00/0000";
            txtDataDeContato.Name = "txtDataDeContato";
            txtDataDeContato.Size = new Size(100, 23);
            txtDataDeContato.TabIndex = 11;
            txtDataDeContato.ValidatingType = typeof(DateTime);
            // 
            // Data
            // 
            Data.AutoSize = true;
            Data.Location = new Point(67, 192);
            Data.Name = "Data";
            Data.Size = new Size(91, 15);
            Data.TabIndex = 12;
            Data.Text = "Data de contato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 119);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 13;
            label1.Text = "Data de nascimento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(69, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 34);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 15;
            label2.Text = "Selecionar usuario";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(614, 176);
            dataGridView1.TabIndex = 16;
            // 
            // x
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(txtEndereco);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmpresa);
            Controls.Add(label1);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(ttObservacao);
            Controls.Add(Data);
            Controls.Add(txtNascimento);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtDataDeContato);
            Name = "x";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtEndereco;
        private TextBox txtCargo;
        private TextBox txtEmpresa;
        private TextBox ttObservacao;
        private Button btnSalvar;
        private MaskedTextBox txtNascimento;
        private MaskedTextBox txtDataDeContato;
        private Label Data;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private GroupBox groupBox1;
    }
}
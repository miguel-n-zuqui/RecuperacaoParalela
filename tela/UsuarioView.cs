using database.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace tela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            txtCargo.Clear();
            groupBoxUsuario.Visible = !groupBoxUsuario.Visible;

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            Button? botao = sender as Button;

            var nome = txtCargo.Text;
            var status = chkStatus.Checked;
            var novoCargo = new Cargo(nome, status);


            var erros = Validacoes.getValidationErros(novoCargo);
            foreach (var erro in erros) { MessageBox.Show(erro.ErrorMessage); }



            switch (botao.Text)
            {
                case "Atualizar":
                    {
                        UsuarioRepository.Incluir(novoCargo);

                        var resultado = _cargoRepository.Incluir(novoCargo);

                        if (resultado)
                        {
                            MessageBox.Show("Cargo cadastrado com sucesso!!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel gravar o cargo!!");
                        }
                        //cadastar
                        break;
                    }
                case "Salvar":
                    {
                        //_cargoRepository.Atualizar(novoCargo, id);
                        MessageBox.Show("Cargo alterado com sucesso!!");
                        //cadastar
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
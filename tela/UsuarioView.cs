using database.Repository;
using negocio.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace tela
{
    public partial class UsuarioView : Form
    {
        public UsuarioView()
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

            var nome = txtNome.Text;
            var telefone = txtTelefone.Text;
            var email = txtEmail.Text;
            var endereco = txtEndereco.Text;
            DateTime nascimento = Convert.ToDateTime(txtDataNascimento.Text);
            var novoUsuario = new Usuarios(nome, telefone, email, endereco, nascimento);







            switch (botao.Text)
            {
                case "Atualizar":
                    {


                        var resultado = UsuarioRepository.Inserir(novoUsuario);

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

        private void UsuarioView_Load(object sender, EventArgs e)
        {
            InformacoesTabelaCargo();
        }
        private void InformacoesTabelaCargo()
        {
            var usuarioRepositorio = new UsuarioRepository();

            var obterTodos = usuarioRepositorio.ObterTodos();

            gvUsuarios.DataSource = obterTodos;
        }

        private void gvUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = gvUsuarios.Rows[e.RowIndex];
            var cargoRepository = new UsuarioRepository();

            if (gvUsuarios.Columns[e.ColumnIndex].Name == "Deletar")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resulatdo = cargoRepository.Deletar(Convert.ToInt32(row.Cells[1].Value));
                    MessageBox.Show("Registro deletado com sucesso!");
                };
                return;
            }
        }
    }
}
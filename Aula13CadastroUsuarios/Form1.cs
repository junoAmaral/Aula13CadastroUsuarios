namespace Aula13CadastroUsuarios
{
    public partial class Form1 : Form
    {
        //VARI�VEIS GLOBAIS
        List<Pessoa> pessoas = new List<Pessoa>();

        //M�TODO CONSTRUTOR

        public Form1()
        {
            InitializeComponent();
        }

        //FUN��ES
        public void atualizaInterface()
        {
            for (int i = 0; i < pessoas.Count; i++) 
            {
                listView1.Items.Add(pessoas[i].nome);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);
            string endereco = txtEndere�o.Text;
            string cidade = txtCidade.Text;

            Pessoa pessoa = new Pessoa(nome, idade, endereco, cidade);
            pessoas.Add(pessoa);
            atualizaInterface();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace Provas
{
    public partial class ConsultaProva : Form
    {
        string conexao = @"Server=localhost;Database=Prova;Uid=root;Pwd=''";
        MySqlConnection msConnection = new MySqlConnection();
        MySqlCommand msCommand = new MySqlCommand();

        public ConsultaProva()
        {
            InitializeComponent();
        }

        private void consultarDados(int? codigo = null, string nome = null)
        {
            DataTable dt = new DataTable();
            msConnection.ConnectionString = conexao;
            msConnection.Open();
            MySqlCommand msCommand = new MySqlCommand();

            if (codigo != null && nome != null)
            {
                msCommand.CommandText = "select * from teste where codigo=" + txtCodigo.Text + " and nome ='" + txtNome.Text + "'";
            }
            else if (codigo != null)
            {
                msCommand.CommandText = "select * from teste where codigo=" + txtCodigo.Text;
            }
            else if (nome != null)
            {
                msCommand.CommandText = "select * from teste where nome ='" + txtNome.Text + "'";
            }
            else
            {
                msCommand.CommandText = "select * from teste";
            }

            msCommand.Connection = msConnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
            msdAdapter.Fill(dt);

            dgvConsulta.DataSource = dt;
            msConnection.Close();

        }
        private void ConsultaProva_Load(object sender, EventArgs e)
        {
            consultarProva();
            consultarAno();
        }
        private void consultarProva()
        {
            DataTable dt = new DataTable();
            msConnection.ConnectionString = conexao;
            msConnection.Open();
            MySqlCommand msCommand = new MySqlCommand();
            msCommand.CommandText = "select distinct Nome from Prova;";

            msCommand.Connection = msConnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
            msdAdapter.Fill(dt);

            cboProva.DataSource = dt;
            cboProva.DisplayMember = "Nome";
            cboProva.ValueMember = "Nome";

            msConnection.Close();

        }

        private void consultarAno()
        {
            DataTable dt = new DataTable();
            msConnection.ConnectionString = conexao;
            msConnection.Open();
            MySqlCommand msCommand = new MySqlCommand();
            msCommand.CommandText = "select distinct Ano from Prova;";

            msCommand.Connection = msConnection;
            MySqlDataAdapter msdAdapter = new MySqlDataAdapter(msCommand);
            msdAdapter.Fill(dt);

            cboAno.DataSource = dt;
            cboAno.DisplayMember = "Ano";
            cboAno.ValueMember = "Ano";

            msConnection.Close();
        }

        
        private void btnPesquisar_Click(object sender, EventArgs e)
        {           
            if(cboAno.Text != "" && cboProva.Text != "")
            {
                consultarAno(int.Parse(cboAno.Text), cboProva.Text);
            }
           else if(cboAno.Text != "")
            {
                consultarProva(int.Parse(cboAno.Text));
            }
            else if(cboProva.Text !="")
            {
                consultarProva(null,cboProva.Text);
            }
            else
            {
                consultarProva();
            }
        }
    }
}

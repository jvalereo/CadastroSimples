using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using CadastroSimples.Classe.Cadastro;

namespace CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Projeto - Sistema Básico de Cadastro Simples
        //Sistema, cadastrar enviar dados para o banco de dados
        //Jonas Valereo - Técnico em Informática
        //Data: 15/02/2013

        // recuperar dados do id
        int id_usar = 0;
 

        // Criação de objeto ,para gravar, alterar excluir ...
        // Dados de Cadastro
        Cadastro ca = new Cadastro();

        //button enviar
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            //validar textbox nome, sobrenome, celular

            //validar nome
            if (TextBoxNome.Text == "")
            {
                MessageBox.Show(" Preencha campo nome!!!","Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TextBoxNome.BackColor = Color.Aqua;
                TextBoxNome.Focus();

                return ;
            }

            //valida sobrenome
            if(TextBoxSobrenome.Text == "")
            {
                MessageBox.Show(" Preencha campo sobrenome!!!", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TextBoxSobrenome.BackColor = Color.Aqua;
                TextBoxSobrenome.Focus();

                return;
            }

            //valida celular
            if(MaskedTextBoxCelular.Text.Trim().Length != 15)
            {
                MessageBox.Show(" Preencha campo celular!!!", "Mensagem", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                MaskedTextBoxCelular.BackColor = Color.Aqua;
                MaskedTextBoxCelular.Focus();

                return;
            }

            //conexao com o bando de dados
            int retornograva = 0;

            retornograva = ca.gravaDados(TextBoxNome.Text, 
                TextBoxSobrenome.Text, MaskedTextBoxCelular.Text
                 
               );

            if(retornograva > 0)
            {
                MessageBox.Show("Cadastro realizdo com sucesso...", "Gravando dados...");
                DataGridViewDados.DataSource = ca.carregaGrid();
                //limpar as textbox, simular cancelar
                LimparTela();
            }
            else
            {
                MessageBox.Show("Erro ao realiza o cadastro...", "Gravando dados...");
            }
        }

        //button alterar
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            //conexao com o bando de dados
            int retornoAltera = 0;
            retornoAltera = ca.alteraDados(id_usar, TextBoxNome.Text,
                TextBoxSobrenome.Text, MaskedTextBoxCelular.Text
                );
            if (retornoAltera > 0)
            {
                MessageBox.Show("Cadastro alterado com sucesso...", "Alterando dados");
                DataGridViewDados.DataSource = ca.carregaGrid();
                LimparTela();
            }
        }

        //button excluir
        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            //conexao com o bando de dados
            int excluir = 0;

            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir esse cadastro?",
                "Questionado exclusão", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                excluir = ca.excluirDados(int.Parse(DataGridViewDados.CurrentRow.Cells[0].Value.ToString()));

                if(excluir > 0)
                {
                    MessageBox.Show("Cadastro excluido com sucesso...", "Exclusão do cadastro");
                    DataGridViewDados.DataSource = ca.carregaGrid();
                    LimparTela();
                }
            }
        }

        //button fechar
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            //fecha aplicação
            Close();
        }

        //DataGridDados
        private void DataGridViewDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            id_usar = int.Parse(DataGridViewDados.CurrentRow.Cells[0].Value.ToString());
            TextBoxNome.Text = DataGridViewDados.CurrentRow.Cells[1].Value.ToString();
            TextBoxSobrenome.Text = DataGridViewDados.CurrentRow.Cells[2].Value.ToString();
            MaskedTextBoxCelular.Text = DataGridViewDados.CurrentRow.Cells[3].Value.ToString();
        }

        ////metodo limpar as textbox, tela 
        public void LimparTela()
        {
            TextBoxId.Clear();
            TextBoxNome.Clear();
            TextBoxSobrenome.Clear();
            MaskedTextBoxCelular.Clear();
            TextBoxNome.BackColor = Color.White;
            TextBoxSobrenome.BackColor = Color.White;
            MaskedTextBoxCelular.BackColor = Color.White;
            TextBoxNome.Focus();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string strnome=Microsoft.VisualBasic.Interaction.InputBox("Digite o nome de pesquisa");
            
            DataGridViewDados.DataSource = ca.carregaGridPesquisa(strnome);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            DataGridViewDados.Columns.Clear();
            LimparTela();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'formularioDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
        }

        //fim da aplicação 
    }
}

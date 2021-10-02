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

namespace petshop_banco_de_dados
{
    public partial class petshop : Form
    {
        public petshop()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "petshop";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void limpar()
        {
            tbCliente.Clear();
            tbCpf.Clear();
            tbEspecie.Clear();
            tbPet.Clear();
            tbCep.Clear();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM cliente";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgPetshop.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgPetshop.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME DO CLIENTE
                    row.Cells[2].Value = reader.GetString(2);//CPF
                    row.Cells[3].Value = reader.GetString(3);//ESPECIE
                    row.Cells[4].Value = reader.GetString(4);//NOME DO PET
                    row.Cells[5].Value = reader.GetString(5);//CEP
                    dgPetshop.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO cliente (nomeCliente,cpfCliente,especiepetCliente,nomepetCliente, cepCliente) " +
                    "VALUES('" + tbCliente.Text + "', '" + tbCpf.Text + "','" + tbEspecie.Text + "', '" + tbPet.Text + "', '" + tbCep.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limpar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

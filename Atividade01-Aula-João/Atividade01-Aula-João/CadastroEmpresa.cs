using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atividade01_Aula_João

{
    public partial class CadastroEmpresa : Form
    {
        private object cnpj;

        public CadastroEmpresa()
        {

            InitializeComponent();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textnome.Text) ||
                String.IsNullOrEmpty(textBox2.Text) ||
                String.IsNullOrEmpty(maskedTextBox1.Text) ||
                String.IsNullOrEmpty(comboBox1.Text) ||
                String.IsNullOrEmpty(groupBox3.Text) ||
                String.IsNullOrEmpty(maskedTextBox2.Text) ||
                String.IsNullOrEmpty(maskedTextBox3.Text) ||
                String.IsNullOrEmpty(textBox8.Text) ||
                String.IsNullOrEmpty(textBox9.Text) ||
                String.IsNullOrEmpty(comboBox3.Text) ||
                String.IsNullOrEmpty(comboBox2.Text) ||
                String.IsNullOrEmpty(groupBox1.Text) ||
                String.IsNullOrEmpty(groupBox2.Text) ||
                String.IsNullOrEmpty(maskedTextBox2.Text) ||
                String.IsNullOrEmpty(groupBox2.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Empresa novoEmpresa = new Empresa();
                {
                    novoEmpresa.nomeFantasia = textnome.Text;
                    novoEmpresa.nomeProprietario = textBox13.Text;
                    novoEmpresa.razaoSocial = textBox2.Text;
                    novoEmpresa.cnpj = maskedTextBox1.Text;
                    novoEmpresa.situacaoCadastral = comboBox1.Text;
                    novoEmpresa.cpfProprietario = textBox8.Text;
                    novoEmpresa.telefone = maskedTextBox3.Text;
                    novoEmpresa.capitalSocial = textBox8.Text;
                    novoEmpresa.endereco = textBox9.Text;
                    novoEmpresa.estado = comboBox3.Text;
                    novoEmpresa.naturezaJuridica = comboBox2.Text;
                    novoEmpresa.tipo = groupBox1.Text;
                    novoEmpresa.data = maskedTextBox2.Text;
                    novoEmpresa.porte = groupBox1.Text;
                    novoEmpresa.regime = groupBox3.Text;

                }
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show($"CNPJ = {maskedTextBox1.Text}\n"
                    + $"Razão Social:{textBox2.Text}\n"
                    + $"Nome Fatasia:{textnome.Text}\n"
                    + $"Situação:{comboBox1.Text}\n"
                    + $"Regime Tributário:{groupBox3.Text}\n"
                    + $"Data de iníco:{maskedTextBox2.Text}\n"
                    + $"Telefone:{maskedTextBox3.Text}\n"
                    + $"estado:{comboBox3.Text}\n"
                    + $"estado: {comboBox3.Text}\n"
                    + $"Tipo:{groupBox1.Text}\n"
                    + $"Porte da Empresa:{groupBox1.Text}\n"
                    + $"Juridica:{textBox8.Text}\n"
                    + $"Propreteratio:{textBox8.Text}\n"
                    + $"Cpf do propretério:{textBox13.Text}\n");
            }





        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

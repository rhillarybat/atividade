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
                    novoEmpresa.cpfProprietario = textBox14.Text;
                    novoEmpresa.telefone = maskedTextBox3.Text;
                    novoEmpresa.capitalSocial = textBox8.Text;
                    novoEmpresa.endereco = textBox9.Text;
                    novoEmpresa.estado = comboBox3.Text;
                    novoEmpresa.naturezaJuridica = comboBox2.Text;
                    novoEmpresa.tipo = groupBox1.Text;
                    novoEmpresa.data = maskedTextBox2.Text;
                    novoEmpresa.porte = groupBox2.Text;
                    novoEmpresa.regime = groupBox3.Text;

                }
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show($"CNPJ = {cnpj}\n"
                    + $"Razão Social:{razao}\n"
                    + $"Nome Fatasia:{nomeFantasia}\n"
                    + $"Situação:{Situacao}\n"
                    + $"Regime Tributário:{regimetri}\n"
                    + $"Data de iníco:{datainicio}\n"
                    + $"Telefone:{telefone}\n"
                    + $"Capital:{capital}\n"
                    + $"Endereço:{endereço}\n"
                    + $"Tipo:{tipo}\n"
                    + $"Porte da Empresa:{porteempresa}\n"
                    + $"Juridica:{juridica}\n"
                    + $"Propreteratio:{propretario}\n"
                    + $"Cpf do propretério:{cpfpropretario}\n");
            }





        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

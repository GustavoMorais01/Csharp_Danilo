using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_23_windows_form
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;

            try
            {
                
                int numero = int.Parse(txtNumero.Text); // Fazendo o casting, colocar int.Parse();

                //Convert.ToInt16(txtNumero); Conversão para string pode ser feita assim tambem
                // Converter qualquer objeto em alguma coisa

                if (numero == 2)
                {
                    throw new ErroDeProposito("Erro de propósito");
                }

                if (numero == 4)
                {
                    throw new Exception ("Erro de propósito genérico");
                }

                numero = numero + 100;
                MessageBox.Show("E ai camarada!\n" + nome + " O Número mais 100 é: " + numero);
            }

            catch (FormatException errFormat)
            {
                MessageBox.Show("Você digitou errado caralho!!!");
                txtNumero.Focus();// Volta o cursor no campo numero para o usuário digitar novamente
            }

            catch (ErroDeProposito errProposito)
            {
                MessageBox.Show("Erro de propósito - " + errProposito.StackTrace);
            }

            // O catch da Classe Exception tem que ficar por ultimo por todo mundo herda dele
            catch (Exception)
            {
                MessageBox.Show("Ola Cliente! Você pode ter digitado o numero errado!!!");
            }

            finally
            {
                MessageBox.Show("Todas as exceções foram tratadas");
            }
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Máscara completa!");
            }
            else
            {
                MessageBox.Show("Máscara incompleta!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estou buscando no banco de dados com o termo: " + txtBucaTool.Text);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }

    public class ErroDeProposito : Exception
    {
        public ErroDeProposito(string erro) : base(erro)
        {

        }
    }



}

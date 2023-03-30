using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace loginsenha
{
    public partial class Form1 : Form
    {
        Thread nt; //criação da Thead como 'se fosse variável'
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Adimn" && textBoxSenha.Text == "123456")
            {
                //MessageBox.Show("Bem vindo ao sistema!", "acesso ao Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Apenas para criar sistema com usuário cadastrado
                this.Close();//fecha o primeiro formulário e já vai para o segundo formulário
                nt = new Thread(novoformulario);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

            }
            else
            {
                MessageBox.Show("Acesso Negado", "Acesso Negado !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void novoformulario()
        {
            //throw new NotImplementedException(); código criado pois apenas vamos chamar o novo formulário e instâncialo -
            Application.Run(new Formlogin());
        }
    }
}

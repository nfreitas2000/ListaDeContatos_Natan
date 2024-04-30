using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListaDeContatos_NatanMoraes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ClassContato[] listaDeContatos = new ClassContato[1];

        private void Escrever(ClassContato contato) 
        {
            StreamWriter escrever = new StreamWriter("Contatos.txt");

            escrever.WriteLine(listaDeContatos.Length + 1);
            escrever.WriteLine(contato.Nome);
            escrever.WriteLine(contato.Sobrenome);
            escrever.WriteLine(contato.Telefone);

            for (int x = 0; x < listaDeContatos.Length; x++) 
            {
                escrever.WriteLine(listaDeContatos[x].Nome);
                escrever.WriteLine(listaDeContatos[x].Sobrenome);
                escrever.WriteLine(listaDeContatos[x].Telefone);
            }
            escrever. Close();
        }

        private void Ler() 
        {
            StreamReader ler = new StreamReader("Contato.txt");

            listaDeContatos = new ClassContato[Convert.ToInt32(ler.ReadLine())];
        }


        private void labelTelefone_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ClassContato contato = new ClassContato();

            contato.Nome = textBoxNome.Text;
            contato.Sobrenome = textBoxSobrenome.Text;
            contato.Telefone = textBoxTelefone.Text;

            listBoxContatos.Items.Add(contato.ToString());
        }

        private void textBoxSobrenome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

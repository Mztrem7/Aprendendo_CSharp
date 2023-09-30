using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuBlocoDeNotas
{
    public partial class Form1 : Form
    {

        bool alterado;
        private OpenFileDialog abrirDialogo;

        public Form1()
        {
            InitializeComponent();
        }



        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alterado == true)
            {
                
            }
        }

        private void abrirArquivo()
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialogAbrir.ShowDialog() == DialogResult.OK)
            {
                //Coloca nome no Arquivo
                this.Text = openFileDialogAbrir.FileName;
                //Adiciona o conteudo no Richtextbox 
                using (StreamReader reader = new StreamReader(openFileDialogAbrir.OpenFile()))
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
            }
            else
            {

            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            alterado = true;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

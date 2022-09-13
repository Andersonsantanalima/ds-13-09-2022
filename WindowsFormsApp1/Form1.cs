using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        List<Filme> listFilme = new List<Filme>();

        private void carregardg()
        {
            dataGridView1.Rows.Clear();
            foreach(Filme filme in listFilme)
            {
                dataGridView1.Rows.Add(filme.nome,filme.ano,filme.avaliacao,filme.like? "👍":"( ͠° ͟ʖ ͡°)",filme.comentario);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme(txtNome.Text, Convert.ToInt32(txtAno.Text), Convert.ToInt32(cbAvaliacao.Text), chckLike.Checked, txtComentario.Text);
            listFilme.Add(filme);
            carregardg();
        }
    }
}
//    string nome =    txtNome.Text;
//    int ano =        Convert.ToInt32(txtAno.Text);
//    int avaliacao =   Convert.ToInt32(cbAvaliacao.Text);
//    bool like =        chckLike.Checked;
//    string comentario = txtComentario.Text;
//    Filme filme = new Filme(nome,ano,avaliacao,like,comentario)
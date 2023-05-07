﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsletterBlob.View
{
    public partial class JanelaOpcoesAutor : Form
    {
        private string identificador;
        public JanelaOpcoesAutor()
        {
            InitializeComponent();
        }

        public JanelaOpcoesAutor(string identificador)
        {
            this.identificador = identificador;
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            new JanelaPrincipal(identificador, true).Show();
            this.Hide();
        }

        private void btnMinhaConta_Click(object sender, EventArgs e)
        {
            new JanelaContaUsuario(identificador, true).Show();
            this.Hide();
        }

        private void btnCriarPublicacao_Click(object sender, EventArgs e)
        {
            new JanelaCadastrarNoticias().Show();
            this.Hide();
        }

        private void btnEditarPublicacao_Click(object sender, EventArgs e)
        {
            new JanelaNoticiasAutor().Show();
            this.Hide();
        }
    }
}

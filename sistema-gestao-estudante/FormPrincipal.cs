﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao_estudante
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void estudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaerEstudantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserirEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudante inserirEstudante = new FormInserirEstudante();
            inserirEstudante.Show(this);
        }
    }
}

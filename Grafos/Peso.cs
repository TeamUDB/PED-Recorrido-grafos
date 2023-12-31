﻿using System;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Peso : Form
    {
        public bool control; // variable de control
        public string dato; // el dato que almacenará el vértice

        public Peso()
        {
            InitializeComponent();
            control = false;
            dato = "";
        }

        private void Vertice_Load(object sender, EventArgs e)
        {
            txtPeso.Focus();
        }

        private void Vertice_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Vertice_Shown(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtPeso.Focus();
        }

        private void txtVertice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(null, null);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string valor = txtPeso.Text.ToUpper().Trim();
            if ((valor == "") || (valor == " "))
            {
                MessageBox.Show("Debes ingresar un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                control = true;
                Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            control = false;
            Hide();
        }
    }
}

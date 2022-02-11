using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace typingTest
{
    public partial class frmSequencias : Form
    {

        #region Variáveis
            public static int indexSequencia = 0;
            public static string stringSequencia = "iop";
        #endregion

        #region Construtores
            public frmSequencias()
            {
                InitializeComponent();
            }
        #endregion

        #region Page Load
            private void frmSequencias_Load(object sender, EventArgs e)
            {
                //cbSequencias.SelectedIndex = indexSequencia;
            }
        #endregion

        #region Botão Selecionar
            private void btnSelecionar_Click(object sender, EventArgs e)
            {
                if (cbSequencias.SelectedIndex < 0) { return; }
                indexSequencia = cbSequencias.SelectedIndex;
                stringSequencia = cbSequencias.SelectedItem.ToString();
                Close();
            }
        #endregion

        #region Botão Criar
            private void btnCriar_Click(object sender, EventArgs e)
            {
                if ( txtNovaSequencia.Text == "" )
                {
                    return;
                }
                string novaSequencia = txtNovaSequencia.Text;
                txtNovaSequencia.Clear();
                cbSequencias.Items.Add(novaSequencia);
            }
        #endregion
    }
}

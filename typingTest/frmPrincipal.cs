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
    public partial class frmPrincipal : Form
    {

        #region Variáveis
            private object[,] erros = null;
            private int nSequencia = 0;
            private int vSequencias = 0;
        #endregion

        #region Construtores
            public frmPrincipal()
            {
                InitializeComponent();
            }
        #endregion

        #region Botão Limpar
            private void btnLimpar_Click(object sender, EventArgs e)
            {
                lstOcorrencias.Items.Clear();
                rtbTeclas.Clear();
                rtbTeclas.Focus();
                lblTeclaPress.Text = "-";
            }
        #endregion

        #region Botão editar sequência
            private void editarSequênciaToolStripMenuItem_Click(object sender, EventArgs e)
            {
                frmSequencias frmSequencias = new frmSequencias();
                if (frmSequencias.ShowDialog() == DialogResult.Cancel)
                {
                    txtSequencia_Leave(sender, e);
                    txtSequencia.Focus();
                }
            }
        #endregion

        #region Quando uma tecla é pressionada com o foco na caixa de texto
            private void rtbTeclas_KeyDown(object sender, KeyEventArgs e)
            {
                lblTeclaPress.Text = e.KeyCode.ToString();
                lstOcorrencias.Items.Add(e.KeyCode.ToString());
                if (lstOcorrencias.Items.Count == 38) { lstOcorrencias.Items.Clear(); }
            }
        #endregion

        #region Escrever sequência
            private void txtSequencia_KeyDown(object sender, KeyEventArgs e)
            {
                rtbTeclas_KeyDown(sender, e);
                if (nSequencia == frmSequencias.stringSequencia.Length)
                {
                    nSequencia = 0;
                    pbSequencia.Value = 0;
                    txtSequencia.Clear();
                    vSequencias++;
                    lstErros.Items[0] = "Sequências: " + vSequencias;
                }
                if (e.KeyCode.ToString() == erros[nSequencia, 0].ToString().ToUpper())
                {
                    pbSequencia.Value++; nSequencia++;
                }
                else
                {
                    try
                    {
                        if (e.KeyCode.ToString() == erros[(nSequencia - 1), 0].ToString().ToUpper())
                        {
                            //Adiciona o erro
                            erros[(nSequencia - 1), 1] = int.Parse(erros[(nSequencia - 1), 1].ToString()) + 1;
                            lstErros.Items[nSequencia] = erros[(nSequencia - 1), 0] + ": " + erros[(nSequencia - 1), 1];
                            return;
                        }
                    }
                    catch
                    {
                        nSequencia = 2;
                        pbSequencia.Value = 2;
                        txtSequencia.Clear();
                        //Adiciona o erro
                        erros[0, 1] = int.Parse(erros[0, 1].ToString()) + 1;
                        lstErros.Items[1] = erros[0, 0] + ": " + erros[0, 1];
                        return;
                    }
                    try
                    {
                        if (e.KeyCode.ToString() == erros[(nSequencia + 1), 0].ToString().ToUpper())
                        {
                            //Adiciona o erro
                            erros[nSequencia, 1] = int.Parse(erros[nSequencia, 1].ToString()) + 1;
                            lstErros.Items[nSequencia + 1] = erros[nSequencia, 0] + ": " + erros[nSequencia, 1];
                            pbSequencia.Value += 2; nSequencia += 2;
                            return;
                        }
                    }
                    catch
                    {
                        nSequencia = 1;
                        pbSequencia.Value = 1;
                        txtSequencia.Clear();
                        vSequencias++;
                        lstErros.Items[0] = "Sequências: " + vSequencias;
                        //Adiciona o erro
                        erros[(erros.Length / 2 - 1), 1] = int.Parse(erros[(erros.Length / 2 - 1), 1].ToString()) + 1;
                        lstErros.Items[(erros.Length / 2)] = erros[(erros.Length / 2 - 1), 0] + ": " + erros[(erros.Length / 2 - 1), 1];
                        return;
                    }
                }
            }
        #endregion

        #region PageLoad
        private void frmPrincipal_Load(object sender, EventArgs e)
            {
                pbSequencia.Maximum = frmSequencias.stringSequencia.Length;
            }
        #endregion

        #region Quando o foco sai da caixa de texto sequência
            private void txtSequencia_Leave(object sender, EventArgs e)
            {
                vSequencias = 0;
                nSequencia = 0;
                pbSequencia.Value = 0;
                txtSequencia.Clear();
                lstErros.Items.Clear();
            }
        #endregion

        #region Quando a caixa de texto sequência recebe o foco
            private void txtSequencia_Enter(object sender, EventArgs e)
            {
                int n = 0;
                lstErros.Items.Add("Sequências: 0");
                erros = new object[frmSequencias.stringSequencia.Length, 2];
                pbSequencia.Maximum = erros.Length / 2;
                foreach (char letra in frmSequencias.stringSequencia)
                {
                    erros[n, 0] = frmSequencias.stringSequencia.Substring(n, 1);
                    erros[n, 1] = 0;
                    lstErros.Items.Add(erros[n, 0] + ": 0");
                    n++;
                }
            }
        #endregion

    }
}

namespace typingTest
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbTeclas = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pbSequencia = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSequencia = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sequênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarSequênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTeclaPress = new System.Windows.Forms.Label();
            this.lstOcorrencias = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstErros = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTeclas
            // 
            this.rtbTeclas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTeclas.Location = new System.Drawing.Point(12, 76);
            this.rtbTeclas.Name = "rtbTeclas";
            this.rtbTeclas.Size = new System.Drawing.Size(719, 228);
            this.rtbTeclas.TabIndex = 0;
            this.rtbTeclas.Text = "";
            this.rtbTeclas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbTeclas_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto livre";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(587, 310);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 36);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pbSequencia
            // 
            this.pbSequencia.Location = new System.Drawing.Point(12, 433);
            this.pbSequencia.Name = "pbSequencia";
            this.pbSequencia.Size = new System.Drawing.Size(144, 36);
            this.pbSequencia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sequência";
            // 
            // txtSequencia
            // 
            this.txtSequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSequencia.Location = new System.Drawing.Point(12, 391);
            this.txtSequencia.Multiline = true;
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Size = new System.Drawing.Size(144, 36);
            this.txtSequencia.TabIndex = 5;
            this.txtSequencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSequencia.Enter += new System.EventHandler(this.txtSequencia_Enter);
            this.txtSequencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSequencia_KeyDown);
            this.txtSequencia.Leave += new System.EventHandler(this.txtSequencia_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sequênciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sequênciaToolStripMenuItem
            // 
            this.sequênciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarSequênciaToolStripMenuItem});
            this.sequênciaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sequênciaToolStripMenuItem.Name = "sequênciaToolStripMenuItem";
            this.sequênciaToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.sequênciaToolStripMenuItem.Text = "Sequências";
            // 
            // editarSequênciaToolStripMenuItem
            // 
            this.editarSequênciaToolStripMenuItem.Name = "editarSequênciaToolStripMenuItem";
            this.editarSequênciaToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.editarSequênciaToolStripMenuItem.Text = "Gerenciar";
            this.editarSequênciaToolStripMenuItem.Click += new System.EventHandler(this.editarSequênciaToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tecla presionada:";
            // 
            // lblTeclaPress
            // 
            this.lblTeclaPress.AutoSize = true;
            this.lblTeclaPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeclaPress.Location = new System.Drawing.Point(153, 318);
            this.lblTeclaPress.Name = "lblTeclaPress";
            this.lblTeclaPress.Size = new System.Drawing.Size(14, 20);
            this.lblTeclaPress.TabIndex = 7;
            this.lblTeclaPress.Text = "-";
            // 
            // lstOcorrencias
            // 
            this.lstOcorrencias.FormattingEnabled = true;
            this.lstOcorrencias.Location = new System.Drawing.Point(746, 76);
            this.lstOcorrencias.Name = "lstOcorrencias";
            this.lstOcorrencias.Size = new System.Drawing.Size(224, 498);
            this.lstOcorrencias.TabIndex = 8;
            this.lstOcorrencias.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(746, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ocorrências";
            // 
            // lstErros
            // 
            this.lstErros.FormattingEnabled = true;
            this.lstErros.Location = new System.Drawing.Point(162, 391);
            this.lstErros.Name = "lstErros";
            this.lstErros.Size = new System.Drawing.Size(144, 186);
            this.lstErros.TabIndex = 10;
            this.lstErros.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Info";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 584);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstErros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstOcorrencias);
            this.Controls.Add(this.lblTeclaPress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSequencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSequencia);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbTeclas);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typing Test";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTeclas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ProgressBar pbSequencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSequencia;
        private System.Windows.Forms.ToolStripMenuItem sequênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarSequênciaToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTeclaPress;
        private System.Windows.Forms.ListBox lstOcorrencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lstErros;
        private System.Windows.Forms.Label label5;
    }
}


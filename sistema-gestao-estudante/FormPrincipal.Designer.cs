namespace sistema_gestao_estudante
{
    partial class FormPrincipal
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
            this.estudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaerEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // estudanteToolStripMenuItem
            // 
            this.estudanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEstudanteToolStripMenuItem,
            this.listaerEstudantesToolStripMenuItem,
            this.estatisticasToolStripMenuItem,
            this.gerenciarEstudantesToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.imprimirToolStripMenuItem1});
            this.estudanteToolStripMenuItem.Name = "estudanteToolStripMenuItem";
            this.estudanteToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.estudanteToolStripMenuItem.Text = "Estudante";
            this.estudanteToolStripMenuItem.Click += new System.EventHandler(this.estudanteToolStripMenuItem_Click);
            // 
            // inserirEstudanteToolStripMenuItem
            // 
            this.inserirEstudanteToolStripMenuItem.Name = "inserirEstudanteToolStripMenuItem";
            this.inserirEstudanteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.inserirEstudanteToolStripMenuItem.Text = "Inserir Estudante ";
            this.inserirEstudanteToolStripMenuItem.Click += new System.EventHandler(this.inserirEstudanteToolStripMenuItem_Click);
            // 
            // listaerEstudantesToolStripMenuItem
            // 
            this.listaerEstudantesToolStripMenuItem.Name = "listaerEstudantesToolStripMenuItem";
            this.listaerEstudantesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listaerEstudantesToolStripMenuItem.Text = "Listar Estudantes ";
            this.listaerEstudantesToolStripMenuItem.Click += new System.EventHandler(this.listaerEstudantesToolStripMenuItem_Click);
            // 
            // estatisticasToolStripMenuItem
            // 
            this.estatisticasToolStripMenuItem.Name = "estatisticasToolStripMenuItem";
            this.estatisticasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.estatisticasToolStripMenuItem.Text = "Estatisticas ";
            // 
            // gerenciarEstudantesToolStripMenuItem
            // 
            this.gerenciarEstudantesToolStripMenuItem.Name = "gerenciarEstudantesToolStripMenuItem";
            this.gerenciarEstudantesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gerenciarEstudantesToolStripMenuItem.Text = "Editar/Remover";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.imprimirToolStripMenuItem.Text = "GerenciarEstudantes";
            // 
            // imprimirToolStripMenuItem1
            // 
            this.imprimirToolStripMenuItem1.Name = "imprimirToolStripMenuItem1";
            this.imprimirToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.imprimirToolStripMenuItem1.Text = "Imprimir";
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cursoToolStripMenuItem.Text = "Curso";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudanteToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(316, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 373);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem estudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaerEstudantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEstudantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}
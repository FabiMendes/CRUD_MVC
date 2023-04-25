namespace CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.UI
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmsPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsListarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsPrincipal,
            this.tmsAjuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
           // this.pictureBox1.Image = global::CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.Properties.Resources.lain_cover;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tmsPrincipal
            // 
            this.tmsPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsCadastrarUsuario,
            this.tmsListarUsuarios});
            this.tmsPrincipal.Name = "tmsPrincipal";
            this.tmsPrincipal.Size = new System.Drawing.Size(65, 20);
            this.tmsPrincipal.Text = "Principal";
            // 
            // tmsAjuda
            // 
            this.tmsAjuda.Name = "tmsAjuda";
            this.tmsAjuda.Size = new System.Drawing.Size(50, 20);
            this.tmsAjuda.Text = "Ajuda";
            // 
            // tmsCadastrarUsuario
            // 
            this.tmsCadastrarUsuario.Name = "tmsCadastrarUsuario";
            this.tmsCadastrarUsuario.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tmsCadastrarUsuario.Size = new System.Drawing.Size(209, 22);
            this.tmsCadastrarUsuario.Text = "Cadastrar Usuário";
            // 
            // tmsListarUsuarios
            // 
            this.tmsListarUsuarios.Name = "tmsListarUsuarios";
            this.tmsListarUsuarios.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tmsListarUsuarios.Size = new System.Drawing.Size(209, 22);
            this.tmsListarUsuarios.Text = "Listar Usuários";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tmsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tmsCadastrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem tmsListarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tmsAjuda;
    }
}
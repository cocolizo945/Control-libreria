using System.ComponentModel;

namespace Control_libreria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.strpadminusers = new System.Windows.Forms.ToolStripMenuItem();
            this.subStripRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAdminlibros = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAudito = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvGen = new System.Windows.Forms.DataGridView();
            this.btnlogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.strpadminusers, this.stripAdminlibros, this.stripAudito });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // strpadminusers
            // 
            this.strpadminusers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.subStripRegistrar, this.administrarUsuariosToolStripMenuItem });
            this.strpadminusers.Name = "strpadminusers";
            this.strpadminusers.Size = new System.Drawing.Size(163, 20);
            this.strpadminusers.Text = "Administracion de usuarios";
            // 
            // subStripRegistrar
            // 
            this.subStripRegistrar.Name = "subStripRegistrar";
            this.subStripRegistrar.Size = new System.Drawing.Size(183, 22);
            this.subStripRegistrar.Text = "Registrar";
            this.subStripRegistrar.Click += new System.EventHandler(this.subStripRegistrar_Click);
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar usuarios";
            this.administrarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administrarUsuariosToolStripMenuItem_Click);
            // 
            // stripAdminlibros
            // 
            this.stripAdminlibros.Name = "stripAdminlibros";
            this.stripAdminlibros.Size = new System.Drawing.Size(155, 20);
            this.stripAdminlibros.Text = "Administracion de libreria";
            // 
            // stripAudito
            // 
            this.stripAudito.Name = "stripAudito";
            this.stripAudito.Size = new System.Drawing.Size(68, 20);
            this.stripAudito.Text = "Auditoria";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvGen);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 423);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // dgvGen
            // 
            this.dgvGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGen.Location = new System.Drawing.Point(0, 0);
            this.dgvGen.Name = "dgvGen";
            this.dgvGen.Size = new System.Drawing.Size(776, 423);
            this.dgvGen.TabIndex = 0;
            this.dgvGen.Visible = false;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(713, 480);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "cerrar sesion";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnlogout;

        private System.Windows.Forms.DataGridView dgvGen;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem subStripRegistrar;

        private System.Windows.Forms.ToolStripMenuItem strpadminusers;
        private System.Windows.Forms.ToolStripMenuItem stripAdminlibros;
        private System.Windows.Forms.ToolStripMenuItem stripAudito;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}
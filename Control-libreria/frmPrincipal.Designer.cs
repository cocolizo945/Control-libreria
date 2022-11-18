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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvGen = new System.Windows.Forms.DataGridView();
            this.btnlogout = new System.Windows.Forms.Button();
            this.strpadminusers = new System.Windows.Forms.ToolStripMenuItem();
            this.subStripRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAdminlibros = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nacionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripAudito = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bntCreate = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvGen);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 423);
            this.panel1.TabIndex = 1;
            // 
            // dgvGen
            // 
            this.dgvGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGen.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvGen.Location = new System.Drawing.Point(0, 0);
            this.dgvGen.Name = "dgvGen";
            this.dgvGen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGen.Size = new System.Drawing.Size(1070, 423);
            this.dgvGen.TabIndex = 0;
            this.dgvGen.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGen_CellContentDoubleClick);
            this.dgvGen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvGen_KeyPress);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(973, 544);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(94, 47);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "cerrar sesion";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
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
            this.stripAdminlibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.autoresToolStripMenuItem, this.librosToolStripMenuItem, this.temasToolStripMenuItem, this.nacionalidadToolStripMenuItem, this.editorialesToolStripMenuItem });
            this.stripAdminlibros.Name = "stripAdminlibros";
            this.stripAdminlibros.Size = new System.Drawing.Size(155, 20);
            this.stripAdminlibros.Text = "Administracion de libreria";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.temasToolStripMenuItem.Text = "Temas";
            this.temasToolStripMenuItem.Click += new System.EventHandler(this.temasToolStripMenuItem_Click);
            // 
            // nacionalidadToolStripMenuItem
            // 
            this.nacionalidadToolStripMenuItem.Name = "nacionalidadToolStripMenuItem";
            this.nacionalidadToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nacionalidadToolStripMenuItem.Text = "Nacionalidad";
            this.nacionalidadToolStripMenuItem.Click += new System.EventHandler(this.nacionalidadToolStripMenuItem_Click);
            // 
            // editorialesToolStripMenuItem
            // 
            this.editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            this.editorialesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.editorialesToolStripMenuItem.Text = "Editoriales";
            this.editorialesToolStripMenuItem.Click += new System.EventHandler(this.editorialesToolStripMenuItem_Click);
            // 
            // stripAudito
            // 
            this.stripAudito.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.auditoriaToolStripMenuItem, this.eliminadosToolStripMenuItem });
            this.stripAudito.Name = "stripAudito";
            this.stripAudito.Size = new System.Drawing.Size(68, 20);
            this.stripAudito.Text = "Auditoria";
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            this.auditoriaToolStripMenuItem.Click += new System.EventHandler(this.auditoriaToolStripMenuItem_Click);
            // 
            // eliminadosToolStripMenuItem
            // 
            this.eliminadosToolStripMenuItem.Name = "eliminadosToolStripMenuItem";
            this.eliminadosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.eliminadosToolStripMenuItem.Text = "Eliminados";
            this.eliminadosToolStripMenuItem.Click += new System.EventHandler(this.eliminadosToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.strpadminusers, this.stripAdminlibros, this.stripAudito });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 476);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(145, 23);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Id";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Visible = false;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(163, 479);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(122, 20);
            this.txt1.TabIndex = 7;
            this.txt1.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(892, 544);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 47);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // bntCreate
            // 
            this.bntCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCreate.Location = new System.Drawing.Point(892, 479);
            this.bntCreate.Name = "bntCreate";
            this.bntCreate.Size = new System.Drawing.Size(75, 47);
            this.bntCreate.TabIndex = 23;
            this.bntCreate.Text = "Ingresar";
            this.bntCreate.UseVisualStyleBackColor = true;
            this.bntCreate.Click += new System.EventHandler(this.bntCreate_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(973, 479);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 47);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(800, 544);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(86, 47);
            this.btnClean.TabIndex = 24;
            this.btnClean.Text = "Imprimir";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 603);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.bntCreate);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnClean;

        private System.Windows.Forms.Button bntCreate;
        private System.Windows.Forms.Button btnBorrar;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.TextBox txt1;

        private System.Windows.Forms.Label lbl1;

        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminadosToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem editorialesToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem temasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nacionalidadToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;

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
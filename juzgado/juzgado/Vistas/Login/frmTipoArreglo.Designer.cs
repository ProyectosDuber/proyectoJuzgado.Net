namespace juzgado.Vistas.Login
{
    partial class frmTipoArreglo
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
            this.components = new System.ComponentModel.Container();
            this.menuCrud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeArreglo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuGuardar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTipoArreglos = new System.Windows.Forms.DataGridView();
            this.objeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCrud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuGuardar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoArreglos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuCrud
            // 
            this.menuCrud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.menuCrud.Name = "contextMenuStrip1";
            this.menuCrud.Size = new System.Drawing.Size(118, 70);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::juzgado.Properties.Resources._1452634100_file_add;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Nuevo";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::juzgado.Properties.Resources._20;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Editar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Image = global::juzgado.Properties.Resources.no;
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // tipoDeArreglo
            // 
            this.tipoDeArreglo.HeaderText = "Tipo De Arreglo";
            this.tipoDeArreglo.Name = "tipoDeArreglo";
            this.tipoDeArreglo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tipoDeArreglo});
            this.dataGridView1.ContextMenuStrip = this.menuCrud;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(593, 562);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // menuGuardar
            // 
            this.menuGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuGuardar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cancelarToolStripMenuItem});
            this.menuGuardar.Name = "menuGuardar";
            this.menuGuardar.Size = new System.Drawing.Size(121, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::juzgado.Properties.Resources.green_ok;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem1.Text = "Guardar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Image = global::juzgado.Properties.Resources.no;
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // dgvTipoArreglos
            // 
            this.dgvTipoArreglos.AllowUserToAddRows = false;
            this.dgvTipoArreglos.AllowUserToDeleteRows = false;
            this.dgvTipoArreglos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoArreglos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoArreglos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoArreglos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objeto,
            this.nombre});
            this.dgvTipoArreglos.ContextMenuStrip = this.menuCrud;
            this.dgvTipoArreglos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoArreglos.Location = new System.Drawing.Point(191, 0);
            this.dgvTipoArreglos.MultiSelect = false;
            this.dgvTipoArreglos.Name = "dgvTipoArreglos";
            this.dgvTipoArreglos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoArreglos.Size = new System.Drawing.Size(593, 562);
            this.dgvTipoArreglos.TabIndex = 3;
            this.dgvTipoArreglos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoArreglos_CellContentClick);
            this.dgvTipoArreglos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipoArreglos_CellMouseDown);
            // 
            // objeto
            // 
            this.objeto.HeaderText = "ID";
            this.objeto.Name = "objeto";
            this.objeto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Tipo De Arreglo";
            this.nombre.MaxInputLength = 20;
            this.nombre.Name = "nombre";
            // 
            // frmTipoArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvTipoArreglos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmTipoArreglo";
            this.Text = "frmTipoArreglo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTipoArreglo_FormClosed);
            this.Controls.SetChildIndex(this.dgvTipoArreglos, 0);
            this.menuCrud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuGuardar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoArreglos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuCrud;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeArreglo;
        private System.Windows.Forms.ContextMenuStrip menuGuardar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvTipoArreglos;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn objeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}
namespace juzgado.Vistas.Login
{
    partial class frmTiposDeProcesos
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
            this.dgvTipoProcesos = new System.Windows.Forms.DataGridView();
            this.objeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuCrud = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuardar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCancelar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProcesos)).BeginInit();
            this.menuCrud.SuspendLayout();
            this.menuGuardar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTipoProcesos
            // 
            this.dgvTipoProcesos.AllowUserToAddRows = false;
            this.dgvTipoProcesos.AllowUserToDeleteRows = false;
            this.dgvTipoProcesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoProcesos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objeto,
            this.nombre});
            this.dgvTipoProcesos.ContextMenuStrip = this.menuCrud;
            this.dgvTipoProcesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoProcesos.Location = new System.Drawing.Point(191, 0);
            this.dgvTipoProcesos.MultiSelect = false;
            this.dgvTipoProcesos.Name = "dgvTipoProcesos";
            this.dgvTipoProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoProcesos.Size = new System.Drawing.Size(593, 562);
            this.dgvTipoProcesos.TabIndex = 4;
            this.dgvTipoProcesos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipoProcesos_CellMouseDown);
            // 
            // objeto
            // 
            this.objeto.HeaderText = "ID";
            this.objeto.Name = "objeto";
            this.objeto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Tipos De Procesos";
            this.nombre.MaxInputLength = 20;
            this.nombre.Name = "nombre";
            // 
            // menuCrud
            // 
            this.menuCrud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo,
            this.tsEditar,
            this.tsEliminar});
            this.menuCrud.Name = "contextMenuStrip1";
            this.menuCrud.Size = new System.Drawing.Size(118, 70);
            // 
            // tsNuevo
            // 
            this.tsNuevo.Image = global::juzgado.Properties.Resources._1452634100_file_add;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(117, 22);
            this.tsNuevo.Text = "Nuevo";
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // tsEditar
            // 
            this.tsEditar.Image = global::juzgado.Properties.Resources._20;
            this.tsEditar.Name = "tsEditar";
            this.tsEditar.Size = new System.Drawing.Size(117, 22);
            this.tsEditar.Text = "Editar";
            this.tsEditar.Click += new System.EventHandler(this.tsEditar_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.Image = global::juzgado.Properties.Resources.no;
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(117, 22);
            this.tsEliminar.Text = "Eliminar";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // menuGuardar
            // 
            this.menuGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuGuardar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGuardar,
            this.tsCancelar});
            this.menuGuardar.Name = "menuGuardar";
            this.menuGuardar.Size = new System.Drawing.Size(121, 48);
            // 
            // tsGuardar
            // 
            this.tsGuardar.Image = global::juzgado.Properties.Resources.green_ok;
            this.tsGuardar.Name = "tsGuardar";
            this.tsGuardar.Size = new System.Drawing.Size(120, 22);
            this.tsGuardar.Text = "Guardar";
            this.tsGuardar.Click += new System.EventHandler(this.tsGuardar_Click);
            // 
            // tsCancelar
            // 
            this.tsCancelar.Image = global::juzgado.Properties.Resources.no;
            this.tsCancelar.Name = "tsCancelar";
            this.tsCancelar.Size = new System.Drawing.Size(120, 22);
            this.tsCancelar.Text = "Cancelar";
            this.tsCancelar.Click += new System.EventHandler(this.tsCancelar_Click);
            // 
            // frmTiposDeProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dgvTipoProcesos);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmTiposDeProcesos";
            this.Text = "frmTiposDeProcesos";
            this.Load += new System.EventHandler(this.frmTiposDeProcesos_Load);
            this.Controls.SetChildIndex(this.dgvTipoProcesos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProcesos)).EndInit();
            this.menuCrud.ResumeLayout(false);
            this.menuGuardar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn objeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.ContextMenuStrip menuGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsCancelar;
        private System.Windows.Forms.ContextMenuStrip menuCrud;
        private System.Windows.Forms.ToolStripMenuItem tsNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsEditar;
        private System.Windows.Forms.ToolStripMenuItem tsEliminar;
    }
}
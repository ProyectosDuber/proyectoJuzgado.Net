namespace juzgado.Vistas.Login
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mTiposArreglo = new System.Windows.Forms.ToolStripMenuItem();
            this.mTiposProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.mUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mProcesosJudiciales = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.BackgroundImage = global::juzgado.Properties.Resources.panel;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mTiposArreglo,
            this.mTiposProceso,
            this.mUsuarios,
            this.mProcesosJudiciales});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(191, 562);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mTiposArreglo
            // 
            this.mTiposArreglo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mTiposArreglo.Name = "mTiposArreglo";
            this.mTiposArreglo.Size = new System.Drawing.Size(178, 29);
            this.mTiposArreglo.Text = "Tipos De Arreglo";
            this.mTiposArreglo.Click += new System.EventHandler(this.hola1ToolStripMenuItem_Click);
            // 
            // mTiposProceso
            // 
            this.mTiposProceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mTiposProceso.Name = "mTiposProceso";
            this.mTiposProceso.Size = new System.Drawing.Size(178, 29);
            this.mTiposProceso.Text = "Tipos De Proceso";
            this.mTiposProceso.Click += new System.EventHandler(this.mTiposProceso_Click);
            // 
            // mUsuarios
            // 
            this.mUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mUsuarios.Name = "mUsuarios";
            this.mUsuarios.Size = new System.Drawing.Size(178, 29);
            this.mUsuarios.Text = "Usuarios";
            this.mUsuarios.Click += new System.EventHandler(this.mUsuarios_Click);
            // 
            // mProcesosJudiciales
            // 
            this.mProcesosJudiciales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mProcesosJudiciales.Name = "mProcesosJudiciales";
            this.mProcesosJudiciales.Size = new System.Drawing.Size(178, 29);
            this.mProcesosJudiciales.Text = "Procesos Judiciales";
            this.mProcesosJudiciales.Click += new System.EventHandler(this.mProcesosJudiciales_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripMenuItem mTiposArreglo;
        private System.Windows.Forms.ToolStripMenuItem mTiposProceso;
        private System.Windows.Forms.ToolStripMenuItem mUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mProcesosJudiciales;
        private System.Windows.Forms.MenuStrip menu;



    }
}
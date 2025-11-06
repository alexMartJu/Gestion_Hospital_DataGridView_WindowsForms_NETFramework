namespace GestorHospitalario
{
    partial class frmIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripIngresos = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripIngresos = new System.Windows.Forms.ToolStrip();
            this.btnAgregarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.splitContainerIngresos = new System.Windows.Forms.SplitContainer();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblNombrePaciente = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.menuStripIngresos.SuspendLayout();
            this.toolStripIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIngresos)).BeginInit();
            this.splitContainerIngresos.Panel1.SuspendLayout();
            this.splitContainerIngresos.Panel2.SuspendLayout();
            this.splitContainerIngresos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripIngresos
            // 
            this.menuStripIngresos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ingresosToolStripMenuItem});
            this.menuStripIngresos.Location = new System.Drawing.Point(0, 0);
            this.menuStripIngresos.Name = "menuStripIngresos";
            this.menuStripIngresos.Size = new System.Drawing.Size(800, 24);
            this.menuStripIngresos.TabIndex = 1;
            this.menuStripIngresos.Text = "menuStripIngresos";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripIngresos
            // 
            this.toolStripIngresos.AutoSize = false;
            this.toolStripIngresos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarToolStrip,
            this.toolStripSeparator1,
            this.btnEditarToolStrip,
            this.toolStripSeparator2,
            this.btnEliminarToolStrip});
            this.toolStripIngresos.Location = new System.Drawing.Point(0, 24);
            this.toolStripIngresos.Name = "toolStripIngresos";
            this.toolStripIngresos.Size = new System.Drawing.Size(800, 40);
            this.toolStripIngresos.TabIndex = 2;
            this.toolStripIngresos.Text = "toolStripIngresos";
            // 
            // btnAgregarToolStrip
            // 
            this.btnAgregarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarToolStrip.Image")));
            this.btnAgregarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarToolStrip.Name = "btnAgregarToolStrip";
            this.btnAgregarToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnAgregarToolStrip.Text = "Añadir Ingreso";
            this.btnAgregarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarToolStrip.Click += new System.EventHandler(this.btnAgregarToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnEditarToolStrip
            // 
            this.btnEditarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarToolStrip.Image")));
            this.btnEditarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarToolStrip.Name = "btnEditarToolStrip";
            this.btnEditarToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnEditarToolStrip.Text = "Editar Ingreso";
            this.btnEditarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarToolStrip.Click += new System.EventHandler(this.btnEditarToolStrip_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnEliminarToolStrip
            // 
            this.btnEliminarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarToolStrip.Image")));
            this.btnEliminarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarToolStrip.Name = "btnEliminarToolStrip";
            this.btnEliminarToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnEliminarToolStrip.Text = "Eliminar Ingreso";
            this.btnEliminarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarToolStrip.Click += new System.EventHandler(this.btnEliminarToolStrip_Click);
            // 
            // splitContainerIngresos
            // 
            this.splitContainerIngresos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerIngresos.Location = new System.Drawing.Point(0, 64);
            this.splitContainerIngresos.Name = "splitContainerIngresos";
            this.splitContainerIngresos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerIngresos.Panel1
            // 
            this.splitContainerIngresos.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainerIngresos.Panel1.Controls.Add(this.lblInfo);
            this.splitContainerIngresos.Panel1.Controls.Add(this.lblNombrePaciente);
            this.splitContainerIngresos.Panel1.Controls.Add(this.btnEliminar);
            this.splitContainerIngresos.Panel1.Controls.Add(this.btnEditar);
            this.splitContainerIngresos.Panel1.Controls.Add(this.btnAgregar);
            this.splitContainerIngresos.Panel1.Controls.Add(this.lblPaciente);
            // 
            // splitContainerIngresos.Panel2
            // 
            this.splitContainerIngresos.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainerIngresos.Panel2.Controls.Add(this.dgvIngresos);
            this.splitContainerIngresos.Size = new System.Drawing.Size(800, 386);
            this.splitContainerIngresos.SplitterDistance = 113;
            this.splitContainerIngresos.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInfo.Location = new System.Drawing.Point(195, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(407, 30);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Ingresos del paciente seleccionado";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AutoSize = true;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePaciente.Location = new System.Drawing.Point(24, 56);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.Size = new System.Drawing.Size(134, 17);
            this.lblNombrePaciente.TabIndex = 4;
            this.lblNombrePaciente.Text = "Nombre del Paciente:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(626, 56);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar ingreso";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(470, 56);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 40);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar ingreso";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(314, 56);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 40);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Añadir ingreso";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.Location = new System.Drawing.Point(24, 79);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(137, 17);
            this.lblPaciente.TabIndex = 0;
            this.lblPaciente.Text = "Nombre del Paciente";
            // 
            // dgvIngresos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvIngresos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIngresos.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngresos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngresos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIngresos.EnableHeadersVisualStyles = false;
            this.dgvIngresos.Location = new System.Drawing.Point(4, 3);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvIngresos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngresos.Size = new System.Drawing.Size(789, 259);
            this.dgvIngresos.TabIndex = 0;
            // 
            // frmIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerIngresos);
            this.Controls.Add(this.toolStripIngresos);
            this.Controls.Add(this.menuStripIngresos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Hospital - Ingresos del Paciente";
            this.menuStripIngresos.ResumeLayout(false);
            this.menuStripIngresos.PerformLayout();
            this.toolStripIngresos.ResumeLayout(false);
            this.toolStripIngresos.PerformLayout();
            this.splitContainerIngresos.Panel1.ResumeLayout(false);
            this.splitContainerIngresos.Panel1.PerformLayout();
            this.splitContainerIngresos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIngresos)).EndInit();
            this.splitContainerIngresos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripIngresos;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripIngresos;
        private System.Windows.Forms.ToolStripButton btnAgregarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminarToolStrip;
        private System.Windows.Forms.SplitContainer splitContainerIngresos;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.DataGridView dgvIngresos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombrePaciente;
        private System.Windows.Forms.Label lblInfo;
    }
}
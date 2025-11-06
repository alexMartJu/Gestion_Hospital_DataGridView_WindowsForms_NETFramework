namespace GestorHospitalario
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.btnAgregarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVerIngresosToolStrip = new System.Windows.Forms.ToolStripButton();
            this.splitContainerPrincipal = new System.Windows.Forms.SplitContainer();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnVerIngresos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.panelTotalPacientes = new System.Windows.Forms.Panel();
            this.lblTituloPacientes = new System.Windows.Forms.Label();
            this.lblValorPacientes = new System.Windows.Forms.Label();
            this.lblTituloEdadMedia = new System.Windows.Forms.Label();
            this.panelEdadMedia = new System.Windows.Forms.Panel();
            this.lblValorEdadMedia = new System.Windows.Forms.Label();
            this.panelTotalIngresos = new System.Windows.Forms.Panel();
            this.lblValorIngresos = new System.Windows.Forms.Label();
            this.lblTituloTotalIngresos = new System.Windows.Forms.Label();
            this.lblValorActivos = new System.Windows.Forms.Label();
            this.lblTituloIngresosActivos = new System.Windows.Forms.Label();
            this.panelIngresosActivos = new System.Windows.Forms.Panel();
            this.menuStripPrincipal.SuspendLayout();
            this.toolStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).BeginInit();
            this.splitContainerPrincipal.Panel1.SuspendLayout();
            this.splitContainerPrincipal.Panel2.SuspendLayout();
            this.splitContainerPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.panelTotalPacientes.SuspendLayout();
            this.panelEdadMedia.SuspendLayout();
            this.panelTotalIngresos.SuspendLayout();
            this.panelIngresosActivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.pacientesToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStripPrincipal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.verIngresosToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // verIngresosToolStripMenuItem
            // 
            this.verIngresosToolStripMenuItem.Name = "verIngresosToolStripMenuItem";
            this.verIngresosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.verIngresosToolStripMenuItem.Text = "Ver Ingresos";
            this.verIngresosToolStripMenuItem.Click += new System.EventHandler(this.verIngresosToolStripMenuItem_Click);
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.AutoSize = false;
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarToolStrip,
            this.toolStripSeparator1,
            this.btnEditarToolStrip,
            this.toolStripSeparator2,
            this.btnEliminarToolStrip,
            this.toolStripSeparator3,
            this.btnVerIngresosToolStrip});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 24);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Size = new System.Drawing.Size(800, 40);
            this.toolStripPrincipal.TabIndex = 1;
            this.toolStripPrincipal.Text = "toolStripPrincipal";
            // 
            // btnAgregarToolStrip
            // 
            this.btnAgregarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarToolStrip.Image")));
            this.btnAgregarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarToolStrip.Name = "btnAgregarToolStrip";
            this.btnAgregarToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnAgregarToolStrip.Text = "Agregar Paciente";
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
            this.btnEditarToolStrip.Text = "Editar Pacientes";
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
            this.btnEliminarToolStrip.Text = "Eliminar Paciente";
            this.btnEliminarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminarToolStrip.Click += new System.EventHandler(this.btnEliminarToolStrip_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // btnVerIngresosToolStrip
            // 
            this.btnVerIngresosToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVerIngresosToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnVerIngresosToolStrip.Image")));
            this.btnVerIngresosToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVerIngresosToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerIngresosToolStrip.Name = "btnVerIngresosToolStrip";
            this.btnVerIngresosToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnVerIngresosToolStrip.Text = "Ver Ingresos";
            this.btnVerIngresosToolStrip.Click += new System.EventHandler(this.btnVerIngresosToolStrip_Click);
            // 
            // splitContainerPrincipal
            // 
            this.splitContainerPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPrincipal.Location = new System.Drawing.Point(0, 64);
            this.splitContainerPrincipal.Name = "splitContainerPrincipal";
            this.splitContainerPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPrincipal.Panel1
            // 
            this.splitContainerPrincipal.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblTituloIngresosActivos);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.panelIngresosActivos);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.panelTotalIngresos);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblTituloTotalIngresos);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblTituloEdadMedia);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.panelEdadMedia);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblTituloPacientes);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.panelTotalPacientes);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.lblInfo);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.btnVerIngresos);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.btnEliminar);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.btnEditar);
            this.splitContainerPrincipal.Panel1.Controls.Add(this.btnAgregar);
            // 
            // splitContainerPrincipal.Panel2
            // 
            this.splitContainerPrincipal.Panel2.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainerPrincipal.Panel2.Controls.Add(this.dgvPacientes);
            this.splitContainerPrincipal.Size = new System.Drawing.Size(800, 469);
            this.splitContainerPrincipal.SplitterDistance = 186;
            this.splitContainerPrincipal.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInfo.Location = new System.Drawing.Point(195, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(407, 30);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Gestión de pacientes hospitalarios";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVerIngresos
            // 
            this.btnVerIngresos.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVerIngresos.FlatAppearance.BorderSize = 0;
            this.btnVerIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerIngresos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerIngresos.ForeColor = System.Drawing.Color.Black;
            this.btnVerIngresos.Location = new System.Drawing.Point(610, 58);
            this.btnVerIngresos.Name = "btnVerIngresos";
            this.btnVerIngresos.Size = new System.Drawing.Size(150, 40);
            this.btnVerIngresos.TabIndex = 3;
            this.btnVerIngresos.Text = "Ver Ingresos";
            this.btnVerIngresos.UseVisualStyleBackColor = false;
            this.btnVerIngresos.Click += new System.EventHandler(this.btnVerIngresos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(417, 58);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Paciente";
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
            this.btnEditar.Location = new System.Drawing.Point(224, 58);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 40);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar Paciente";
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
            this.btnAgregar.Location = new System.Drawing.Point(31, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 40);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Paciente";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle51;
            this.dgvPacientes.EnableHeadersVisualStyles = false;
            this.dgvPacientes.Location = new System.Drawing.Point(3, 3);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.White;
            this.dgvPacientes.RowsDefaultCellStyle = dataGridViewCellStyle52;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(789, 269);
            this.dgvPacientes.TabIndex = 0;
            // 
            // panelTotalPacientes
            // 
            this.panelTotalPacientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTotalPacientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalPacientes.Controls.Add(this.lblValorPacientes);
            this.panelTotalPacientes.Location = new System.Drawing.Point(70, 132);
            this.panelTotalPacientes.Name = "panelTotalPacientes";
            this.panelTotalPacientes.Size = new System.Drawing.Size(70, 47);
            this.panelTotalPacientes.TabIndex = 5;
            // 
            // lblTituloPacientes
            // 
            this.lblTituloPacientes.AutoSize = true;
            this.lblTituloPacientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPacientes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTituloPacientes.Location = new System.Drawing.Point(55, 114);
            this.lblTituloPacientes.Name = "lblTituloPacientes";
            this.lblTituloPacientes.Size = new System.Drawing.Size(102, 15);
            this.lblTituloPacientes.TabIndex = 6;
            this.lblTituloPacientes.Text = "Total de Pacientes";
            this.lblTituloPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorPacientes
            // 
            this.lblValorPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorPacientes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPacientes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblValorPacientes.Location = new System.Drawing.Point(0, 0);
            this.lblValorPacientes.Name = "lblValorPacientes";
            this.lblValorPacientes.Size = new System.Drawing.Size(68, 45);
            this.lblValorPacientes.TabIndex = 0;
            this.lblValorPacientes.Text = "0";
            this.lblValorPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloEdadMedia
            // 
            this.lblTituloEdadMedia.AutoSize = true;
            this.lblTituloEdadMedia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEdadMedia.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTituloEdadMedia.Location = new System.Drawing.Point(263, 114);
            this.lblTituloEdadMedia.Name = "lblTituloEdadMedia";
            this.lblTituloEdadMedia.Size = new System.Drawing.Size(69, 15);
            this.lblTituloEdadMedia.TabIndex = 8;
            this.lblTituloEdadMedia.Text = "Edad Media";
            this.lblTituloEdadMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEdadMedia
            // 
            this.panelEdadMedia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEdadMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdadMedia.Controls.Add(this.lblValorEdadMedia);
            this.panelEdadMedia.Location = new System.Drawing.Point(263, 132);
            this.panelEdadMedia.Name = "panelEdadMedia";
            this.panelEdadMedia.Size = new System.Drawing.Size(70, 47);
            this.panelEdadMedia.TabIndex = 7;
            // 
            // lblValorEdadMedia
            // 
            this.lblValorEdadMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorEdadMedia.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorEdadMedia.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblValorEdadMedia.Location = new System.Drawing.Point(0, 0);
            this.lblValorEdadMedia.Name = "lblValorEdadMedia";
            this.lblValorEdadMedia.Size = new System.Drawing.Size(68, 45);
            this.lblValorEdadMedia.TabIndex = 0;
            this.lblValorEdadMedia.Text = "0";
            this.lblValorEdadMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTotalIngresos
            // 
            this.panelTotalIngresos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTotalIngresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotalIngresos.Controls.Add(this.lblValorIngresos);
            this.panelTotalIngresos.Location = new System.Drawing.Point(456, 132);
            this.panelTotalIngresos.Name = "panelTotalIngresos";
            this.panelTotalIngresos.Size = new System.Drawing.Size(70, 47);
            this.panelTotalIngresos.TabIndex = 9;
            // 
            // lblValorIngresos
            // 
            this.lblValorIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorIngresos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorIngresos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblValorIngresos.Location = new System.Drawing.Point(0, 0);
            this.lblValorIngresos.Name = "lblValorIngresos";
            this.lblValorIngresos.Size = new System.Drawing.Size(68, 45);
            this.lblValorIngresos.TabIndex = 0;
            this.lblValorIngresos.Text = "0";
            this.lblValorIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloTotalIngresos
            // 
            this.lblTituloTotalIngresos.AutoSize = true;
            this.lblTituloTotalIngresos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalIngresos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTituloTotalIngresos.Location = new System.Drawing.Point(443, 114);
            this.lblTituloTotalIngresos.Name = "lblTituloTotalIngresos";
            this.lblTituloTotalIngresos.Size = new System.Drawing.Size(96, 15);
            this.lblTituloTotalIngresos.TabIndex = 10;
            this.lblTituloTotalIngresos.Text = "Total de Ingresos";
            this.lblTituloTotalIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorActivos
            // 
            this.lblValorActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValorActivos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorActivos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblValorActivos.Location = new System.Drawing.Point(0, 0);
            this.lblValorActivos.Name = "lblValorActivos";
            this.lblValorActivos.Size = new System.Drawing.Size(68, 45);
            this.lblValorActivos.TabIndex = 0;
            this.lblValorActivos.Text = "0";
            this.lblValorActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloIngresosActivos
            // 
            this.lblTituloIngresosActivos.AutoSize = true;
            this.lblTituloIngresosActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIngresosActivos.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTituloIngresosActivos.Location = new System.Drawing.Point(638, 114);
            this.lblTituloIngresosActivos.Name = "lblTituloIngresosActivos";
            this.lblTituloIngresosActivos.Size = new System.Drawing.Size(93, 15);
            this.lblTituloIngresosActivos.TabIndex = 12;
            this.lblTituloIngresosActivos.Text = "Ingresos Activos";
            this.lblTituloIngresosActivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelIngresosActivos
            // 
            this.panelIngresosActivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIngresosActivos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIngresosActivos.Controls.Add(this.lblValorActivos);
            this.panelIngresosActivos.Location = new System.Drawing.Point(649, 132);
            this.panelIngresosActivos.Name = "panelIngresosActivos";
            this.panelIngresosActivos.Size = new System.Drawing.Size(70, 47);
            this.panelIngresosActivos.TabIndex = 11;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.splitContainerPrincipal);
            this.Controls.Add(this.toolStripPrincipal);
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Hospital - Lista de Pacientes";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.splitContainerPrincipal.Panel1.ResumeLayout(false);
            this.splitContainerPrincipal.Panel1.PerformLayout();
            this.splitContainerPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).EndInit();
            this.splitContainerPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.panelTotalPacientes.ResumeLayout(false);
            this.panelEdadMedia.ResumeLayout(false);
            this.panelTotalIngresos.ResumeLayout(false);
            this.panelIngresosActivos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripPrincipal;
        private System.Windows.Forms.ToolStripButton btnAgregarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEliminarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnVerIngresosToolStrip;
        private System.Windows.Forms.SplitContainer splitContainerPrincipal;
        private System.Windows.Forms.Button btnVerIngresos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTituloPacientes;
        private System.Windows.Forms.Panel panelTotalPacientes;
        private System.Windows.Forms.Label lblValorPacientes;
        private System.Windows.Forms.Label lblTituloEdadMedia;
        private System.Windows.Forms.Panel panelEdadMedia;
        private System.Windows.Forms.Label lblValorEdadMedia;
        private System.Windows.Forms.Panel panelTotalIngresos;
        private System.Windows.Forms.Label lblValorIngresos;
        private System.Windows.Forms.Label lblTituloTotalIngresos;
        private System.Windows.Forms.Label lblTituloIngresosActivos;
        private System.Windows.Forms.Panel panelIngresosActivos;
        private System.Windows.Forms.Label lblValorActivos;
    }
}


namespace GestorHospitalario
{
    partial class frmIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngreso));
            this.menuStripIngreso = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripIngreso = new System.Windows.Forms.ToolStrip();
            this.btnGuardarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCerrarToolStrip = new System.Windows.Forms.ToolStripButton();
            this.panelIngreso = new System.Windows.Forms.Panel();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.chkAlta = new System.Windows.Forms.CheckBox();
            this.dtpAlta = new System.Windows.Forms.DateTimePicker();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStripIngreso.SuspendLayout();
            this.toolStripIngreso.SuspendLayout();
            this.panelIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripIngreso
            // 
            this.menuStripIngreso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.accionesToolStripMenuItem});
            this.menuStripIngreso.Location = new System.Drawing.Point(0, 0);
            this.menuStripIngreso.Name = "menuStripIngreso";
            this.menuStripIngreso.Size = new System.Drawing.Size(484, 24);
            this.menuStripIngreso.TabIndex = 2;
            this.menuStripIngreso.Text = "menuStripIngreso";
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
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripIngreso
            // 
            this.toolStripIngreso.AutoSize = false;
            this.toolStripIngreso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardarToolStrip,
            this.toolStripSeparator1,
            this.btnCerrarToolStrip});
            this.toolStripIngreso.Location = new System.Drawing.Point(0, 24);
            this.toolStripIngreso.Name = "toolStripIngreso";
            this.toolStripIngreso.Size = new System.Drawing.Size(484, 40);
            this.toolStripIngreso.TabIndex = 3;
            this.toolStripIngreso.Text = "toolStripIngreso";
            // 
            // btnGuardarToolStrip
            // 
            this.btnGuardarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarToolStrip.Image")));
            this.btnGuardarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardarToolStrip.Name = "btnGuardarToolStrip";
            this.btnGuardarToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnGuardarToolStrip.Text = "Guardar Paciente";
            this.btnGuardarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardarToolStrip.Click += new System.EventHandler(this.btnGuardarToolStrip_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnCerrarToolStrip
            // 
            this.btnCerrarToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrarToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarToolStrip.Image")));
            this.btnCerrarToolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCerrarToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarToolStrip.Name = "btnCerrarToolStrip";
            this.btnCerrarToolStrip.Size = new System.Drawing.Size(36, 37);
            this.btnCerrarToolStrip.Text = "Cerrar Formulario";
            this.btnCerrarToolStrip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarToolStrip.Click += new System.EventHandler(this.btnCerrarToolStrip_Click);
            // 
            // panelIngreso
            // 
            this.panelIngreso.BackColor = System.Drawing.Color.LightBlue;
            this.panelIngreso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelIngreso.Controls.Add(this.lblInfo);
            this.panelIngreso.Controls.Add(this.txtEspecialidad);
            this.panelIngreso.Controls.Add(this.txtHabitacion);
            this.panelIngreso.Controls.Add(this.txtMotivo);
            this.panelIngreso.Controls.Add(this.chkAlta);
            this.panelIngreso.Controls.Add(this.dtpAlta);
            this.panelIngreso.Controls.Add(this.dtpIngreso);
            this.panelIngreso.Controls.Add(this.btnGuardar);
            this.panelIngreso.Controls.Add(this.lblEspecialidad);
            this.panelIngreso.Controls.Add(this.lblHabitacion);
            this.panelIngreso.Controls.Add(this.lblMotivo);
            this.panelIngreso.Controls.Add(this.lblFechaAlta);
            this.panelIngreso.Controls.Add(this.lblFechaIngreso);
            this.panelIngreso.Location = new System.Drawing.Point(0, 68);
            this.panelIngreso.Name = "panelIngreso";
            this.panelIngreso.Size = new System.Drawing.Size(484, 371);
            this.panelIngreso.TabIndex = 4;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidad.Location = new System.Drawing.Point(41, 263);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(400, 25);
            this.txtEspecialidad.TabIndex = 11;
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitacion.Location = new System.Drawing.Point(41, 316);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(100, 25);
            this.txtHabitacion.TabIndex = 10;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(41, 210);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(400, 25);
            this.txtMotivo.TabIndex = 9;
            // 
            // chkAlta
            // 
            this.chkAlta.AutoSize = true;
            this.chkAlta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAlta.Location = new System.Drawing.Point(334, 161);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.Size = new System.Drawing.Size(107, 21);
            this.chkAlta.TabIndex = 8;
            this.chkAlta.Text = "¿Alta médica?";
            this.chkAlta.UseVisualStyleBackColor = true;
            this.chkAlta.CheckedChanged += new System.EventHandler(this.chkAlta_CheckedChanged);
            // 
            // dtpAlta
            // 
            this.dtpAlta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAlta.Location = new System.Drawing.Point(41, 157);
            this.dtpAlta.Name = "dtpAlta";
            this.dtpAlta.Size = new System.Drawing.Size(260, 25);
            this.dtpAlta.TabIndex = 7;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngreso.Location = new System.Drawing.Point(41, 104);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(260, 25);
            this.dtpIngreso.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(321, 301);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 40);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(38, 241);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(84, 17);
            this.lblEspecialidad.TabIndex = 4;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.Location = new System.Drawing.Point(38, 294);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(73, 17);
            this.lblHabitacion.TabIndex = 3;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(38, 188);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(52, 17);
            this.lblMotivo.TabIndex = 2;
            this.lblMotivo.Text = "Motivo:";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(38, 135);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(88, 17);
            this.lblFechaAlta.TabIndex = 1;
            this.lblFechaAlta.Text = "Fecha de alta:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(38, 82);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(111, 17);
            this.lblFechaIngreso.TabIndex = 0;
            this.lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblInfo.Location = new System.Drawing.Point(36, 30);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(407, 30);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Formulario de ingreso hospitalario";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 439);
            this.Controls.Add(this.panelIngreso);
            this.Controls.Add(this.toolStripIngreso);
            this.Controls.Add(this.menuStripIngreso);
            this.Name = "frmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Hospital - Añadir/Editar Ingresos";
            this.menuStripIngreso.ResumeLayout(false);
            this.menuStripIngreso.PerformLayout();
            this.toolStripIngreso.ResumeLayout(false);
            this.toolStripIngreso.PerformLayout();
            this.panelIngreso.ResumeLayout(false);
            this.panelIngreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripIngreso;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripIngreso;
        private System.Windows.Forms.ToolStripButton btnGuardarToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCerrarToolStrip;
        private System.Windows.Forms.Panel panelIngreso;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.DateTimePicker dtpAlta;
        private System.Windows.Forms.CheckBox chkAlta;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblInfo;
    }
}
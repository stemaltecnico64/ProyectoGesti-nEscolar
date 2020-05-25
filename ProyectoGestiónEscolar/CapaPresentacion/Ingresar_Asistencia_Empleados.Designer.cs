namespace CapaPresentacion
{
    partial class Ingresar_Asistencia_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresar_Asistencia_Empleados));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Timer_Fecha_Hora = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtdpi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtpuesto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtempleado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBuscarEncargado = new Bunifu.Framework.UI.BunifuImageButton();
            this.label25 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label15 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEncargado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelTitleBar.Controls.Add(this.btExit);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(500, 61);
            this.panelTitleBar.TabIndex = 169;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(453, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(35, 35);
            this.btExit.TabIndex = 114;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(157, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(224, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Asistencia de Empleados";
            // 
            // Timer_Fecha_Hora
            // 
            this.Timer_Fecha_Hora.Enabled = true;
            this.Timer_Fecha_Hora.Tick += new System.EventHandler(this.Timer_Fecha_Hora_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtFechaNac);
            this.panel1.Controls.Add(this.txtdpi);
            this.panel1.Controls.Add(this.txtpuesto);
            this.panel1.Controls.Add(this.txtempleado);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.btnBuscarEncargado);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 341);
            this.panel1.TabIndex = 170;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(184, 301);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(71, 23);
            this.lblHora.TabIndex = 143;
            this.lblHora.Text = "Sección:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(25, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 23);
            this.label8.TabIndex = 142;
            this.label8.Text = "Hora de Llegada:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(27, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 141;
            this.label7.Text = "Fecha:";
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNac.Location = new System.Drawing.Point(115, 253);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(140, 23);
            this.dtFechaNac.TabIndex = 140;
            // 
            // txtdpi
            // 
            this.txtdpi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdpi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdpi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdpi.HintForeColor = System.Drawing.Color.Empty;
            this.txtdpi.HintText = "";
            this.txtdpi.isPassword = false;
            this.txtdpi.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtdpi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtdpi.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtdpi.LineThickness = 3;
            this.txtdpi.Location = new System.Drawing.Point(115, 205);
            this.txtdpi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdpi.Name = "txtdpi";
            this.txtdpi.Size = new System.Drawing.Size(126, 33);
            this.txtdpi.TabIndex = 139;
            this.txtdpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtpuesto
            // 
            this.txtpuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpuesto.HintForeColor = System.Drawing.Color.Empty;
            this.txtpuesto.HintText = "";
            this.txtpuesto.isPassword = false;
            this.txtpuesto.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtpuesto.LineIdleColor = System.Drawing.Color.Gray;
            this.txtpuesto.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtpuesto.LineThickness = 3;
            this.txtpuesto.Location = new System.Drawing.Point(115, 154);
            this.txtpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(269, 33);
            this.txtpuesto.TabIndex = 138;
            this.txtpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtempleado
            // 
            this.txtempleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtempleado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtempleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtempleado.HintForeColor = System.Drawing.Color.Empty;
            this.txtempleado.HintText = "";
            this.txtempleado.isPassword = false;
            this.txtempleado.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtempleado.LineIdleColor = System.Drawing.Color.Gray;
            this.txtempleado.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtempleado.LineThickness = 3;
            this.txtempleado.Location = new System.Drawing.Point(115, 104);
            this.txtempleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtempleado.Name = "txtempleado";
            this.txtempleado.Size = new System.Drawing.Size(269, 33);
            this.txtempleado.TabIndex = 137;
            this.txtempleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigo.HintText = "";
            this.txtCodigo.isPassword = false;
            this.txtCodigo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCodigo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCodigo.LineThickness = 3;
            this.txtCodigo.Location = new System.Drawing.Point(115, 63);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 33);
            this.txtCodigo.TabIndex = 136;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnBuscarEncargado
            // 
            this.btnBuscarEncargado.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEncargado.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEncargado.Image")));
            this.btnBuscarEncargado.ImageActive = null;
            this.btnBuscarEncargado.Location = new System.Drawing.Point(130, 12);
            this.btnBuscarEncargado.Name = "btnBuscarEncargado";
            this.btnBuscarEncargado.Size = new System.Drawing.Size(39, 36);
            this.btnBuscarEncargado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarEncargado.TabIndex = 135;
            this.btnBuscarEncargado.TabStop = false;
            this.btnBuscarEncargado.Zoom = 10;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Sienna;
            this.label25.Location = new System.Drawing.Point(184, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(132, 23);
            this.label25.TabIndex = 134;
            this.label25.Text = "Buscar Empleado";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(27, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 133;
            this.label5.Text = "DPI:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(23, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 132;
            this.label4.Text = "Empleado:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(23, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 131;
            this.label3.Text = "Puesto:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 130;
            this.label1.Text = "Código:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageActive = null;
            this.btnGuardar.Location = new System.Drawing.Point(190, 414);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(39, 45);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 173;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Zoom = 10;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(235, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 174;
            this.label15.Text = "Guardar";
            // 
            // Ingresar_Asistencia_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 461);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresar_Asistencia_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar_Asistencia_Empleados";
            this.Load += new System.EventHandler(this.Ingresar_Asistencia_Empleados_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarEncargado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer Timer_Fecha_Hora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdpi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpuesto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtempleado;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarEncargado;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnGuardar;
        private System.Windows.Forms.Label label15;
    }
}
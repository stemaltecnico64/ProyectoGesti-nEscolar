namespace CapaPresentacion
{
    partial class Crear_Asignacion_Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Asignacion_Cursos));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtdpi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnombreMaestro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelTitleBar.Controls.Add(this.btExit);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(625, 61);
            this.panelTitleBar.TabIndex = 165;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(587, 3);
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
            this.lblTitle.Location = new System.Drawing.Point(219, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Asignacion de Cursos";
            // 
            // cbSeccion
            // 
            this.cbSeccion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(394, 285);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(169, 23);
            this.cbSeccion.TabIndex = 317;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(410, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 23);
            this.label7.TabIndex = 316;
            this.label7.Text = "Sección a Asignar";
            // 
            // cbCarrera
            // 
            this.cbCarrera.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(23, 213);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(262, 23);
            this.cbCarrera.TabIndex = 315;
            this.cbCarrera.SelectedIndexChanged += new System.EventHandler(this.cbCarrera_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(124, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 314;
            this.label1.Text = "Carrera";
            // 
            // cbCurso
            // 
            this.cbCurso.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Items.AddRange(new object[] {
            "Seleccione No. de Periodos",
            "1 Periodo",
            "2 Periodos",
            "3 Periodos",
            "4 Periodos",
            "5 Periodos"});
            this.cbCurso.Location = new System.Drawing.Point(339, 212);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(262, 23);
            this.cbCurso.TabIndex = 313;
            this.cbCurso.SelectedIndexChanged += new System.EventHandler(this.cbCurso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(410, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 312;
            this.label2.Text = "Curso a Asignar";
            // 
            // cbGrado
            // 
            this.cbGrado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(79, 285);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(169, 23);
            this.cbGrado.TabIndex = 311;
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(138, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 310;
            this.label3.Text = "Grado";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(335, 339);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 309;
            this.label15.Text = "Guardar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageActive = null;
            this.btnGuardar.Location = new System.Drawing.Point(262, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(64, 45);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 308;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Zoom = 10;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtdpi);
            this.panel2.Controls.Add(this.txtcodigo);
            this.panel2.Controls.Add(this.txtnombreMaestro);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Location = new System.Drawing.Point(6, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 113);
            this.panel2.TabIndex = 318;
            // 
            // txtdpi
            // 
            this.txtdpi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdpi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdpi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdpi.HintForeColor = System.Drawing.Color.Empty;
            this.txtdpi.HintText = "";
            this.txtdpi.isPassword = false;
            this.txtdpi.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtdpi.LineIdleColor = System.Drawing.Color.Gray;
            this.txtdpi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtdpi.LineThickness = 3;
            this.txtdpi.Location = new System.Drawing.Point(137, 74);
            this.txtdpi.Margin = new System.Windows.Forms.Padding(4);
            this.txtdpi.Name = "txtdpi";
            this.txtdpi.Size = new System.Drawing.Size(156, 33);
            this.txtdpi.TabIndex = 115;
            this.txtdpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcodigo.HintForeColor = System.Drawing.Color.Empty;
            this.txtcodigo.HintText = "";
            this.txtcodigo.isPassword = false;
            this.txtcodigo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcodigo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcodigo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcodigo.LineThickness = 3;
            this.txtcodigo.Location = new System.Drawing.Point(16, 74);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(113, 33);
            this.txtcodigo.TabIndex = 114;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtnombreMaestro
            // 
            this.txtnombreMaestro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombreMaestro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombreMaestro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombreMaestro.HintForeColor = System.Drawing.Color.Empty;
            this.txtnombreMaestro.HintText = "";
            this.txtnombreMaestro.isPassword = false;
            this.txtnombreMaestro.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnombreMaestro.LineIdleColor = System.Drawing.Color.Gray;
            this.txtnombreMaestro.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnombreMaestro.LineThickness = 3;
            this.txtnombreMaestro.Location = new System.Drawing.Point(302, 74);
            this.txtnombreMaestro.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreMaestro.Name = "txtnombreMaestro";
            this.txtnombreMaestro.Size = new System.Drawing.Size(299, 33);
            this.txtnombreMaestro.TabIndex = 113;
            this.txtnombreMaestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageActive = null;
            this.btnBuscar.Location = new System.Drawing.Point(214, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 36);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 112;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Zoom = 10;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Sienna;
            this.label25.Location = new System.Drawing.Point(259, 11);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(125, 23);
            this.label25.TabIndex = 111;
            this.label25.Text = "Buscar Maestro";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Sienna;
            this.label24.Location = new System.Drawing.Point(403, 47);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 23);
            this.label24.TabIndex = 109;
            this.label24.Text = "Maestro";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Sienna;
            this.label23.Location = new System.Drawing.Point(189, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(39, 23);
            this.label23.TabIndex = 107;
            this.label23.Text = "DPI";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Sienna;
            this.label22.Location = new System.Drawing.Point(36, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 23);
            this.label22.TabIndex = 105;
            this.label22.Text = "Código";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Crear_Asignacion_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 377);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCarrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbGrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crear_Asignacion_Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear_Asignacion_Cursos";
            this.Load += new System.EventHandler(this.Crear_Asignacion_Cursos_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuImageButton btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdpi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcodigo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnombreMaestro;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
namespace CapaPresentacion
{
    partial class Inscripcion_alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripcion_alumno));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_carrera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_tipo_inscripcion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_grado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_nuevo_alumno = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboBox_seccion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_nombre_alumno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_cui_alumno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_codigo_alumno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuImageButton();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_nuevo_alumno)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
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
            this.panelTitleBar.Size = new System.Drawing.Size(629, 61);
            this.panelTitleBar.TabIndex = 21;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(591, 3);
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
            this.lblTitle.Location = new System.Drawing.Point(272, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inscribir";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(302, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 108;
            this.label2.Text = "Carrera";
            // 
            // comboBox_carrera
            // 
            this.comboBox_carrera.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_carrera.FormattingEnabled = true;
            this.comboBox_carrera.Location = new System.Drawing.Point(229, 275);
            this.comboBox_carrera.Name = "comboBox_carrera";
            this.comboBox_carrera.Size = new System.Drawing.Size(213, 23);
            this.comboBox_carrera.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(419, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 98;
            this.label1.Text = "Nuevo Alumno";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageActive = null;
            this.btn_guardar.Location = new System.Drawing.Point(342, 319);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 49);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 106;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Zoom = 10;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageActive = null;
            this.btn_buscar.Location = new System.Drawing.Point(116, 93);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(39, 36);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_buscar.TabIndex = 97;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Zoom = 10;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(402, 332);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 107;
            this.label15.Text = "Guardar";
            // 
            // comboBox_tipo_inscripcion
            // 
            this.comboBox_tipo_inscripcion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo_inscripcion.FormattingEnabled = true;
            this.comboBox_tipo_inscripcion.Location = new System.Drawing.Point(25, 275);
            this.comboBox_tipo_inscripcion.Name = "comboBox_tipo_inscripcion";
            this.comboBox_tipo_inscripcion.Size = new System.Drawing.Size(181, 23);
            this.comboBox_tipo_inscripcion.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(80, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 101;
            this.label7.Text = "Sección";
            // 
            // comboBox_grado
            // 
            this.comboBox_grado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_grado.FormattingEnabled = true;
            this.comboBox_grado.Location = new System.Drawing.Point(455, 275);
            this.comboBox_grado.Name = "comboBox_grado";
            this.comboBox_grado.Size = new System.Drawing.Size(162, 23);
            this.comboBox_grado.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(501, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 100;
            this.label8.Text = "Grado";
            // 
            // btn_nuevo_alumno
            // 
            this.btn_nuevo_alumno.BackColor = System.Drawing.Color.Transparent;
            this.btn_nuevo_alumno.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo_alumno.Image")));
            this.btn_nuevo_alumno.ImageActive = null;
            this.btn_nuevo_alumno.Location = new System.Drawing.Point(357, 93);
            this.btn_nuevo_alumno.Name = "btn_nuevo_alumno";
            this.btn_nuevo_alumno.Size = new System.Drawing.Size(39, 36);
            this.btn_nuevo_alumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_nuevo_alumno.TabIndex = 96;
            this.btn_nuevo_alumno.TabStop = false;
            this.btn_nuevo_alumno.Zoom = 10;
            this.btn_nuevo_alumno.Click += new System.EventHandler(this.btn_nuevo_alumno_Click);
            // 
            // comboBox_seccion
            // 
            this.comboBox_seccion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_seccion.FormattingEnabled = true;
            this.comboBox_seccion.Location = new System.Drawing.Point(57, 334);
            this.comboBox_seccion.Name = "comboBox_seccion";
            this.comboBox_seccion.Size = new System.Drawing.Size(119, 23);
            this.comboBox_seccion.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(40, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 23);
            this.label10.TabIndex = 102;
            this.label10.Text = "Tipo de Inscripción";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Sienna;
            this.label14.Location = new System.Drawing.Point(173, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 95;
            this.label14.Text = "Buscar Alumno";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_nombre_alumno);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.txt_cui_alumno);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.txt_codigo_alumno);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 81);
            this.panel2.TabIndex = 99;
            // 
            // txt_nombre_alumno
            // 
            this.txt_nombre_alumno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre_alumno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_nombre_alumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre_alumno.HintForeColor = System.Drawing.Color.Empty;
            this.txt_nombre_alumno.HintText = "";
            this.txt_nombre_alumno.isPassword = false;
            this.txt_nombre_alumno.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_nombre_alumno.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_nombre_alumno.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_nombre_alumno.LineThickness = 3;
            this.txt_nombre_alumno.Location = new System.Drawing.Point(335, 36);
            this.txt_nombre_alumno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_alumno.Name = "txt_nombre_alumno";
            this.txt_nombre_alumno.Size = new System.Drawing.Size(262, 33);
            this.txt_nombre_alumno.TabIndex = 72;
            this.txt_nombre_alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Sienna;
            this.label24.Location = new System.Drawing.Point(385, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(152, 23);
            this.label24.TabIndex = 71;
            this.label24.Text = "Nombre del Alumno";
            // 
            // txt_cui_alumno
            // 
            this.txt_cui_alumno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cui_alumno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_cui_alumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cui_alumno.HintForeColor = System.Drawing.Color.Empty;
            this.txt_cui_alumno.HintText = "";
            this.txt_cui_alumno.isPassword = false;
            this.txt_cui_alumno.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_cui_alumno.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_cui_alumno.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_cui_alumno.LineThickness = 3;
            this.txt_cui_alumno.Location = new System.Drawing.Point(148, 36);
            this.txt_cui_alumno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cui_alumno.Name = "txt_cui_alumno";
            this.txt_cui_alumno.Size = new System.Drawing.Size(162, 33);
            this.txt_cui_alumno.TabIndex = 70;
            this.txt_cui_alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Sienna;
            this.label23.Location = new System.Drawing.Point(210, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 23);
            this.label23.TabIndex = 69;
            this.label23.Text = "CUI";
            // 
            // txt_codigo_alumno
            // 
            this.txt_codigo_alumno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_codigo_alumno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_codigo_alumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_codigo_alumno.HintForeColor = System.Drawing.Color.Empty;
            this.txt_codigo_alumno.HintText = "";
            this.txt_codigo_alumno.isPassword = false;
            this.txt_codigo_alumno.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_codigo_alumno.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_codigo_alumno.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_codigo_alumno.LineThickness = 3;
            this.txt_codigo_alumno.Location = new System.Drawing.Point(25, 36);
            this.txt_codigo_alumno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo_alumno.Name = "txt_codigo_alumno";
            this.txt_codigo_alumno.Size = new System.Drawing.Size(97, 33);
            this.txt_codigo_alumno.TabIndex = 68;
            this.txt_codigo_alumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Sienna;
            this.label22.Location = new System.Drawing.Point(40, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 23);
            this.label22.TabIndex = 67;
            this.label22.Text = "Código";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Sienna;
            this.label20.Location = new System.Drawing.Point(279, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 23);
            this.label20.TabIndex = 111;
            this.label20.Text = "Nuevo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.icons8_Add_List_48px;
            this.btnNuevo.ImageActive = null;
            this.btnNuevo.Location = new System.Drawing.Point(207, 319);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(57, 52);
            this.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevo.TabIndex = 110;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Zoom = 10;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Sienna;
            this.label21.Location = new System.Drawing.Point(562, 332);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 23);
            this.label21.TabIndex = 113;
            this.label21.Text = "Cancelar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.icons8_Delete_48px;
            this.btnCancelar.ImageActive = null;
            this.btnCancelar.Location = new System.Drawing.Point(495, 319);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 47);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 112;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Zoom = 10;
            // 
            // Inscripcion_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 380);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_carrera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox_tipo_inscripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_grado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_nuevo_alumno);
            this.Controls.Add(this.comboBox_seccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscripcion_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion_alumno";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_nuevo_alumno)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_carrera;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_guardar;
        private Bunifu.Framework.UI.BunifuImageButton btn_buscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_tipo_inscripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_grado;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuImageButton btn_nuevo_alumno;
        private System.Windows.Forms.ComboBox comboBox_seccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nombre_alumno;
        private System.Windows.Forms.Label label24;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_cui_alumno;
        private System.Windows.Forms.Label label23;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_codigo_alumno;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuImageButton btnNuevo;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelar;
        private System.Windows.Forms.Button btExit;
    }
}
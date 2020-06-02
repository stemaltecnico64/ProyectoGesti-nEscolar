namespace CapaPresentacion
{
    partial class Ingresar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingresar_Usuario));
            this.label23 = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbNivelU = new System.Windows.Forms.ComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtdpi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcodigoE = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnombreMaestro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Sienna;
            this.label23.Location = new System.Drawing.Point(28, 131);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 23);
            this.label23.TabIndex = 69;
            this.label23.Text = "Nombre Usuario:";
            // 
            // txt_nombre_usuario
            // 
            this.txt_nombre_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre_usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre_usuario.HintForeColor = System.Drawing.Color.Empty;
            this.txt_nombre_usuario.HintText = "";
            this.txt_nombre_usuario.isPassword = false;
            this.txt_nombre_usuario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_nombre_usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_nombre_usuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_nombre_usuario.LineThickness = 3;
            this.txt_nombre_usuario.Location = new System.Drawing.Point(175, 121);
            this.txt_nombre_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(224, 33);
            this.txt_nombre_usuario.TabIndex = 70;
            this.txt_nombre_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nombre_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_usuario_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(28, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 121;
            this.label7.Text = "Nivel de Usuario:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Sienna;
            this.label20.Location = new System.Drawing.Point(562, 100);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 23);
            this.label20.TabIndex = 131;
            this.label20.Text = "Nuevo";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(562, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 127;
            this.label15.Text = "Guardar";
            // 
            // cbNivelU
            // 
            this.cbNivelU.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivelU.FormattingEnabled = true;
            this.cbNivelU.Location = new System.Drawing.Point(175, 250);
            this.cbNivelU.Name = "cbNivelU";
            this.cbNivelU.Size = new System.Drawing.Size(224, 28);
            this.cbNivelU.TabIndex = 124;
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
            this.panelTitleBar.Size = new System.Drawing.Size(669, 61);
            this.panelTitleBar.TabIndex = 114;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(631, 3);
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
            this.lblTitle.Location = new System.Drawing.Point(261, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nuevo Usuario";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.LightGray;
            this.txtId.Location = new System.Drawing.Point(107, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 134;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Sienna;
            this.label18.Location = new System.Drawing.Point(24, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 23);
            this.label18.TabIndex = 135;
            this.label18.Text = "Codigo:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(28, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 138;
            this.label1.Text = "Contraseña:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageActive = null;
            this.btn_guardar.Location = new System.Drawing.Point(502, 150);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 49);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 126;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Zoom = 10;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.icons8_Add_List_48px;
            this.btnNuevo.ImageActive = null;
            this.btnNuevo.Location = new System.Drawing.Point(499, 80);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(57, 52);
            this.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevo.TabIndex = 130;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Zoom = 10;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtdpi);
            this.panel2.Controls.Add(this.txtcodigoE);
            this.panel2.Controls.Add(this.txtnombreMaestro);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Location = new System.Drawing.Point(25, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 113);
            this.panel2.TabIndex = 319;
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
            // txtcodigoE
            // 
            this.txtcodigoE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigoE.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcodigoE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcodigoE.HintForeColor = System.Drawing.Color.Empty;
            this.txtcodigoE.HintText = "";
            this.txtcodigoE.isPassword = false;
            this.txtcodigoE.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcodigoE.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcodigoE.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcodigoE.LineThickness = 3;
            this.txtcodigoE.Location = new System.Drawing.Point(16, 74);
            this.txtcodigoE.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigoE.Name = "txtcodigoE";
            this.txtcodigoE.Size = new System.Drawing.Size(113, 33);
            this.txtcodigoE.TabIndex = 114;
            this.txtcodigoE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.label25.Size = new System.Drawing.Size(132, 23);
            this.label25.TabIndex = 111;
            this.label25.Text = "Buscar Empleado";
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
            this.label24.Size = new System.Drawing.Size(78, 23);
            this.label24.TabIndex = 109;
            this.label24.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(189, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 107;
            this.label2.Text = "DPI";
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
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_password.HintText = "";
            this.txt_password.isPassword = true;
            this.txt_password.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_password.LineThickness = 3;
            this.txt_password.Location = new System.Drawing.Point(175, 184);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(224, 33);
            this.txt_password.TabIndex = 139;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            // 
            // Ingresar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbNivelU);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresar_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar_Usuario";
            this.Load += new System.EventHandler(this.Ingresar_Usuario_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label23;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nombre_usuario;
        private Bunifu.Framework.UI.BunifuImageButton btn_guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuImageButton btnNuevo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbNivelU;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdpi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcodigoE;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnombreMaestro;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_password;
    }
}
namespace CapaPresentacion
{
    partial class Asistencias_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencias_Empleados));
            this.Timer_Fecha_Hora = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label20 = new System.Windows.Forms.Label();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label_hora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label25 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEncargado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label24 = new System.Windows.Forms.Label();
            this.dtFechaNac = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label16 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Fecha_Hora
            // 
            this.Timer_Fecha_Hora.Enabled = true;
            this.Timer_Fecha_Hora.Tick += new System.EventHandler(this.Timer_Fecha_Hora_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(180, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Asistencia de Personal";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelTitleBar.Controls.Add(this.button1);
            this.panelTitleBar.Controls.Add(this.btExit);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(576, 61);
            this.panelTitleBar.TabIndex = 189;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(538, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(894, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(35, 35);
            this.btExit.TabIndex = 1;
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Sienna;
            this.label21.Location = new System.Drawing.Point(438, 303);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 23);
            this.label21.TabIndex = 247;
            this.label21.Text = "Cancelar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.icons8_Delete_48px;
            this.btnCancelar.ImageActive = null;
            this.btnCancelar.Location = new System.Drawing.Point(359, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 55);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 246;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Zoom = 10;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Sienna;
            this.label20.Location = new System.Drawing.Point(88, 303);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 23);
            this.label20.TabIndex = 245;
            this.label20.Text = "Nuevo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.icons8_Add_List_48px;
            this.btnNuevo.ImageActive = null;
            this.btnNuevo.Location = new System.Drawing.Point(12, 289);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 55);
            this.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevo.TabIndex = 244;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Zoom = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageActive = null;
            this.btnGuardar.Location = new System.Drawing.Point(178, 289);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 55);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 242;
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
            this.label15.Location = new System.Drawing.Point(254, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 243;
            this.label15.Text = "Guardar";
            // 
            // label_hora
            // 
            this.label_hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_hora.AutoSize = true;
            this.label_hora.BackColor = System.Drawing.Color.Transparent;
            this.label_hora.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.ForeColor = System.Drawing.Color.Black;
            this.label_hora.Location = new System.Drawing.Point(173, 242);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(56, 26);
            this.label_hora.TabIndex = 241;
            this.label_hora.Text = "Hora";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 240;
            this.label3.Text = "Hora de Llegada:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageActive = null;
            this.btn_buscar.Location = new System.Drawing.Point(393, 66);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(39, 36);
            this.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_buscar.TabIndex = 239;
            this.btn_buscar.TabStop = false;
            this.btn_buscar.Zoom = 10;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Sienna;
            this.label25.Location = new System.Drawing.Point(442, 74);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(132, 23);
            this.label25.TabIndex = 238;
            this.label25.Text = "Buscar Empleado";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(178, 74);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(189, 33);
            this.bunifuMaterialTextbox2.TabIndex = 237;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 236;
            this.label2.Text = "Codigo:";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(178, 115);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(189, 33);
            this.bunifuMaterialTextbox1.TabIndex = 235;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 234;
            this.label1.Text = "DPI:";
            // 
            // txtNombreEncargado
            // 
            this.txtNombreEncargado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreEncargado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombreEncargado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreEncargado.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombreEncargado.HintText = "";
            this.txtNombreEncargado.isPassword = false;
            this.txtNombreEncargado.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtNombreEncargado.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombreEncargado.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNombreEncargado.LineThickness = 3;
            this.txtNombreEncargado.Location = new System.Drawing.Point(178, 149);
            this.txtNombreEncargado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEncargado.Name = "txtNombreEncargado";
            this.txtNombreEncargado.Size = new System.Drawing.Size(322, 33);
            this.txtNombreEncargado.TabIndex = 233;
            this.txtNombreEncargado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Sienna;
            this.label24.Location = new System.Drawing.Point(12, 159);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(173, 23);
            this.label24.TabIndex = 232;
            this.label24.Text = "Nombre del Empleado:";
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dtFechaNac.BorderRadius = 0;
            this.dtFechaNac.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaNac.ForeColor = System.Drawing.Color.White;
            this.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNac.FormatCustom = null;
            this.dtFechaNac.Location = new System.Drawing.Point(178, 203);
            this.dtFechaNac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(189, 31);
            this.dtFechaNac.TabIndex = 231;
            this.dtFechaNac.Value = new System.DateTime(2020, 4, 17, 18, 34, 0, 0);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Sienna;
            this.label16.Location = new System.Drawing.Point(12, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 23);
            this.label16.TabIndex = 230;
            this.label16.Text = "Fecha Actual:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Asistencias_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 372);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEncargado);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dtFechaNac);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asistencias_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencias_Empleados";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer Timer_Fecha_Hora;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelar;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuImageButton btnNuevo;
        private Bunifu.Framework.UI.BunifuImageButton btnGuardar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_hora;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btn_buscar;
        private System.Windows.Forms.Label label25;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreEncargado;
        private System.Windows.Forms.Label label24;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaNac;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
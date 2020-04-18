namespace CapaPresentacion
{
    partial class Crear_Pensum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Pensum));
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuImageButton();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_nombre_usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_seccion = new System.Windows.Forms.ComboBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(665, 3);
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
            this.lblTitle.Location = new System.Drawing.Point(277, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nuevo Pensum";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelTitleBar.Controls.Add(this.btExit);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(700, 61);
            this.panelTitleBar.TabIndex = 144;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(46, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 175;
            this.label1.Text = "Pensum de la Carrera:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 28);
            this.comboBox1.TabIndex = 176;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.icons8_Delete_48px;
            this.btnCancelar.ImageActive = null;
            this.btnCancelar.Location = new System.Drawing.Point(510, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 47);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 173;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Zoom = 10;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.icons8_Add_List_48px;
            this.btnNuevo.ImageActive = null;
            this.btnNuevo.Location = new System.Drawing.Point(510, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(57, 52);
            this.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevo.TabIndex = 171;
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
            this.label21.Location = new System.Drawing.Point(577, 224);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 23);
            this.label21.TabIndex = 174;
            this.label21.Text = "Cancelar";
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
            this.txt_nombre_usuario.Location = new System.Drawing.Point(244, 81);
            this.txt_nombre_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.Size = new System.Drawing.Size(224, 33);
            this.txt_nombre_usuario.TabIndex = 166;
            this.txt_nombre_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Sienna;
            this.label23.Location = new System.Drawing.Point(46, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(155, 23);
            this.label23.TabIndex = 165;
            this.label23.Text = "Nombre del Pensum:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageActive = null;
            this.btn_guardar.Location = new System.Drawing.Point(513, 147);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 49);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 169;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Zoom = 10;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(46, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 167;
            this.label7.Text = "Para el Grado de:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Sienna;
            this.label20.Location = new System.Drawing.Point(573, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 23);
            this.label20.TabIndex = 172;
            this.label20.Text = "Nuevo";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(573, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 170;
            this.label15.Text = "Guardar";
            // 
            // comboBox_seccion
            // 
            this.comboBox_seccion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_seccion.FormattingEnabled = true;
            this.comboBox_seccion.Location = new System.Drawing.Point(244, 172);
            this.comboBox_seccion.Name = "comboBox_seccion";
            this.comboBox_seccion.Size = new System.Drawing.Size(224, 28);
            this.comboBox_seccion.TabIndex = 168;
            // 
            // Crear_Pensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox_seccion);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crear_Pensum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear_Pensum";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitleBar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelar;
        private Bunifu.Framework.UI.BunifuImageButton btnNuevo;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nombre_usuario;
        private System.Windows.Forms.Label label23;
        private Bunifu.Framework.UI.BunifuImageButton btn_guardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_seccion;
    }
}
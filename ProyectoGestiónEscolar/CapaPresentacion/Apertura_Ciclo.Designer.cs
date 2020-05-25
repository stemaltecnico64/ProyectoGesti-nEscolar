namespace CapaPresentacion
{
    partial class Apertura_Ciclo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apertura_Ciclo));
            this.label18 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCiclo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label21 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtId_Ciclo = new System.Windows.Forms.TextBox();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuImageButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnGuardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Sienna;
            this.label18.Location = new System.Drawing.Point(12, 117);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 23);
            this.label18.TabIndex = 246;
            this.label18.Text = "Código:";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelTitleBar.Controls.Add(this.btExit);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(646, 61);
            this.panelTitleBar.TabIndex = 236;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(608, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(35, 35);
            this.btExit.TabIndex = 114;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(268, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Apertura de Ciclos";
            // 
            // txtCiclo
            // 
            this.txtCiclo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCiclo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCiclo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCiclo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCiclo.HintText = "";
            this.txtCiclo.isPassword = true;
            this.txtCiclo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCiclo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCiclo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCiclo.LineThickness = 3;
            this.txtCiclo.Location = new System.Drawing.Point(204, 146);
            this.txtCiclo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(237, 33);
            this.txtCiclo.TabIndex = 244;
            this.txtCiclo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 243;
            this.label1.Text = "Nombre del Ciclo o Año:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.icons8_Delete_48px;
            this.btnCancelar.ImageActive = null;
            this.btnCancelar.Location = new System.Drawing.Point(288, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 47);
            this.btnCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCancelar.TabIndex = 241;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Zoom = 10;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Sienna;
            this.label21.Location = new System.Drawing.Point(345, 291);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 23);
            this.label21.TabIndex = 242;
            this.label21.Text = "Cancelar";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtId_Ciclo
            // 
            this.txtId_Ciclo.BackColor = System.Drawing.Color.LightGray;
            this.txtId_Ciclo.Enabled = false;
            this.txtId_Ciclo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtId_Ciclo.Location = new System.Drawing.Point(79, 117);
            this.txtId_Ciclo.Name = "txtId_Ciclo";
            this.txtId_Ciclo.Size = new System.Drawing.Size(100, 23);
            this.txtId_Ciclo.TabIndex = 245;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.icons8_Add_List_48px;
            this.btnNuevo.ImageActive = null;
            this.btnNuevo.Location = new System.Drawing.Point(20, 278);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 52);
            this.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevo.TabIndex = 239;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Zoom = 10;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click_1);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Sienna;
            this.label20.Location = new System.Drawing.Point(77, 291);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 23);
            this.label20.TabIndex = 240;
            this.label20.Text = "Nuevo";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(204, 291);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 238;
            this.label15.Text = "Guardar";
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageActive = null;
            this.btnGuardar.Location = new System.Drawing.Point(148, 281);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 49);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 237;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Zoom = 10;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 247;
            this.label2.Text = "Descripción:";
            // 
            // txtdes
            // 
            this.txtdes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdes.HintForeColor = System.Drawing.Color.Empty;
            this.txtdes.HintText = "";
            this.txtdes.isPassword = true;
            this.txtdes.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtdes.LineIdleColor = System.Drawing.Color.Gray;
            this.txtdes.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtdes.LineThickness = 3;
            this.txtdes.Location = new System.Drawing.Point(120, 202);
            this.txtdes.Margin = new System.Windows.Forms.Padding(4);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(488, 33);
            this.txtdes.TabIndex = 248;
            this.txtdes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(73, 73);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(122, 23);
            this.dtFecha.TabIndex = 250;
            // 
            // cbEstado
            // 
            this.cbEstado.Enabled = false;
            this.cbEstado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "DESACTIVO"});
            this.cbEstado.Location = new System.Drawing.Point(548, 73);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(86, 23);
            this.cbEstado.TabIndex = 251;
            this.cbEstado.Text = "ACTIVO";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(488, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 249;
            this.label10.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 252;
            this.label3.Text = "Fecha:";
            // 
            // Apertura_Ciclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtId_Ciclo);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Apertura_Ciclo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apertura_Ciclo";
            this.Load += new System.EventHandler(this.Apertura_Ciclo_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCiclo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnCancelar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId_Ciclo;
        private Bunifu.Framework.UI.BunifuImageButton btnNuevo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuImageButton btnGuardar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label10;
    }
}
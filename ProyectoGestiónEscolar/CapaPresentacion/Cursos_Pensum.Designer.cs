namespace CapaPresentacion
{
    partial class Cursos_Pensum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos_Pensum));
            this.label15 = new System.Windows.Forms.Label();
            this.cbPeriodos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurso = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnGuardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btExit = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(274, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 284;
            this.label15.Text = "Guardar";
            // 
            // cbPeriodos
            // 
            this.cbPeriodos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodos.FormattingEnabled = true;
            this.cbPeriodos.Items.AddRange(new object[] {
            "Seleccione No. de Periodos",
            "1 Periodo",
            "2 Periodos",
            "3 Periodos",
            "4 Periodos",
            "5 Periodos"});
            this.cbPeriodos.Location = new System.Drawing.Point(157, 248);
            this.cbPeriodos.Name = "cbPeriodos";
            this.cbPeriodos.Size = new System.Drawing.Size(201, 23);
            this.cbPeriodos.TabIndex = 280;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(189, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 279;
            this.label4.Text = "No. de Periodos";
            // 
            // cbGrado
            // 
            this.cbGrado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(308, 162);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(184, 23);
            this.cbGrado.TabIndex = 278;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(341, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 277;
            this.label3.Text = "Grado a Asignar";
            // 
            // txtCurso
            // 
            this.txtCurso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurso.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurso.HintForeColor = System.Drawing.Color.Empty;
            this.txtCurso.HintText = "";
            this.txtCurso.isPassword = false;
            this.txtCurso.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCurso.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCurso.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCurso.LineThickness = 3;
            this.txtCurso.Location = new System.Drawing.Point(29, 151);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(261, 33);
            this.txtCurso.TabIndex = 274;
            this.txtCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(83, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 273;
            this.label2.Text = "Nombre del Curso:";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelTitleBar.Controls.Add(this.btExit);
            this.panelTitleBar.Controls.Add(this.label8);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(523, 61);
            this.panelTitleBar.TabIndex = 270;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(188, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Agregar Cursos";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageActive = null;
            this.btnGuardar.Location = new System.Drawing.Point(214, 311);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(54, 49);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 283;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Zoom = 10;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(476, 10);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(35, 35);
            this.btExit.TabIndex = 114;
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // Cursos_Pensum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 403);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbPeriodos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbGrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cursos_Pensum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos_Pensum";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbPeriodos;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton btnGuardar;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
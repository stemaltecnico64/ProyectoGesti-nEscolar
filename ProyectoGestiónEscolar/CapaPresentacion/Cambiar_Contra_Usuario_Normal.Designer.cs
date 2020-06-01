namespace CapaPresentacion
{
    partial class Cambiar_Contra_Usuario_Normal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cambiar_Contra_Usuario_Normal));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_mostrar1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNuevoPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_mostrar2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_mostrar3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtConfirmarPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label15 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mostrar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mostrar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mostrar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
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
            this.panelTitleBar.Size = new System.Drawing.Size(436, 61);
            this.panelTitleBar.TabIndex = 164;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(398, 3);
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
            this.lblTitle.Location = new System.Drawing.Point(125, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cambiar Contraseña";
            // 
            // btn_mostrar1
            // 
            this.btn_mostrar1.BackColor = System.Drawing.Color.Transparent;
            this.btn_mostrar1.Image = ((System.Drawing.Image)(resources.GetObject("btn_mostrar1.Image")));
            this.btn_mostrar1.ImageActive = null;
            this.btn_mostrar1.Location = new System.Drawing.Point(360, 154);
            this.btn_mostrar1.Name = "btn_mostrar1";
            this.btn_mostrar1.Size = new System.Drawing.Size(48, 37);
            this.btn_mostrar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_mostrar1.TabIndex = 193;
            this.btn_mostrar1.TabStop = false;
            this.btn_mostrar1.Zoom = 10;
            this.btn_mostrar1.Click += new System.EventHandler(this.btn_mostrar1_Click);
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
            this.txt_password.Location = new System.Drawing.Point(63, 154);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(274, 33);
            this.txt_password.TabIndex = 192;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(126, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 191;
            this.label1.Text = "Antigua Contraseña:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.LightGray;
            this.txtId.Location = new System.Drawing.Point(95, 75);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 194;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Sienna;
            this.label18.Location = new System.Drawing.Point(12, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 23);
            this.label18.TabIndex = 195;
            this.label18.Text = "Codigo:";
            // 
            // txtNuevoPass
            // 
            this.txtNuevoPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNuevoPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNuevoPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNuevoPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtNuevoPass.HintText = "";
            this.txtNuevoPass.isPassword = true;
            this.txtNuevoPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtNuevoPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNuevoPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtNuevoPass.LineThickness = 3;
            this.txtNuevoPass.Location = new System.Drawing.Point(63, 227);
            this.txtNuevoPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoPass.Name = "txtNuevoPass";
            this.txtNuevoPass.Size = new System.Drawing.Size(274, 33);
            this.txtNuevoPass.TabIndex = 197;
            this.txtNuevoPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(126, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 196;
            this.label2.Text = "Nueva Contraseña:";
            // 
            // btn_mostrar2
            // 
            this.btn_mostrar2.BackColor = System.Drawing.Color.Transparent;
            this.btn_mostrar2.Image = ((System.Drawing.Image)(resources.GetObject("btn_mostrar2.Image")));
            this.btn_mostrar2.ImageActive = null;
            this.btn_mostrar2.Location = new System.Drawing.Point(360, 227);
            this.btn_mostrar2.Name = "btn_mostrar2";
            this.btn_mostrar2.Size = new System.Drawing.Size(48, 37);
            this.btn_mostrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_mostrar2.TabIndex = 198;
            this.btn_mostrar2.TabStop = false;
            this.btn_mostrar2.Zoom = 10;
            this.btn_mostrar2.Click += new System.EventHandler(this.btn_mostrar2_Click);
            // 
            // btn_mostrar3
            // 
            this.btn_mostrar3.BackColor = System.Drawing.Color.Transparent;
            this.btn_mostrar3.Image = ((System.Drawing.Image)(resources.GetObject("btn_mostrar3.Image")));
            this.btn_mostrar3.ImageActive = null;
            this.btn_mostrar3.Location = new System.Drawing.Point(360, 303);
            this.btn_mostrar3.Name = "btn_mostrar3";
            this.btn_mostrar3.Size = new System.Drawing.Size(48, 37);
            this.btn_mostrar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_mostrar3.TabIndex = 201;
            this.btn_mostrar3.TabStop = false;
            this.btn_mostrar3.Zoom = 10;
            this.btn_mostrar3.Click += new System.EventHandler(this.btn_mostrar3_Click);
            // 
            // txtConfirmarPass
            // 
            this.txtConfirmarPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmarPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtConfirmarPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmarPass.HintForeColor = System.Drawing.Color.Empty;
            this.txtConfirmarPass.HintText = "";
            this.txtConfirmarPass.isPassword = true;
            this.txtConfirmarPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtConfirmarPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfirmarPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtConfirmarPass.LineThickness = 3;
            this.txtConfirmarPass.Location = new System.Drawing.Point(63, 303);
            this.txtConfirmarPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmarPass.Name = "txtConfirmarPass";
            this.txtConfirmarPass.Size = new System.Drawing.Size(274, 33);
            this.txtConfirmarPass.TabIndex = 200;
            this.txtConfirmarPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(108, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 23);
            this.label3.TabIndex = 199;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageActive = null;
            this.btn_guardar.Location = new System.Drawing.Point(154, 352);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 49);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 202;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Zoom = 10;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(214, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 203;
            this.label15.Text = "Guardar";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Cambiar_Contra_Usuario_Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 413);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_mostrar3);
            this.Controls.Add(this.txtConfirmarPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_mostrar2);
            this.Controls.Add(this.txtNuevoPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_mostrar1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cambiar_Contra_Usuario_Normal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar_Contra_Usuario_Normal";
            this.Load += new System.EventHandler(this.Cambiar_Contra_Usuario_Normal_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mostrar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mostrar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mostrar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton btn_mostrar1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label18;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNuevoPass;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btn_mostrar2;
        private Bunifu.Framework.UI.BunifuImageButton btn_mostrar3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmarPass;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton btn_guardar;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
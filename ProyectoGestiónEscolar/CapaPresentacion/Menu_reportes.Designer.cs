namespace CapaPresentacion
{
    partial class Menu_Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Reportes));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Crear = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Crear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(87, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Notas";
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Crear.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Crear.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Crear.Image")));
            this.Btn_Crear.ImageActive = null;
            this.Btn_Crear.Location = new System.Drawing.Point(77, 83);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(74, 71);
            this.Btn_Crear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Crear.TabIndex = 46;
            this.Btn_Crear.TabStop = false;
            this.Btn_Crear.Zoom = 10;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // Menu_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Crear);
            this.Name = "Menu_Reportes";
            this.Text = "Menu_Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Crear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Crear;
    }
}
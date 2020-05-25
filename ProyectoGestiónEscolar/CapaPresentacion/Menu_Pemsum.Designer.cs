namespace CapaPresentacion
{
    partial class Menu_Pemsum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Pemsum));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_All_Users = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btn_Crear = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_All_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Crear)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(332, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 50;
            this.label3.Text = "Catalogo de Pensums";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(138, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nuevo Pensum";
            // 
            // Btn_All_Users
            // 
            this.Btn_All_Users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_All_Users.BackColor = System.Drawing.Color.Transparent;
            this.Btn_All_Users.Image = ((System.Drawing.Image)(resources.GetObject("Btn_All_Users.Image")));
            this.Btn_All_Users.ImageActive = null;
            this.Btn_All_Users.Location = new System.Drawing.Point(388, 146);
            this.Btn_All_Users.Name = "Btn_All_Users";
            this.Btn_All_Users.Size = new System.Drawing.Size(74, 71);
            this.Btn_All_Users.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_All_Users.TabIndex = 48;
            this.Btn_All_Users.TabStop = false;
            this.Btn_All_Users.Zoom = 10;
            this.Btn_All_Users.Click += new System.EventHandler(this.Btn_All_Users_Click);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Crear.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Crear.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Crear.Image")));
            this.Btn_Crear.ImageActive = null;
            this.Btn_Crear.Location = new System.Drawing.Point(168, 146);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(74, 71);
            this.Btn_Crear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Crear.TabIndex = 47;
            this.Btn_Crear.TabStop = false;
            this.Btn_Crear.Zoom = 10;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // Menu_Pemsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_All_Users);
            this.Controls.Add(this.Btn_Crear);
            this.Name = "Menu_Pemsum";
            this.Text = "Menu_Pemsum";
            ((System.ComponentModel.ISupportInitialize)(this.Btn_All_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Crear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton Btn_All_Users;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Crear;
    }
}
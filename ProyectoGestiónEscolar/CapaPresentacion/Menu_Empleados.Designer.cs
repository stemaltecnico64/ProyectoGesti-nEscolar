namespace CapaPresentacion
{
    partial class Menu_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Empleados));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_All_Users = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btn_Crear = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_asignar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_All_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Crear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asignar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(264, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 26);
            this.label3.TabIndex = 50;
            this.label3.Text = "Todos Los Empleados";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(71, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nuevo Empleado";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(126, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 26);
            this.label2.TabIndex = 52;
            this.label2.Text = "Asignar Cursos a Empleados";
            // 
            // Btn_All_Users
            // 
            this.Btn_All_Users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_All_Users.BackColor = System.Drawing.Color.Transparent;
            this.Btn_All_Users.Image = ((System.Drawing.Image)(resources.GetObject("Btn_All_Users.Image")));
            this.Btn_All_Users.ImageActive = null;
            this.Btn_All_Users.Location = new System.Drawing.Point(318, 60);
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
            this.Btn_Crear.Location = new System.Drawing.Point(112, 60);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(74, 71);
            this.Btn_Crear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Crear.TabIndex = 47;
            this.Btn_Crear.TabStop = false;
            this.Btn_Crear.Zoom = 10;
            this.Btn_Crear.Click += new System.EventHandler(this.Btn_Crear_Click);
            // 
            // btn_asignar
            // 
            this.btn_asignar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_asignar.BackColor = System.Drawing.Color.Transparent;
            this.btn_asignar.Image = ((System.Drawing.Image)(resources.GetObject("btn_asignar.Image")));
            this.btn_asignar.ImageActive = null;
            this.btn_asignar.Location = new System.Drawing.Point(218, 219);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(74, 71);
            this.btn_asignar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_asignar.TabIndex = 53;
            this.btn_asignar.TabStop = false;
            this.btn_asignar.Zoom = 10;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // Menu_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 417);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_All_Users);
            this.Controls.Add(this.Btn_Crear);
            this.Name = "Menu_Empleados";
            this.Text = "Menu_Empleados";
            this.Load += new System.EventHandler(this.Menu_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_All_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Crear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asignar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton Btn_All_Users;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Crear;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btn_asignar;
    }
}
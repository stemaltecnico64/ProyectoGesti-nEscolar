namespace CapaPresentacion
{
    partial class Menu_Asistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Asistencia));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_asistencia_alumnos = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_asistencia_empleados = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asistencia_alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asistencia_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(383, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Asistencia de Empleados";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(88, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "Asistencia de Alumnos";
            // 
            // btn_asistencia_alumnos
            // 
            this.btn_asistencia_alumnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_asistencia_alumnos.BackColor = System.Drawing.Color.Transparent;
            this.btn_asistencia_alumnos.Image = ((System.Drawing.Image)(resources.GetObject("btn_asistencia_alumnos.Image")));
            this.btn_asistencia_alumnos.ImageActive = null;
            this.btn_asistencia_alumnos.Location = new System.Drawing.Point(155, 118);
            this.btn_asistencia_alumnos.Name = "btn_asistencia_alumnos";
            this.btn_asistencia_alumnos.Size = new System.Drawing.Size(71, 71);
            this.btn_asistencia_alumnos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_asistencia_alumnos.TabIndex = 40;
            this.btn_asistencia_alumnos.TabStop = false;
            this.btn_asistencia_alumnos.Zoom = 10;
            this.btn_asistencia_alumnos.Click += new System.EventHandler(this.btn_asistencia_alumnos_Click);
            // 
            // btn_asistencia_empleados
            // 
            this.btn_asistencia_empleados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_asistencia_empleados.BackColor = System.Drawing.Color.Transparent;
            this.btn_asistencia_empleados.Image = ((System.Drawing.Image)(resources.GetObject("btn_asistencia_empleados.Image")));
            this.btn_asistencia_empleados.ImageActive = null;
            this.btn_asistencia_empleados.Location = new System.Drawing.Point(450, 118);
            this.btn_asistencia_empleados.Name = "btn_asistencia_empleados";
            this.btn_asistencia_empleados.Size = new System.Drawing.Size(71, 71);
            this.btn_asistencia_empleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_asistencia_empleados.TabIndex = 38;
            this.btn_asistencia_empleados.TabStop = false;
            this.btn_asistencia_empleados.Zoom = 10;
            this.btn_asistencia_empleados.Click += new System.EventHandler(this.btn_asistencia_empleados_Click);
            // 
            // Menu_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 404);
            this.Controls.Add(this.btn_asistencia_alumnos);
            this.Controls.Add(this.btn_asistencia_empleados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Menu_Asistencia";
            this.Text = "Menu_Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.btn_asistencia_alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_asistencia_empleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_asistencia_alumnos;
        private Bunifu.Framework.UI.BunifuImageButton btn_asistencia_empleados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
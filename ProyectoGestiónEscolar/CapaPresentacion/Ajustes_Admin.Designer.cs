namespace CapaPresentacion
{
    partial class Ajustes_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajustes_Admin));
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.btn_ciclo = new System.Windows.Forms.Button();
            this.btn_minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_puestos = new System.Windows.Forms.Button();
            this.btn_cuenta = new System.Windows.Forms.Button();
            this.btn_encargados = new System.Windows.Forms.Button();
            this.btn_Departamentos = new System.Windows.Forms.Button();
            this.btn_municipios = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_inscripcion = new System.Windows.Forms.Button();
            this.SideMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(183, 0);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(460, 526);
            this.DesktopPanel.TabIndex = 3;
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.SideMenuPanel.Controls.Add(this.btn_inscripcion);
            this.SideMenuPanel.Controls.Add(this.btn_ciclo);
            this.SideMenuPanel.Controls.Add(this.btn_minimizar);
            this.SideMenuPanel.Controls.Add(this.Btn_Cerrar);
            this.SideMenuPanel.Controls.Add(this.btn_puestos);
            this.SideMenuPanel.Controls.Add(this.btn_cuenta);
            this.SideMenuPanel.Controls.Add(this.btn_encargados);
            this.SideMenuPanel.Controls.Add(this.btn_Departamentos);
            this.SideMenuPanel.Controls.Add(this.btn_municipios);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(183, 526);
            this.SideMenuPanel.TabIndex = 1;
            // 
            // btn_ciclo
            // 
            this.btn_ciclo.FlatAppearance.BorderSize = 0;
            this.btn_ciclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ciclo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ciclo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_ciclo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ciclo.Image")));
            this.btn_ciclo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ciclo.Location = new System.Drawing.Point(0, 406);
            this.btn_ciclo.Name = "btn_ciclo";
            this.btn_ciclo.Size = new System.Drawing.Size(179, 43);
            this.btn_ciclo.TabIndex = 54;
            this.btn_ciclo.Text = "Ciclo Escolar";
            this.btn_ciclo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ciclo.UseVisualStyleBackColor = true;
            this.btn_ciclo.Click += new System.EventHandler(this.btn_ciclo_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.ImageActive = null;
            this.btn_minimizar.Location = new System.Drawing.Point(48, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(35, 34);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 52;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Zoom = 10;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.ImageActive = null;
            this.Btn_Cerrar.Location = new System.Drawing.Point(102, 3);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(35, 34);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 51;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Zoom = 10;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // btn_puestos
            // 
            this.btn_puestos.FlatAppearance.BorderSize = 0;
            this.btn_puestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_puestos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_puestos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_puestos.Image = ((System.Drawing.Image)(resources.GetObject("btn_puestos.Image")));
            this.btn_puestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_puestos.Location = new System.Drawing.Point(2, 336);
            this.btn_puestos.Name = "btn_puestos";
            this.btn_puestos.Size = new System.Drawing.Size(179, 43);
            this.btn_puestos.TabIndex = 23;
            this.btn_puestos.Text = "Puestos";
            this.btn_puestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_puestos.UseVisualStyleBackColor = true;
            this.btn_puestos.Click += new System.EventHandler(this.btn_puestos_Click);
            // 
            // btn_cuenta
            // 
            this.btn_cuenta.FlatAppearance.BorderSize = 0;
            this.btn_cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cuenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cuenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_cuenta.Image = ((System.Drawing.Image)(resources.GetObject("btn_cuenta.Image")));
            this.btn_cuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cuenta.Location = new System.Drawing.Point(2, 266);
            this.btn_cuenta.Name = "btn_cuenta";
            this.btn_cuenta.Size = new System.Drawing.Size(179, 43);
            this.btn_cuenta.TabIndex = 22;
            this.btn_cuenta.Text = "Cuenta";
            this.btn_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cuenta.UseVisualStyleBackColor = true;
            this.btn_cuenta.Click += new System.EventHandler(this.btn_cuenta_Click);
            // 
            // btn_encargados
            // 
            this.btn_encargados.FlatAppearance.BorderSize = 0;
            this.btn_encargados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_encargados.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encargados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_encargados.Image = ((System.Drawing.Image)(resources.GetObject("btn_encargados.Image")));
            this.btn_encargados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_encargados.Location = new System.Drawing.Point(3, 196);
            this.btn_encargados.Name = "btn_encargados";
            this.btn_encargados.Size = new System.Drawing.Size(179, 43);
            this.btn_encargados.TabIndex = 21;
            this.btn_encargados.Text = "Encargados";
            this.btn_encargados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_encargados.UseVisualStyleBackColor = true;
            this.btn_encargados.Click += new System.EventHandler(this.btn_encargados_Click);
            // 
            // btn_Departamentos
            // 
            this.btn_Departamentos.FlatAppearance.BorderSize = 0;
            this.btn_Departamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Departamentos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Departamentos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Departamentos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Departamentos.Image")));
            this.btn_Departamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Departamentos.Location = new System.Drawing.Point(2, 60);
            this.btn_Departamentos.Name = "btn_Departamentos";
            this.btn_Departamentos.Size = new System.Drawing.Size(179, 39);
            this.btn_Departamentos.TabIndex = 20;
            this.btn_Departamentos.Text = "Departamentos";
            this.btn_Departamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Departamentos.UseVisualStyleBackColor = true;
            this.btn_Departamentos.Click += new System.EventHandler(this.btn_Departamentos_Click);
            // 
            // btn_municipios
            // 
            this.btn_municipios.FlatAppearance.BorderSize = 0;
            this.btn_municipios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_municipios.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_municipios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_municipios.Image = ((System.Drawing.Image)(resources.GetObject("btn_municipios.Image")));
            this.btn_municipios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_municipios.Location = new System.Drawing.Point(3, 126);
            this.btn_municipios.Name = "btn_municipios";
            this.btn_municipios.Size = new System.Drawing.Size(179, 43);
            this.btn_municipios.TabIndex = 19;
            this.btn_municipios.Text = "Municipios";
            this.btn_municipios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_municipios.UseVisualStyleBackColor = true;
            this.btn_municipios.Click += new System.EventHandler(this.btn_municipios_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.SideMenuPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btn_inscripcion
            // 
            this.btn_inscripcion.FlatAppearance.BorderSize = 0;
            this.btn_inscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inscripcion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inscripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_inscripcion.Image = ((System.Drawing.Image)(resources.GetObject("btn_inscripcion.Image")));
            this.btn_inscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inscripcion.Location = new System.Drawing.Point(1, 476);
            this.btn_inscripcion.Name = "btn_inscripcion";
            this.btn_inscripcion.Size = new System.Drawing.Size(179, 43);
            this.btn_inscripcion.TabIndex = 55;
            this.btn_inscripcion.Text = "Inscripción";
            this.btn_inscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inscripcion.UseVisualStyleBackColor = true;
            this.btn_inscripcion.Click += new System.EventHandler(this.btn_inscripcion_Click);
            // 
            // Ajustes_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 526);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.SideMenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajustes_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes_Admin";
            this.SideMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Button btn_puestos;
        private System.Windows.Forms.Button btn_cuenta;
        private System.Windows.Forms.Button btn_encargados;
        private System.Windows.Forms.Button btn_Departamentos;
        private System.Windows.Forms.Button btn_municipios;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimizar;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Cerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btn_ciclo;
        private System.Windows.Forms.Button btn_inscripcion;
    }
}
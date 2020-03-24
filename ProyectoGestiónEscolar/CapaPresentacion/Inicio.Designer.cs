namespace CapaPresentacion
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_acercaDe = new System.Windows.Forms.Button();
            this.btn_ajustes = new System.Windows.Forms.Button();
            this.btn_empleados = new System.Windows.Forms.Button();
            this.btn_alumnos = new System.Windows.Forms.Button();
            this.menu_inicio1 = new CapaPresentacion.menu_inicio();
            this.menu_alumnos1 = new CapaPresentacion.menu_alumnos();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_Inicio);
            this.panelMenu.Controls.Add(this.btn_usuarios);
            this.panelMenu.Controls.Add(this.btn_acercaDe);
            this.panelMenu.Controls.Add(this.btn_ajustes);
            this.panelMenu.Controls.Add(this.btn_empleados);
            this.panelMenu.Controls.Add(this.btn_alumnos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(201, 514);
            this.panelMenu.TabIndex = 3;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(201, 88);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(192)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Location = new System.Drawing.Point(201, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(658, 85);
            this.panelTitleBar.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(279, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "INICIO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menu_alumnos1);
            this.panel1.Controls.Add(this.menu_inicio1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 514);
            this.panel1.TabIndex = 5;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.FlatAppearance.BorderSize = 0;
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inicio.Image")));
            this.btn_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inicio.Location = new System.Drawing.Point(3, 88);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(201, 58);
            this.btn_Inicio.TabIndex = 8;
            this.btn_Inicio.Text = "Inicio";
            this.btn_Inicio.UseVisualStyleBackColor = true;
            this.btn_Inicio.Click += new System.EventHandler(this.btn_Inicio_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.FlatAppearance.BorderSize = 0;
            this.btn_usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuarios.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_usuarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuarios.Image")));
            this.btn_usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuarios.Location = new System.Drawing.Point(0, 262);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(201, 58);
            this.btn_usuarios.TabIndex = 7;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            // 
            // btn_acercaDe
            // 
            this.btn_acercaDe.FlatAppearance.BorderSize = 0;
            this.btn_acercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acercaDe.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acercaDe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_acercaDe.Image = ((System.Drawing.Image)(resources.GetObject("btn_acercaDe.Image")));
            this.btn_acercaDe.Location = new System.Drawing.Point(161, 474);
            this.btn_acercaDe.Name = "btn_acercaDe";
            this.btn_acercaDe.Size = new System.Drawing.Size(37, 40);
            this.btn_acercaDe.TabIndex = 6;
            this.btn_acercaDe.UseVisualStyleBackColor = true;
            // 
            // btn_ajustes
            // 
            this.btn_ajustes.FlatAppearance.BorderSize = 0;
            this.btn_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajustes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajustes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_ajustes.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajustes.Image")));
            this.btn_ajustes.Location = new System.Drawing.Point(0, 474);
            this.btn_ajustes.Name = "btn_ajustes";
            this.btn_ajustes.Size = new System.Drawing.Size(37, 40);
            this.btn_ajustes.TabIndex = 5;
            this.btn_ajustes.UseVisualStyleBackColor = true;
            // 
            // btn_empleados
            // 
            this.btn_empleados.FlatAppearance.BorderSize = 0;
            this.btn_empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleados.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empleados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_empleados.Image = ((System.Drawing.Image)(resources.GetObject("btn_empleados.Image")));
            this.btn_empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_empleados.Location = new System.Drawing.Point(0, 204);
            this.btn_empleados.Name = "btn_empleados";
            this.btn_empleados.Size = new System.Drawing.Size(201, 58);
            this.btn_empleados.TabIndex = 4;
            this.btn_empleados.Text = "Empleados";
            this.btn_empleados.UseVisualStyleBackColor = true;
            // 
            // btn_alumnos
            // 
            this.btn_alumnos.FlatAppearance.BorderSize = 0;
            this.btn_alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alumnos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alumnos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_alumnos.Image = ((System.Drawing.Image)(resources.GetObject("btn_alumnos.Image")));
            this.btn_alumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alumnos.Location = new System.Drawing.Point(0, 146);
            this.btn_alumnos.Name = "btn_alumnos";
            this.btn_alumnos.Size = new System.Drawing.Size(201, 58);
            this.btn_alumnos.TabIndex = 2;
            this.btn_alumnos.Text = "Alumnos";
            this.btn_alumnos.UseVisualStyleBackColor = true;
            this.btn_alumnos.Click += new System.EventHandler(this.btn_alumnos_Click);
            // 
            // menu_inicio1
            // 
            this.menu_inicio1.Location = new System.Drawing.Point(201, 85);
            this.menu_inicio1.Name = "menu_inicio1";
            this.menu_inicio1.Size = new System.Drawing.Size(658, 429);
            this.menu_inicio1.TabIndex = 0;
            // 
            // menu_alumnos1
            // 
            this.menu_alumnos1.Location = new System.Drawing.Point(201, 85);
            this.menu_alumnos1.Name = "menu_alumnos1";
            this.menu_alumnos1.Size = new System.Drawing.Size(658, 429);
            this.menu_alumnos1.TabIndex = 1;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 514);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_acercaDe;
        private System.Windows.Forms.Button btn_ajustes;
        private System.Windows.Forms.Button btn_empleados;
        private System.Windows.Forms.Button btn_alumnos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private menu_alumnos menu_alumnos1;
        private menu_inicio menu_inicio1;
    }
}
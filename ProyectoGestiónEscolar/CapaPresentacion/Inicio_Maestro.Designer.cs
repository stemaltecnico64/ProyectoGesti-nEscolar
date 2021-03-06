﻿namespace CapaPresentacion
{
    partial class Inicio_Maestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Maestro));
            this.btn_maximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_asistencia = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_acercaDe = new System.Windows.Forms.Button();
            this.btn_restaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.Btn_Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_ajustes = new System.Windows.Forms.Button();
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.TopSidePanel = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.btn_alumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.SideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.ImageActive = null;
            this.btn_maximizar.Location = new System.Drawing.Point(560, 3);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(30, 24);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_maximizar.TabIndex = 49;
            this.btn_maximizar.TabStop = false;
            this.btn_maximizar.Zoom = 10;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(271, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ingreso";
            // 
            // btn_asistencia
            // 
            this.btn_asistencia.FlatAppearance.BorderSize = 0;
            this.btn_asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asistencia.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_asistencia.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_asistencia.Image = ((System.Drawing.Image)(resources.GetObject("btn_asistencia.Image")));
            this.btn_asistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asistencia.Location = new System.Drawing.Point(2, 146);
            this.btn_asistencia.Name = "btn_asistencia";
            this.btn_asistencia.Size = new System.Drawing.Size(170, 58);
            this.btn_asistencia.TabIndex = 23;
            this.btn_asistencia.Text = "Asistencia";
            this.btn_asistencia.UseVisualStyleBackColor = true;
            this.btn_asistencia.Click += new System.EventHandler(this.btn_asistencia_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_inicio.Image")));
            this.btn_inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inicio.Location = new System.Drawing.Point(1, 82);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(171, 58);
            this.btn_inicio.TabIndex = 15;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_acercaDe
            // 
            this.btn_acercaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_acercaDe.FlatAppearance.BorderSize = 0;
            this.btn_acercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acercaDe.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acercaDe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_acercaDe.Image = ((System.Drawing.Image)(resources.GetObject("btn_acercaDe.Image")));
            this.btn_acercaDe.Location = new System.Drawing.Point(135, 404);
            this.btn_acercaDe.Name = "btn_acercaDe";
            this.btn_acercaDe.Size = new System.Drawing.Size(37, 40);
            this.btn_acercaDe.TabIndex = 12;
            this.btn_acercaDe.UseVisualStyleBackColor = true;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.BackColor = System.Drawing.Color.Transparent;
            this.btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("btn_restaurar.Image")));
            this.btn_restaurar.ImageActive = null;
            this.btn_restaurar.Location = new System.Drawing.Point(560, 3);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(30, 24);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 51;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Zoom = 10;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.ImageActive = null;
            this.btn_minimizar.Location = new System.Drawing.Point(533, 3);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(30, 24);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 50;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Zoom = 10;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.Tomato;
            this.TitlePanel.Controls.Add(this.btn_restaurar);
            this.TitlePanel.Controls.Add(this.btn_minimizar);
            this.TitlePanel.Controls.Add(this.btn_maximizar);
            this.TitlePanel.Controls.Add(this.Btn_Cerrar);
            this.TitlePanel.Controls.Add(this.lblTitle);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(172, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(620, 82);
            this.TitlePanel.TabIndex = 4;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.ImageActive = null;
            this.Btn_Cerrar.Location = new System.Drawing.Point(587, 3);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(30, 24);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 48;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Zoom = 10;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // btn_ajustes
            // 
            this.btn_ajustes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ajustes.FlatAppearance.BorderSize = 0;
            this.btn_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajustes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajustes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_ajustes.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajustes.Image")));
            this.btn_ajustes.Location = new System.Drawing.Point(0, 404);
            this.btn_ajustes.Name = "btn_ajustes";
            this.btn_ajustes.Size = new System.Drawing.Size(37, 40);
            this.btn_ajustes.TabIndex = 11;
            this.btn_ajustes.UseVisualStyleBackColor = true;
            this.btn_ajustes.Click += new System.EventHandler(this.btn_ajustes_Click);
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.SideMenuPanel.Controls.Add(this.btn_alumnos);
            this.SideMenuPanel.Controls.Add(this.btn_reportes);
            this.SideMenuPanel.Controls.Add(this.btn_asistencia);
            this.SideMenuPanel.Controls.Add(this.btn_inicio);
            this.SideMenuPanel.Controls.Add(this.btn_acercaDe);
            this.SideMenuPanel.Controls.Add(this.btn_ajustes);
            this.SideMenuPanel.Controls.Add(this.TopSidePanel);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(172, 444);
            this.SideMenuPanel.TabIndex = 3;
            // 
            // btn_reportes
            // 
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_reportes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reportes.Image")));
            this.btn_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reportes.Location = new System.Drawing.Point(2, 210);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(170, 58);
            this.btn_reportes.TabIndex = 24;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // TopSidePanel
            // 
            this.TopSidePanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.TopSidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSidePanel.Location = new System.Drawing.Point(0, 0);
            this.TopSidePanel.Name = "TopSidePanel";
            this.TopSidePanel.Size = new System.Drawing.Size(172, 82);
            this.TopSidePanel.TabIndex = 0;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(172, 82);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(620, 362);
            this.DesktopPanel.TabIndex = 6;
            // 
            // btn_alumnos
            // 
            this.btn_alumnos.FlatAppearance.BorderSize = 0;
            this.btn_alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alumnos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alumnos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_alumnos.Image = ((System.Drawing.Image)(resources.GetObject("btn_alumnos.Image")));
            this.btn_alumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alumnos.Location = new System.Drawing.Point(1, 274);
            this.btn_alumnos.Name = "btn_alumnos";
            this.btn_alumnos.Size = new System.Drawing.Size(171, 52);
            this.btn_alumnos.TabIndex = 25;
            this.btn_alumnos.Text = "Alumnos";
            this.btn_alumnos.UseVisualStyleBackColor = true;
            this.btn_alumnos.Click += new System.EventHandler(this.btn_alumnos_Click);
            // 
            // Inicio_Maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 444);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.SideMenuPanel);
            this.Name = "Inicio_Maestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio_Maestro";
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.SideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_maximizar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_asistencia;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_acercaDe;
        private Bunifu.Framework.UI.BunifuImageButton btn_restaurar;
        private Bunifu.Framework.UI.BunifuImageButton btn_minimizar;
        private System.Windows.Forms.Panel TitlePanel;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Cerrar;
        private System.Windows.Forms.Button btn_ajustes;
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Button btn_reportes;
        private System.Windows.Forms.Panel TopSidePanel;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Button btn_alumnos;
    }
}
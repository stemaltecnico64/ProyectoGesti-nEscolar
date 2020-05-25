namespace CapaPresentacion
{
    partial class Listado_Inscripciones_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.Tabla_Inscripciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Inscripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelTitleBar.Controls.Add(this.btExit);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(878, 61);
            this.panelTitleBar.TabIndex = 173;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(831, 3);
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
            this.lblTitle.Location = new System.Drawing.Point(345, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Alumnos Inscritos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(303, 81);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(226, 28);
            this.txtBuscar.TabIndex = 176;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cbBuscar
            // 
            this.cbBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Codigo Escolar",
            "Ciclo",
            "Alumno",
            "Carrera",
            "Grado",
            "Sección"});
            this.cbBuscar.Location = new System.Drawing.Point(28, 81);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(233, 28);
            this.cbBuscar.TabIndex = 175;
            // 
            // Tabla_Inscripciones
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Tabla_Inscripciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabla_Inscripciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabla_Inscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla_Inscripciones.BackgroundColor = System.Drawing.Color.White;
            this.Tabla_Inscripciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla_Inscripciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Tabla_Inscripciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla_Inscripciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Tabla_Inscripciones.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla_Inscripciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabla_Inscripciones.DoubleBuffered = true;
            this.Tabla_Inscripciones.EnableHeadersVisualStyles = false;
            this.Tabla_Inscripciones.HeaderBgColor = System.Drawing.Color.Maroon;
            this.Tabla_Inscripciones.HeaderForeColor = System.Drawing.Color.White;
            this.Tabla_Inscripciones.Location = new System.Drawing.Point(12, 130);
            this.Tabla_Inscripciones.Name = "Tabla_Inscripciones";
            this.Tabla_Inscripciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla_Inscripciones.RowHeadersVisible = false;
            this.Tabla_Inscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabla_Inscripciones.Size = new System.Drawing.Size(839, 278);
            this.Tabla_Inscripciones.TabIndex = 174;
            this.Tabla_Inscripciones.DoubleClick += new System.EventHandler(this.Tabla_Inscripciones_DoubleClick);
            // 
            // Listado_Inscripciones_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 422);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.Tabla_Inscripciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_Inscripciones_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado_Inscripciones_Admin";
            this.Load += new System.EventHandler(this.Listado_Inscripciones_Admin_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Inscripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Tabla_Inscripciones;
    }
}
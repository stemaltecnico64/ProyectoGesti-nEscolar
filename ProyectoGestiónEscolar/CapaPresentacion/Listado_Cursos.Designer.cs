namespace CapaPresentacion
{
    partial class Listado_Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Cursos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Tabla_Cursos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(458, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 166;
            this.label2.Text = "Borrar Curso";
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
            this.panelTitleBar.Size = new System.Drawing.Size(863, 61);
            this.panelTitleBar.TabIndex = 159;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(820, 3);
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
            this.lblTitle.Location = new System.Drawing.Point(337, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Catalogo de Cursos";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageActive = null;
            this.btn_guardar.Location = new System.Drawing.Point(390, 409);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 49);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 163;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Zoom = 10;
            // 
            // Tabla_Cursos
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.Tabla_Cursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Tabla_Cursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabla_Cursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla_Cursos.BackgroundColor = System.Drawing.Color.White;
            this.Tabla_Cursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla_Cursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Tabla_Cursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla_Cursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Tabla_Cursos.ColumnHeadersHeight = 50;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla_Cursos.DefaultCellStyle = dataGridViewCellStyle9;
            this.Tabla_Cursos.DoubleBuffered = true;
            this.Tabla_Cursos.EnableHeadersVisualStyles = false;
            this.Tabla_Cursos.HeaderBgColor = System.Drawing.Color.Maroon;
            this.Tabla_Cursos.HeaderForeColor = System.Drawing.Color.White;
            this.Tabla_Cursos.Location = new System.Drawing.Point(12, 130);
            this.Tabla_Cursos.Name = "Tabla_Cursos";
            this.Tabla_Cursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla_Cursos.RowHeadersVisible = false;
            this.Tabla_Cursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabla_Cursos.Size = new System.Drawing.Size(839, 273);
            this.Tabla_Cursos.TabIndex = 160;
            this.Tabla_Cursos.DoubleClick += new System.EventHandler(this.Tabla_Cursos_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(288, 82);
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
            "Carrera",
            "Grado",
            "Curso"});
            this.cbBuscar.Location = new System.Drawing.Point(12, 82);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(233, 28);
            this.cbBuscar.TabIndex = 175;
            // 
            // Listado_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 468);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.Tabla_Cursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado_Cursos";
            this.Load += new System.EventHandler(this.Listado_Cursos_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Cursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton btn_guardar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Tabla_Cursos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
    }
}
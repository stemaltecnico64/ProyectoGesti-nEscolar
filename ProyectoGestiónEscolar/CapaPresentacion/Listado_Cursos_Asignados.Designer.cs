namespace CapaPresentacion
{
    partial class Listado_Cursos_Asignados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_Cursos_Asignados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.Tabla_Cursos_A = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Cursos_A)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(411, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 158;
            this.label2.Text = "Borrar Asignación";
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
            this.panelTitleBar.Size = new System.Drawing.Size(867, 61);
            this.panelTitleBar.TabIndex = 150;
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
            this.lblTitle.Location = new System.Drawing.Point(339, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cursos Asignados";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageActive = null;
            this.btn_guardar.Location = new System.Drawing.Point(344, 400);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(54, 49);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 154;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Zoom = 10;
            // 
            // Tabla_Cursos_A
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Tabla_Cursos_A.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Tabla_Cursos_A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabla_Cursos_A.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla_Cursos_A.BackgroundColor = System.Drawing.Color.White;
            this.Tabla_Cursos_A.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla_Cursos_A.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Tabla_Cursos_A.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla_Cursos_A.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Tabla_Cursos_A.ColumnHeadersHeight = 50;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla_Cursos_A.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tabla_Cursos_A.DoubleBuffered = true;
            this.Tabla_Cursos_A.EnableHeadersVisualStyles = false;
            this.Tabla_Cursos_A.HeaderBgColor = System.Drawing.Color.Maroon;
            this.Tabla_Cursos_A.HeaderForeColor = System.Drawing.Color.White;
            this.Tabla_Cursos_A.Location = new System.Drawing.Point(21, 121);
            this.Tabla_Cursos_A.Name = "Tabla_Cursos_A";
            this.Tabla_Cursos_A.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla_Cursos_A.RowHeadersVisible = false;
            this.Tabla_Cursos_A.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabla_Cursos_A.Size = new System.Drawing.Size(834, 273);
            this.Tabla_Cursos_A.TabIndex = 151;
            this.Tabla_Cursos_A.DoubleClick += new System.EventHandler(this.Tabla_Cursos_A_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(415, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(226, 28);
            this.txtBuscar.TabIndex = 174;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cbBuscar
            // 
            this.cbBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Maestro",
            "Carrera",
            "Grado",
            "Curso"});
            this.cbBuscar.Location = new System.Drawing.Point(165, 77);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(233, 28);
            this.cbBuscar.TabIndex = 173;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 175;
            this.label1.Text = "Buscar Por:";
            // 
            // Listado_Cursos_Asignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.Tabla_Cursos_A);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_Cursos_Asignados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado_Cursos_Asignados";
            this.Load += new System.EventHandler(this.Listado_Cursos_Asignados_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Cursos_A)).EndInit();
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
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
        public Bunifu.Framework.UI.BunifuCustomDataGrid Tabla_Cursos_A;
        private System.Windows.Forms.Label label1;
    }
}
namespace CapaPresentacion
{
    partial class Reporte_Notas_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Notas_Admin));
            this.Tabla_Notas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdNota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNota2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPromedio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGrado = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCurso = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_guardar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSeccion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCarrera = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCiclo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Notas)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla_Notas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Tabla_Notas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabla_Notas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabla_Notas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tabla_Notas.BackgroundColor = System.Drawing.Color.White;
            this.Tabla_Notas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla_Notas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Tabla_Notas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabla_Notas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Tabla_Notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabla_Notas.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabla_Notas.DoubleBuffered = true;
            this.Tabla_Notas.EnableHeadersVisualStyles = false;
            this.Tabla_Notas.HeaderBgColor = System.Drawing.Color.Maroon;
            this.Tabla_Notas.HeaderForeColor = System.Drawing.Color.White;
            this.Tabla_Notas.Location = new System.Drawing.Point(385, 118);
            this.Tabla_Notas.Name = "Tabla_Notas";
            this.Tabla_Notas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Tabla_Notas.RowHeadersVisible = false;
            this.Tabla_Notas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tabla_Notas.Size = new System.Drawing.Size(953, 443);
            this.Tabla_Notas.TabIndex = 160;
            this.Tabla_Notas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_Usuarios_CellContentClick);
            this.Tabla_Notas.DoubleClick += new System.EventHandler(this.Tabla_Notas_DoubleClick);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.icons8_Close_Window_48px;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(1312, 7);
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
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(403, 83);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Buscar Por:";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelTitleBar.Controls.Add(this.label2);
            this.panelTitleBar.Controls.Add(this.btExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1350, 54);
            this.panelTitleBar.TabIndex = 159;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(513, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 26);
            this.label2.TabIndex = 218;
            this.label2.Text = "Reporte de Notas Escolares";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(785, 84);
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
            "Ciclo",
            "Alumno",
            "Carrera",
            "Grado",
            "Sección",
            "Maestro",
            "Curso"});
            this.cbBuscar.Location = new System.Drawing.Point(530, 83);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(233, 28);
            this.cbBuscar.TabIndex = 175;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCiclo);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtCarrera);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSeccion);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtCurso);
            this.panel1.Controls.Add(this.txtGrado);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPromedio);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNota4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNota3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNota2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNota1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIdNota);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 501);
            this.panel1.TabIndex = 177;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // txtIdNota
            // 
            this.txtIdNota.BackColor = System.Drawing.Color.LightGray;
            this.txtIdNota.Location = new System.Drawing.Point(74, 11);
            this.txtIdNota.Name = "txtIdNota";
            this.txtIdNota.Size = new System.Drawing.Size(72, 20);
            this.txtIdNota.TabIndex = 186;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(21, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 187;
            this.label3.Text = "Nota Bloque 1";
            // 
            // txtNota1
            // 
            this.txtNota1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNota1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNota1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNota1.HintForeColor = System.Drawing.Color.Empty;
            this.txtNota1.HintText = "";
            this.txtNota1.isPassword = false;
            this.txtNota1.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtNota1.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNota1.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtNota1.LineThickness = 3;
            this.txtNota1.Location = new System.Drawing.Point(11, 256);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(135, 33);
            this.txtNota1.TabIndex = 192;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNota2
            // 
            this.txtNota2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNota2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNota2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNota2.HintForeColor = System.Drawing.Color.Empty;
            this.txtNota2.HintText = "";
            this.txtNota2.isPassword = false;
            this.txtNota2.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtNota2.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNota2.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtNota2.LineThickness = 3;
            this.txtNota2.Location = new System.Drawing.Point(207, 256);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(135, 33);
            this.txtNota2.TabIndex = 194;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(217, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 193;
            this.label4.Text = "Nota Bloque 2";
            // 
            // txtNota3
            // 
            this.txtNota3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNota3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNota3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNota3.HintForeColor = System.Drawing.Color.Empty;
            this.txtNota3.HintText = "";
            this.txtNota3.isPassword = false;
            this.txtNota3.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtNota3.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNota3.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtNota3.LineThickness = 3;
            this.txtNota3.Location = new System.Drawing.Point(11, 346);
            this.txtNota3.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(135, 33);
            this.txtNota3.TabIndex = 196;
            this.txtNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(21, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 195;
            this.label5.Text = "Nota Bloque 3";
            // 
            // txtNota4
            // 
            this.txtNota4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNota4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNota4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNota4.HintForeColor = System.Drawing.Color.Empty;
            this.txtNota4.HintText = "";
            this.txtNota4.isPassword = false;
            this.txtNota4.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtNota4.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNota4.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtNota4.LineThickness = 3;
            this.txtNota4.Location = new System.Drawing.Point(207, 346);
            this.txtNota4.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(135, 33);
            this.txtNota4.TabIndex = 198;
            this.txtNota4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(217, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 197;
            this.label6.Text = "Nota Bloque 4";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPromedio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPromedio.HintForeColor = System.Drawing.Color.Empty;
            this.txtPromedio.HintText = "";
            this.txtPromedio.isPassword = false;
            this.txtPromedio.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtPromedio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPromedio.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtPromedio.LineThickness = 3;
            this.txtPromedio.Location = new System.Drawing.Point(13, 432);
            this.txtPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(135, 33);
            this.txtPromedio.TabIndex = 200;
            this.txtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(43, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 23);
            this.label7.TabIndex = 199;
            this.label7.Text = "Promedio";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(169, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 202;
            this.label9.Text = "Sección:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(7, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 23);
            this.label11.TabIndex = 204;
            this.label11.Text = "Grado:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(24, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 23);
            this.label12.TabIndex = 205;
            this.label12.Text = "Curso:";
            // 
            // txtGrado
            // 
            this.txtGrado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGrado.HintForeColor = System.Drawing.Color.Empty;
            this.txtGrado.HintText = "";
            this.txtGrado.isPassword = false;
            this.txtGrado.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtGrado.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGrado.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtGrado.LineThickness = 3;
            this.txtGrado.Location = new System.Drawing.Point(74, 47);
            this.txtGrado.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(94, 33);
            this.txtGrado.TabIndex = 208;
            this.txtGrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCurso
            // 
            this.txtCurso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurso.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCurso.HintForeColor = System.Drawing.Color.Empty;
            this.txtCurso.HintText = "";
            this.txtCurso.isPassword = false;
            this.txtCurso.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtCurso.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCurso.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtCurso.LineThickness = 3;
            this.txtCurso.Location = new System.Drawing.Point(105, 184);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(237, 33);
            this.txtCurso.TabIndex = 209;
            this.txtCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageActive = null;
            this.btn_guardar.Location = new System.Drawing.Point(221, 411);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(56, 54);
            this.btn_guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_guardar.TabIndex = 210;
            this.btn_guardar.TabStop = false;
            this.btn_guardar.Zoom = 10;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(283, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 211;
            this.label15.Text = "Guardar";
            // 
            // txtSeccion
            // 
            this.txtSeccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeccion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSeccion.HintForeColor = System.Drawing.Color.Empty;
            this.txtSeccion.HintText = "";
            this.txtSeccion.isPassword = false;
            this.txtSeccion.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtSeccion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSeccion.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtSeccion.LineThickness = 3;
            this.txtSeccion.Location = new System.Drawing.Point(246, 4);
            this.txtSeccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(84, 33);
            this.txtSeccion.TabIndex = 212;
            this.txtSeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCarrera.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCarrera.HintForeColor = System.Drawing.Color.Empty;
            this.txtCarrera.HintText = "";
            this.txtCarrera.isPassword = false;
            this.txtCarrera.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtCarrera.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCarrera.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtCarrera.LineThickness = 3;
            this.txtCarrera.Location = new System.Drawing.Point(105, 145);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(237, 33);
            this.txtCarrera.TabIndex = 216;
            this.txtCarrera.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(105, 104);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 33);
            this.txtNombre.TabIndex = 215;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(21, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 23);
            this.label10.TabIndex = 214;
            this.label10.Text = "Carrera:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(21, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 213;
            this.label8.Text = "Alumno:";
            // 
            // txtCiclo
            // 
            this.txtCiclo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCiclo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCiclo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCiclo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCiclo.HintText = "";
            this.txtCiclo.isPassword = false;
            this.txtCiclo.LineFocusedColor = System.Drawing.Color.Sienna;
            this.txtCiclo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCiclo.LineMouseHoverColor = System.Drawing.Color.Salmon;
            this.txtCiclo.LineThickness = 3;
            this.txtCiclo.Location = new System.Drawing.Point(246, 47);
            this.txtCiclo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(94, 33);
            this.txtCiclo.TabIndex = 218;
            this.txtCiclo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(189, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 23);
            this.label13.TabIndex = 217;
            this.label13.Text = "Ciclo:";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1077, 60);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(56, 54);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 212;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Sienna;
            this.label14.Location = new System.Drawing.Point(1139, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 23);
            this.label14.TabIndex = 213;
            this.label14.Text = "Imprimir Notas";
            // 
            // Reporte_Notas_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 573);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.Tabla_Notas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_Notas_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte_Notas";
            this.Load += new System.EventHandler(this.Reporte_Notas_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Notas)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid Tabla_Notas;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTitleBar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNota1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdNota;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCurso;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGrado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPromedio;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNota4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNota3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNota2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSeccion;
        private Bunifu.Framework.UI.BunifuImageButton btn_guardar;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCiclo;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCarrera;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label14;
    }
}
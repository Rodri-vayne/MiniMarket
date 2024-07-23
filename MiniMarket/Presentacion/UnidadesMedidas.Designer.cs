
namespace MiniMarket.Presentacion
{
    partial class UnidadesMedidas
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPrincipalMedida = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataMedida = new System.Windows.Forms.DataGridView();
            this.idmedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreviaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lmedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReporteMedida = new System.Windows.Forms.Button();
            this.btnAgregarMedida = new System.Windows.Forms.Button();
            this.btnBuscarMedida = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBuscarMedida = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarMedida = new System.Windows.Forms.Button();
            this.btnActualizarMedida = new System.Windows.Forms.Button();
            this.btnVolverMedida = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDescripcionMedida = new System.Windows.Forms.TextBox();
            this.txtAbreviaturaMedida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPrincipalMedida.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmedidaBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidades Medida";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.tabPrincipalMedida);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 510);
            this.panel2.TabIndex = 1;
            // 
            // tabPrincipalMedida
            // 
            this.tabPrincipalMedida.Controls.Add(this.tabPage1);
            this.tabPrincipalMedida.Controls.Add(this.tabPage2);
            this.tabPrincipalMedida.Location = new System.Drawing.Point(15, 15);
            this.tabPrincipalMedida.Name = "tabPrincipalMedida";
            this.tabPrincipalMedida.SelectedIndex = 0;
            this.tabPrincipalMedida.Size = new System.Drawing.Size(890, 474);
            this.tabPrincipalMedida.TabIndex = 0;
            this.tabPrincipalMedida.Click += new System.EventHandler(this.tabPrincipalMedida_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.dataMedida);
            this.tabPage1.Controls.Add(this.btnReporteMedida);
            this.tabPage1.Controls.Add(this.btnAgregarMedida);
            this.tabPage1.Controls.Add(this.btnBuscarMedida);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.txtBuscarMedida);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado Medidas";
            // 
            // dataMedida
            // 
            this.dataMedida.AllowUserToAddRows = false;
            this.dataMedida.AllowUserToDeleteRows = false;
            this.dataMedida.AutoGenerateColumns = false;
            this.dataMedida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMedida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dataMedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMedida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMedida.ColumnHeadersHeight = 31;
            this.dataMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmedidaDataGridViewTextBoxColumn,
            this.abreviaturaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dataMedida.DataSource = this.lmedidaBindingSource;
            this.dataMedida.EnableHeadersVisualStyles = false;
            this.dataMedida.Location = new System.Drawing.Point(26, 84);
            this.dataMedida.Name = "dataMedida";
            this.dataMedida.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMedida.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataMedida.RowHeadersVisible = false;
            this.dataMedida.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMedida.Size = new System.Drawing.Size(829, 346);
            this.dataMedida.TabIndex = 4;
            this.dataMedida.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMedida_CellClick);
            // 
            // idmedidaDataGridViewTextBoxColumn
            // 
            this.idmedidaDataGridViewTextBoxColumn.DataPropertyName = "id_medida";
            this.idmedidaDataGridViewTextBoxColumn.HeaderText = "id_medida";
            this.idmedidaDataGridViewTextBoxColumn.Name = "idmedidaDataGridViewTextBoxColumn";
            this.idmedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmedidaDataGridViewTextBoxColumn.Width = 119;
            // 
            // abreviaturaDataGridViewTextBoxColumn
            // 
            this.abreviaturaDataGridViewTextBoxColumn.DataPropertyName = "abreviatura";
            this.abreviaturaDataGridViewTextBoxColumn.HeaderText = "abreviatura";
            this.abreviaturaDataGridViewTextBoxColumn.Name = "abreviaturaDataGridViewTextBoxColumn";
            this.abreviaturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.abreviaturaDataGridViewTextBoxColumn.Width = 127;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::MiniMarket.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 63;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::MiniMarket.Properties.Resources.borrar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 81;
            // 
            // lmedidaBindingSource
            // 
            this.lmedidaBindingSource.DataSource = typeof(MiniMarket.Logica.L_medida);
            // 
            // btnReporteMedida
            // 
            this.btnReporteMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnReporteMedida.FlatAppearance.BorderSize = 0;
            this.btnReporteMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteMedida.ForeColor = System.Drawing.Color.White;
            this.btnReporteMedida.Location = new System.Drawing.Point(549, 27);
            this.btnReporteMedida.Name = "btnReporteMedida";
            this.btnReporteMedida.Size = new System.Drawing.Size(161, 33);
            this.btnReporteMedida.TabIndex = 3;
            this.btnReporteMedida.Text = "Reporte";
            this.btnReporteMedida.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMedida
            // 
            this.btnAgregarMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnAgregarMedida.FlatAppearance.BorderSize = 0;
            this.btnAgregarMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMedida.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMedida.Location = new System.Drawing.Point(345, 27);
            this.btnAgregarMedida.Name = "btnAgregarMedida";
            this.btnAgregarMedida.Size = new System.Drawing.Size(166, 33);
            this.btnAgregarMedida.TabIndex = 3;
            this.btnAgregarMedida.Text = "Agregar Medida";
            this.btnAgregarMedida.UseVisualStyleBackColor = false;
            this.btnAgregarMedida.Click += new System.EventHandler(this.btnAgregarMedida_Click);
            // 
            // btnBuscarMedida
            // 
            this.btnBuscarMedida.BackgroundImage = global::MiniMarket.Properties.Resources.buscar__1_;
            this.btnBuscarMedida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarMedida.FlatAppearance.BorderSize = 0;
            this.btnBuscarMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMedida.Location = new System.Drawing.Point(265, 33);
            this.btnBuscarMedida.Name = "btnBuscarMedida";
            this.btnBuscarMedida.Size = new System.Drawing.Size(31, 27);
            this.btnBuscarMedida.TabIndex = 2;
            this.btnBuscarMedida.UseVisualStyleBackColor = true;
            this.btnBuscarMedida.Click += new System.EventHandler(this.btnBuscarMedida_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.panel4.Location = new System.Drawing.Point(26, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 3);
            this.panel4.TabIndex = 1;
            // 
            // txtBuscarMedida
            // 
            this.txtBuscarMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtBuscarMedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarMedida.Location = new System.Drawing.Point(26, 34);
            this.txtBuscarMedida.MaxLength = 255;
            this.txtBuscarMedida.Name = "txtBuscarMedida";
            this.txtBuscarMedida.Size = new System.Drawing.Size(233, 20);
            this.txtBuscarMedida.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.txtDescripcionMedida);
            this.tabPage2.Controls.Add(this.txtAbreviaturaMedida);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuardarMedida);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarMedida);
            this.flowLayoutPanel1.Controls.Add(this.btnVolverMedida);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 215);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(523, 43);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnGuardarMedida
            // 
            this.btnGuardarMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnGuardarMedida.Enabled = false;
            this.btnGuardarMedida.FlatAppearance.BorderSize = 0;
            this.btnGuardarMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMedida.ForeColor = System.Drawing.Color.White;
            this.btnGuardarMedida.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarMedida.Name = "btnGuardarMedida";
            this.btnGuardarMedida.Size = new System.Drawing.Size(166, 33);
            this.btnGuardarMedida.TabIndex = 4;
            this.btnGuardarMedida.Text = "Guardar Medida";
            this.btnGuardarMedida.UseVisualStyleBackColor = false;
            this.btnGuardarMedida.Click += new System.EventHandler(this.btnGuardarMedida_Click);
            // 
            // btnActualizarMedida
            // 
            this.btnActualizarMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnActualizarMedida.Enabled = false;
            this.btnActualizarMedida.FlatAppearance.BorderSize = 0;
            this.btnActualizarMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMedida.ForeColor = System.Drawing.Color.White;
            this.btnActualizarMedida.Location = new System.Drawing.Point(175, 3);
            this.btnActualizarMedida.Name = "btnActualizarMedida";
            this.btnActualizarMedida.Size = new System.Drawing.Size(166, 33);
            this.btnActualizarMedida.TabIndex = 5;
            this.btnActualizarMedida.Text = "Actualizar Medida";
            this.btnActualizarMedida.UseVisualStyleBackColor = false;
            this.btnActualizarMedida.Click += new System.EventHandler(this.btnActualizarMedida_Click);
            // 
            // btnVolverMedida
            // 
            this.btnVolverMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnVolverMedida.Enabled = false;
            this.btnVolverMedida.FlatAppearance.BorderSize = 0;
            this.btnVolverMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverMedida.ForeColor = System.Drawing.Color.White;
            this.btnVolverMedida.Location = new System.Drawing.Point(347, 3);
            this.btnVolverMedida.Name = "btnVolverMedida";
            this.btnVolverMedida.Size = new System.Drawing.Size(166, 33);
            this.btnVolverMedida.TabIndex = 6;
            this.btnVolverMedida.Text = "Volver";
            this.btnVolverMedida.UseVisualStyleBackColor = false;
            this.btnVolverMedida.Click += new System.EventHandler(this.btnVolverMedida_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.panel5.Location = new System.Drawing.Point(170, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 3);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.panel3.Location = new System.Drawing.Point(170, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 3);
            this.panel3.TabIndex = 3;
            // 
            // txtDescripcionMedida
            // 
            this.txtDescripcionMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtDescripcionMedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionMedida.Enabled = false;
            this.txtDescripcionMedida.Location = new System.Drawing.Point(170, 135);
            this.txtDescripcionMedida.MaxLength = 255;
            this.txtDescripcionMedida.Name = "txtDescripcionMedida";
            this.txtDescripcionMedida.Size = new System.Drawing.Size(233, 20);
            this.txtDescripcionMedida.TabIndex = 2;
            // 
            // txtAbreviaturaMedida
            // 
            this.txtAbreviaturaMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtAbreviaturaMedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAbreviaturaMedida.Enabled = false;
            this.txtAbreviaturaMedida.Location = new System.Drawing.Point(170, 74);
            this.txtAbreviaturaMedida.MaxLength = 255;
            this.txtAbreviaturaMedida.Name = "txtAbreviaturaMedida";
            this.txtAbreviaturaMedida.Size = new System.Drawing.Size(233, 20);
            this.txtAbreviaturaMedida.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripcion (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Abreviatura (*)";
            // 
            // UnidadesMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnidadesMedidas";
            this.Text = "Unidade Medidas";
            this.Load += new System.EventHandler(this.UnidadesMedidas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPrincipalMedida.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmedidaBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabPrincipalMedida;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBuscarMedida;
        private System.Windows.Forms.Button btnBuscarMedida;
        private System.Windows.Forms.Button btnAgregarMedida;
        private System.Windows.Forms.Button btnReporteMedida;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDescripcionMedida;
        private System.Windows.Forms.TextBox txtAbreviaturaMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGuardarMedida;
        private System.Windows.Forms.Button btnActualizarMedida;
        private System.Windows.Forms.Button btnVolverMedida;
        private System.Windows.Forms.DataGridView dataMedida;
        private System.Windows.Forms.BindingSource lmedidaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abreviaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
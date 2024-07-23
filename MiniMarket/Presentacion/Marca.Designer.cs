
namespace MiniMarket.Presentacion
{
    partial class Marca
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
            this.tabPrincipalMarca = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataMarca = new System.Windows.Forms.DataGridView();
            this.idmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lmarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReporteMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarMarca = new System.Windows.Forms.Button();
            this.btnActualizarMarca = new System.Windows.Forms.Button();
            this.btnVolverMarca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPrincipalMarca.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmarcaBindingSource)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.tabPrincipalMarca);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 510);
            this.panel2.TabIndex = 1;
            // 
            // tabPrincipalMarca
            // 
            this.tabPrincipalMarca.Controls.Add(this.tabPage1);
            this.tabPrincipalMarca.Controls.Add(this.tabPage2);
            this.tabPrincipalMarca.Location = new System.Drawing.Point(16, 15);
            this.tabPrincipalMarca.Name = "tabPrincipalMarca";
            this.tabPrincipalMarca.SelectedIndex = 0;
            this.tabPrincipalMarca.Size = new System.Drawing.Size(890, 474);
            this.tabPrincipalMarca.TabIndex = 0;
            this.tabPrincipalMarca.Click += new System.EventHandler(this.tabPrincipalMarca_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.dataMarca);
            this.tabPage1.Controls.Add(this.btnReporteMarca);
            this.tabPage1.Controls.Add(this.btnAgregarMarca);
            this.tabPage1.Controls.Add(this.btnBuscarMarca);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.txtBuscarMarca);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado Marca";
            // 
            // dataMarca
            // 
            this.dataMarca.AllowUserToAddRows = false;
            this.dataMarca.AllowUserToDeleteRows = false;
            this.dataMarca.AutoGenerateColumns = false;
            this.dataMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMarca.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dataMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMarca.ColumnHeadersHeight = 31;
            this.dataMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmarcaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dataMarca.DataSource = this.lmarcaBindingSource;
            this.dataMarca.EnableHeadersVisualStyles = false;
            this.dataMarca.Location = new System.Drawing.Point(30, 89);
            this.dataMarca.Name = "dataMarca";
            this.dataMarca.ReadOnly = true;
            this.dataMarca.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dataMarca.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataMarca.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMarca.Size = new System.Drawing.Size(824, 331);
            this.dataMarca.TabIndex = 4;
            this.dataMarca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMarca_CellClick);
            // 
            // idmarcaDataGridViewTextBoxColumn
            // 
            this.idmarcaDataGridViewTextBoxColumn.DataPropertyName = "id_marca";
            this.idmarcaDataGridViewTextBoxColumn.HeaderText = "id_marca";
            this.idmarcaDataGridViewTextBoxColumn.Name = "idmarcaDataGridViewTextBoxColumn";
            this.idmarcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmarcaDataGridViewTextBoxColumn.Width = 108;
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
            // lmarcaBindingSource
            // 
            this.lmarcaBindingSource.DataSource = typeof(MiniMarket.Logica.L_marca);
            // 
            // btnReporteMarca
            // 
            this.btnReporteMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnReporteMarca.FlatAppearance.BorderSize = 0;
            this.btnReporteMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteMarca.ForeColor = System.Drawing.Color.White;
            this.btnReporteMarca.Location = new System.Drawing.Point(610, 28);
            this.btnReporteMarca.Name = "btnReporteMarca";
            this.btnReporteMarca.Size = new System.Drawing.Size(164, 36);
            this.btnReporteMarca.TabIndex = 3;
            this.btnReporteMarca.Text = "Reporte";
            this.btnReporteMarca.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnAgregarMarca.FlatAppearance.BorderSize = 0;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMarca.Location = new System.Drawing.Point(414, 28);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(164, 36);
            this.btnAgregarMarca.TabIndex = 3;
            this.btnAgregarMarca.Text = "Agregar Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.BackgroundImage = global::MiniMarket.Properties.Resources.buscar__1_;
            this.btnBuscarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarMarca.FlatAppearance.BorderSize = 0;
            this.btnBuscarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMarca.Location = new System.Drawing.Point(311, 36);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(40, 28);
            this.btnBuscarMarca.TabIndex = 2;
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.panel3.Location = new System.Drawing.Point(30, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 3);
            this.panel3.TabIndex = 1;
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtBuscarMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarMarca.Location = new System.Drawing.Point(30, 36);
            this.txtBuscarMarca.MaxLength = 255;
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarMarca.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.txtDescripcionMarca);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGuardarMarca);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarMarca);
            this.flowLayoutPanel1.Controls.Add(this.btnVolverMarca);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(536, 54);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnGuardarMarca
            // 
            this.btnGuardarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnGuardarMarca.FlatAppearance.BorderSize = 0;
            this.btnGuardarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMarca.ForeColor = System.Drawing.Color.White;
            this.btnGuardarMarca.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarMarca.Name = "btnGuardarMarca";
            this.btnGuardarMarca.Size = new System.Drawing.Size(171, 38);
            this.btnGuardarMarca.TabIndex = 0;
            this.btnGuardarMarca.Text = "Guardar Marca";
            this.btnGuardarMarca.UseVisualStyleBackColor = false;
            this.btnGuardarMarca.Click += new System.EventHandler(this.btnGuardarMarca_Click);
            // 
            // btnActualizarMarca
            // 
            this.btnActualizarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnActualizarMarca.FlatAppearance.BorderSize = 0;
            this.btnActualizarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMarca.ForeColor = System.Drawing.Color.White;
            this.btnActualizarMarca.Location = new System.Drawing.Point(180, 3);
            this.btnActualizarMarca.Name = "btnActualizarMarca";
            this.btnActualizarMarca.Size = new System.Drawing.Size(171, 38);
            this.btnActualizarMarca.TabIndex = 1;
            this.btnActualizarMarca.Text = "Actualizar Marca";
            this.btnActualizarMarca.UseVisualStyleBackColor = false;
            this.btnActualizarMarca.Click += new System.EventHandler(this.btnActualizarMarca_Click);
            // 
            // btnVolverMarca
            // 
            this.btnVolverMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnVolverMarca.FlatAppearance.BorderSize = 0;
            this.btnVolverMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverMarca.ForeColor = System.Drawing.Color.White;
            this.btnVolverMarca.Location = new System.Drawing.Point(357, 3);
            this.btnVolverMarca.Name = "btnVolverMarca";
            this.btnVolverMarca.Size = new System.Drawing.Size(171, 38);
            this.btnVolverMarca.TabIndex = 2;
            this.btnVolverMarca.Text = "Volver";
            this.btnVolverMarca.UseVisualStyleBackColor = false;
            this.btnVolverMarca.Click += new System.EventHandler(this.btnVolverMarca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion (*)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.panel4.Location = new System.Drawing.Point(187, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 3);
            this.panel4.TabIndex = 3;
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtDescripcionMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionMarca.Enabled = false;
            this.txtDescripcionMarca.Location = new System.Drawing.Point(187, 114);
            this.txtDescripcionMarca.MaxLength = 255;
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(275, 20);
            this.txtDescripcionMarca.TabIndex = 2;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::MiniMarket.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 63;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::MiniMarket.Properties.Resources.borrar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 81;
            // 
            // Marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Marca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.Marca_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPrincipalMarca.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lmarcaBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabPrincipalMarca;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.Button btnReporteMarca;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGuardarMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Button btnActualizarMarca;
        private System.Windows.Forms.Button btnVolverMarca;
        private System.Windows.Forms.DataGridView dataMarca;
        private System.Windows.Forms.BindingSource lmarcaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}
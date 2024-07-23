
namespace MiniMarket.Presentacion
{
    partial class Almacen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPrincipalAlmacen = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataAlmacen = new System.Windows.Forms.DataGridView();
            this.idalmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lalmacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReporteAlmacen = new System.Windows.Forms.Button();
            this.btnAgregarAlmacen = new System.Windows.Forms.Button();
            this.btnBuscarAlmacen = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscarAlmacen = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardarAlmacen = new System.Windows.Forms.Button();
            this.btnActualizarAlmacen = new System.Windows.Forms.Button();
            this.btnVolverAlamcen = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDescripcionAlmacen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPrincipalAlmacen.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlmacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lalmacenBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacen";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.tabPrincipalAlmacen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 510);
            this.panel2.TabIndex = 1;
            // 
            // tabPrincipalAlmacen
            // 
            this.tabPrincipalAlmacen.Controls.Add(this.tabPage1);
            this.tabPrincipalAlmacen.Controls.Add(this.tabPage2);
            this.tabPrincipalAlmacen.Location = new System.Drawing.Point(14, 16);
            this.tabPrincipalAlmacen.Name = "tabPrincipalAlmacen";
            this.tabPrincipalAlmacen.SelectedIndex = 0;
            this.tabPrincipalAlmacen.Size = new System.Drawing.Size(890, 474);
            this.tabPrincipalAlmacen.TabIndex = 0;
            this.tabPrincipalAlmacen.Click += new System.EventHandler(this.tabPrincipalAlmacen_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tabPage1.Controls.Add(this.dataAlmacen);
            this.tabPage1.Controls.Add(this.btnReporteAlmacen);
            this.tabPage1.Controls.Add(this.btnAgregarAlmacen);
            this.tabPage1.Controls.Add(this.btnBuscarAlmacen);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.txtBuscarAlmacen);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado De Almacen";
            // 
            // dataAlmacen
            // 
            this.dataAlmacen.AllowUserToAddRows = false;
            this.dataAlmacen.AllowUserToDeleteRows = false;
            this.dataAlmacen.AllowUserToResizeColumns = false;
            this.dataAlmacen.AutoGenerateColumns = false;
            this.dataAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataAlmacen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dataAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataAlmacen.ColumnHeadersHeight = 31;
            this.dataAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalmacenDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dataAlmacen.DataSource = this.lalmacenBindingSource;
            this.dataAlmacen.EnableHeadersVisualStyles = false;
            this.dataAlmacen.Location = new System.Drawing.Point(23, 83);
            this.dataAlmacen.Name = "dataAlmacen";
            this.dataAlmacen.ReadOnly = true;
            this.dataAlmacen.RowHeadersVisible = false;
            this.dataAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAlmacen.Size = new System.Drawing.Size(824, 337);
            this.dataAlmacen.TabIndex = 4;
            this.dataAlmacen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAlmacen_CellClick);
            // 
            // idalmacenDataGridViewTextBoxColumn
            // 
            this.idalmacenDataGridViewTextBoxColumn.DataPropertyName = "id_almacen";
            this.idalmacenDataGridViewTextBoxColumn.HeaderText = "id_almacen";
            this.idalmacenDataGridViewTextBoxColumn.Name = "idalmacenDataGridViewTextBoxColumn";
            this.idalmacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idalmacenDataGridViewTextBoxColumn.Width = 127;
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
            // lalmacenBindingSource
            // 
            this.lalmacenBindingSource.DataSource = typeof(MiniMarket.Logica.L_almacen);
            // 
            // btnReporteAlmacen
            // 
            this.btnReporteAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnReporteAlmacen.FlatAppearance.BorderSize = 0;
            this.btnReporteAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnReporteAlmacen.Location = new System.Drawing.Point(566, 19);
            this.btnReporteAlmacen.Name = "btnReporteAlmacen";
            this.btnReporteAlmacen.Size = new System.Drawing.Size(168, 40);
            this.btnReporteAlmacen.TabIndex = 3;
            this.btnReporteAlmacen.Text = "Reporte";
            this.btnReporteAlmacen.UseVisualStyleBackColor = false;
            // 
            // btnAgregarAlmacen
            // 
            this.btnAgregarAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnAgregarAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAgregarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAlmacen.Location = new System.Drawing.Point(350, 19);
            this.btnAgregarAlmacen.Name = "btnAgregarAlmacen";
            this.btnAgregarAlmacen.Size = new System.Drawing.Size(180, 41);
            this.btnAgregarAlmacen.TabIndex = 3;
            this.btnAgregarAlmacen.Text = "Agregar Almacen";
            this.btnAgregarAlmacen.UseVisualStyleBackColor = false;
            this.btnAgregarAlmacen.Click += new System.EventHandler(this.btnAgregarAlmacen_Click);
            // 
            // btnBuscarAlmacen
            // 
            this.btnBuscarAlmacen.BackgroundImage = global::MiniMarket.Properties.Resources.buscar__1_;
            this.btnBuscarAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarAlmacen.FlatAppearance.BorderSize = 0;
            this.btnBuscarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlmacen.Location = new System.Drawing.Point(282, 35);
            this.btnBuscarAlmacen.Name = "btnBuscarAlmacen";
            this.btnBuscarAlmacen.Size = new System.Drawing.Size(35, 25);
            this.btnBuscarAlmacen.TabIndex = 2;
            this.btnBuscarAlmacen.UseVisualStyleBackColor = true;
            this.btnBuscarAlmacen.Click += new System.EventHandler(this.btnBuscarAlmacen_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.panel3.Location = new System.Drawing.Point(32, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 3);
            this.panel3.TabIndex = 1;
            // 
            // txtBuscarAlmacen
            // 
            this.txtBuscarAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtBuscarAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarAlmacen.Location = new System.Drawing.Point(32, 35);
            this.txtBuscarAlmacen.MaxLength = 255;
            this.txtBuscarAlmacen.Name = "txtBuscarAlmacen";
            this.txtBuscarAlmacen.Size = new System.Drawing.Size(245, 20);
            this.txtBuscarAlmacen.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.txtDescripcionAlmacen);
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
            this.flowLayoutPanel1.Controls.Add(this.btnGuardarAlmacen);
            this.flowLayoutPanel1.Controls.Add(this.btnActualizarAlmacen);
            this.flowLayoutPanel1.Controls.Add(this.btnVolverAlamcen);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 236);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(561, 45);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnGuardarAlmacen
            // 
            this.btnGuardarAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnGuardarAlmacen.Enabled = false;
            this.btnGuardarAlmacen.FlatAppearance.BorderSize = 0;
            this.btnGuardarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAlmacen.Location = new System.Drawing.Point(3, 3);
            this.btnGuardarAlmacen.Name = "btnGuardarAlmacen";
            this.btnGuardarAlmacen.Size = new System.Drawing.Size(180, 37);
            this.btnGuardarAlmacen.TabIndex = 4;
            this.btnGuardarAlmacen.Text = "Guardar Almacen";
            this.btnGuardarAlmacen.UseVisualStyleBackColor = false;
            this.btnGuardarAlmacen.Click += new System.EventHandler(this.btnGuardarAlmacen_Click);
            // 
            // btnActualizarAlmacen
            // 
            this.btnActualizarAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnActualizarAlmacen.Enabled = false;
            this.btnActualizarAlmacen.FlatAppearance.BorderSize = 0;
            this.btnActualizarAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarAlmacen.ForeColor = System.Drawing.Color.White;
            this.btnActualizarAlmacen.Location = new System.Drawing.Point(189, 3);
            this.btnActualizarAlmacen.Name = "btnActualizarAlmacen";
            this.btnActualizarAlmacen.Size = new System.Drawing.Size(180, 37);
            this.btnActualizarAlmacen.TabIndex = 5;
            this.btnActualizarAlmacen.Text = "Actualizar Almacen";
            this.btnActualizarAlmacen.UseVisualStyleBackColor = false;
            this.btnActualizarAlmacen.Click += new System.EventHandler(this.btnActualizarAlmacen_Click);
            // 
            // btnVolverAlamcen
            // 
            this.btnVolverAlamcen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(130)))), ((int)(((byte)(155)))));
            this.btnVolverAlamcen.Enabled = false;
            this.btnVolverAlamcen.FlatAppearance.BorderSize = 0;
            this.btnVolverAlamcen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverAlamcen.ForeColor = System.Drawing.Color.White;
            this.btnVolverAlamcen.Location = new System.Drawing.Point(375, 3);
            this.btnVolverAlamcen.Name = "btnVolverAlamcen";
            this.btnVolverAlamcen.Size = new System.Drawing.Size(180, 37);
            this.btnVolverAlamcen.TabIndex = 6;
            this.btnVolverAlamcen.Text = "Volver";
            this.btnVolverAlamcen.UseVisualStyleBackColor = false;
            this.btnVolverAlamcen.Click += new System.EventHandler(this.btnVolverAlamcen_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(134)))), ((int)(((byte)(148)))));
            this.panel4.Location = new System.Drawing.Point(181, 139);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 3);
            this.panel4.TabIndex = 3;
            // 
            // txtDescripcionAlmacen
            // 
            this.txtDescripcionAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtDescripcionAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionAlmacen.Enabled = false;
            this.txtDescripcionAlmacen.Location = new System.Drawing.Point(181, 117);
            this.txtDescripcionAlmacen.MaxLength = 255;
            this.txtDescripcionAlmacen.Name = "txtDescripcionAlmacen";
            this.txtDescripcionAlmacen.Size = new System.Drawing.Size(245, 20);
            this.txtDescripcionAlmacen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion (*)";
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Almacen";
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPrincipalAlmacen.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlmacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lalmacenBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabPrincipalAlmacen;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBuscarAlmacen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscarAlmacen;
        private System.Windows.Forms.Button btnAgregarAlmacen;
        private System.Windows.Forms.Button btnReporteAlmacen;
        private System.Windows.Forms.DataGridView dataAlmacen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDescripcionAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGuardarAlmacen;
        private System.Windows.Forms.Button btnActualizarAlmacen;
        private System.Windows.Forms.Button btnVolverAlamcen;
        private System.Windows.Forms.BindingSource lalmacenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalmacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
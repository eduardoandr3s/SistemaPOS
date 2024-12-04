namespace SistemaPOS.Views
{
    partial class frmProductos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadproducto = new System.Windows.Forms.TextBox();
            this.cbTipoProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImpuestoProducto = new System.Windows.Forms.TextBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(92, 36);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(118, 22);
            this.txtIdProducto.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(68, 39);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(18, 16);
            this.Id.TabIndex = 2;
            this.Id.Text = "Id";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(364, 36);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(118, 22);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(632, 36);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(118, 22);
            this.txtPrecioProducto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // txtCantidadproducto
            // 
            this.txtCantidadproducto.Location = new System.Drawing.Point(92, 88);
            this.txtCantidadproducto.Name = "txtCantidadproducto";
            this.txtCantidadproducto.Size = new System.Drawing.Size(118, 22);
            this.txtCantidadproducto.TabIndex = 8;
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.Items.AddRange(new object[] {
            "Libro",
            "PC"});
            this.cbTipoProducto.Location = new System.Drawing.Point(364, 87);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.Size = new System.Drawing.Size(118, 24);
            this.cbTipoProducto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Impuesto";
            // 
            // txtImpuestoProducto
            // 
            this.txtImpuestoProducto.Location = new System.Drawing.Point(632, 88);
            this.txtImpuestoProducto.Name = "txtImpuestoProducto";
            this.txtImpuestoProducto.Size = new System.Drawing.Size(118, 22);
            this.txtImpuestoProducto.TabIndex = 12;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(23, 148);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(91, 23);
            this.btnNuevoProducto.TabIndex = 14;
            this.btnNuevoProducto.Text = "Nuevo";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(136, 148);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(91, 23);
            this.btnCrearProducto.TabIndex = 15;
            this.btnCrearProducto.Text = "Crear";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(248, 148);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(91, 23);
            this.btnEliminarProducto.TabIndex = 16;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(347, 148);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 23);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnCrearProducto);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtImpuestoProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTipoProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidadproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadproducto;
        private System.Windows.Forms.ComboBox cbTipoProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImpuestoProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnActualizar;
    }
}
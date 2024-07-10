namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtMarca = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1140, 464);
            dataGridView1.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(1322, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(327, 32);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1207, 33);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 2;
            label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1164, 104);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 4;
            label2.Text = "DESCRIPCION:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(1324, 101);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(327, 32);
            txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1219, 170);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 6;
            label3.Text = "MARCA:";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(1324, 167);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(327, 32);
            txtMarca.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1219, 228);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 8;
            label4.Text = "PRECIO:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(1324, 225);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(327, 32);
            txtPrecio.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1226, 283);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 10;
            label5.Text = "STOCK:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(1322, 280);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(327, 32);
            txtStock.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Location = new Point(1178, 334);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(493, 222);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.Location = new Point(11, 482);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(568, 74);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(585, 482);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(568, 74);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1683, 571);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtMarca);
            Controls.Add(label2);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "REGISTRO DE DATOS CRUD";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtMarca;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtStock;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}

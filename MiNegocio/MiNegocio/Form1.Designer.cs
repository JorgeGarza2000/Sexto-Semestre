namespace MiNegocio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dParcela = new MiNegocio.DParcela();
            this.dParcelaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dParcelaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dParcela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dParcelaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dParcelaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(37, 29);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(124, 26);
            this.numericUpDown1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(187, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 35);
            this.button1.TabIndex = 1;
            this.button1.Tag = "Fruta";
            this.button1.Text = "Manzana";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 35);
            this.button2.TabIndex = 2;
            this.button2.Tag = "Fruta";
            this.button2.Text = "Platano";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 35);
            this.button3.TabIndex = 3;
            this.button3.Tag = "Verdura";
            this.button3.Text = "Zanahoria";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(391, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 35);
            this.button4.TabIndex = 4;
            this.button4.Tag = "Verdura";
            this.button4.Text = "Calabaza";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(508, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(570, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "button7";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(453, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 35);
            this.button7.TabIndex = 7;
            this.button7.Text = "button5";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.notaIDDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.iVADataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(580, 346);
            this.dataGridView1.TabIndex = 8;
            // 
            // dParcela
            // 
            this.dParcela.DataSetName = "DParcela";
            this.dParcela.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dParcelaBindingSource
            // 
            this.dParcelaBindingSource.DataSource = this.dParcela;
            this.dParcelaBindingSource.Position = 0;
            // 
            // dParcelaBindingSource1
            // 
            this.dParcelaBindingSource1.DataSource = this.dParcela;
            this.dParcelaBindingSource1.Position = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(645, 106);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(113, 74);
            this.button8.TabIndex = 9;
            this.button8.Text = "NUEVA NOTA";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(645, 210);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 74);
            this.button9.TabIndex = 10;
            this.button9.Text = "SALIR";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.dParcela;
            // 
            // notaIDDataGridViewTextBoxColumn
            // 
            this.notaIDDataGridViewTextBoxColumn.DataPropertyName = "Nota_ID";
            this.notaIDDataGridViewTextBoxColumn.HeaderText = "Nota_ID";
            this.notaIDDataGridViewTextBoxColumn.Name = "notaIDDataGridViewTextBoxColumn";
            this.notaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iVADataGridViewTextBoxColumn
            // 
            this.iVADataGridViewTextBoxColumn.DataPropertyName = "IVA";
            this.iVADataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iVADataGridViewTextBoxColumn.Name = "iVADataGridViewTextBoxColumn";
            this.iVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dParcela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dParcelaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dParcelaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dParcelaBindingSource;
        private DParcela dParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private System.Windows.Forms.BindingSource dParcelaBindingSource1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}


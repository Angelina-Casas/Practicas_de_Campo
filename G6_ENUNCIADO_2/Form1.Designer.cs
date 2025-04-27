
namespace G6_ENUNCIADO_2
{
    partial class Lista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Números = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G6_BtnInsertar = new System.Windows.Forms.Button();
            this.textMostrar = new System.Windows.Forms.TextBox();
            this.G6_BtnAscendente = new System.Windows.Forms.Button();
            this.ResulAscen = new System.Windows.Forms.TextBox();
            this.G6_BtnDescendente = new System.Windows.Forms.Button();
            this.txtResulDesn = new System.Windows.Forms.TextBox();
            this.G6_BtnBuscar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Números});
            this.dataGridView1.Location = new System.Drawing.Point(711, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(179, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // Números
            // 
            this.Números.HeaderText = "Números";
            this.Números.MinimumWidth = 6;
            this.Números.Name = "Números";
            this.Números.Width = 125;
            // 
            // G6_BtnInsertar
            // 
            this.G6_BtnInsertar.BackColor = System.Drawing.Color.Gold;
            this.G6_BtnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G6_BtnInsertar.Location = new System.Drawing.Point(37, 80);
            this.G6_BtnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.G6_BtnInsertar.Name = "G6_BtnInsertar";
            this.G6_BtnInsertar.Size = new System.Drawing.Size(276, 28);
            this.G6_BtnInsertar.TabIndex = 1;
            this.G6_BtnInsertar.Text = "Numeros ingresados de la lista :";
            this.G6_BtnInsertar.UseVisualStyleBackColor = false;
            this.G6_BtnInsertar.Click += new System.EventHandler(this.G6_BtnInsertar_Click);
            // 
            // textMostrar
            // 
            this.textMostrar.Location = new System.Drawing.Point(337, 85);
            this.textMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.textMostrar.Name = "textMostrar";
            this.textMostrar.Size = new System.Drawing.Size(325, 22);
            this.textMostrar.TabIndex = 2;
            // 
            // G6_BtnAscendente
            // 
            this.G6_BtnAscendente.BackColor = System.Drawing.Color.Gold;
            this.G6_BtnAscendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G6_BtnAscendente.Location = new System.Drawing.Point(37, 146);
            this.G6_BtnAscendente.Margin = new System.Windows.Forms.Padding(4);
            this.G6_BtnAscendente.Name = "G6_BtnAscendente";
            this.G6_BtnAscendente.Size = new System.Drawing.Size(276, 30);
            this.G6_BtnAscendente.TabIndex = 3;
            this.G6_BtnAscendente.Text = "Ordenar de forma ascendente :";
            this.G6_BtnAscendente.UseVisualStyleBackColor = false;
            this.G6_BtnAscendente.Click += new System.EventHandler(this.G6_BtnAscendente_Click);
            // 
            // ResulAscen
            // 
            this.ResulAscen.Location = new System.Drawing.Point(337, 150);
            this.ResulAscen.Margin = new System.Windows.Forms.Padding(4);
            this.ResulAscen.Name = "ResulAscen";
            this.ResulAscen.Size = new System.Drawing.Size(325, 22);
            this.ResulAscen.TabIndex = 4;
            // 
            // G6_BtnDescendente
            // 
            this.G6_BtnDescendente.BackColor = System.Drawing.Color.Gold;
            this.G6_BtnDescendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G6_BtnDescendente.Location = new System.Drawing.Point(37, 212);
            this.G6_BtnDescendente.Margin = new System.Windows.Forms.Padding(4);
            this.G6_BtnDescendente.Name = "G6_BtnDescendente";
            this.G6_BtnDescendente.Size = new System.Drawing.Size(276, 32);
            this.G6_BtnDescendente.TabIndex = 5;
            this.G6_BtnDescendente.Text = "Ordenar de forma descendente :";
            this.G6_BtnDescendente.UseVisualStyleBackColor = false;
            this.G6_BtnDescendente.Click += new System.EventHandler(this.G6_BtnDescendente_Click);
            // 
            // txtResulDesn
            // 
            this.txtResulDesn.Location = new System.Drawing.Point(337, 217);
            this.txtResulDesn.Margin = new System.Windows.Forms.Padding(4);
            this.txtResulDesn.Name = "txtResulDesn";
            this.txtResulDesn.Size = new System.Drawing.Size(325, 22);
            this.txtResulDesn.TabIndex = 6;
            // 
            // G6_BtnBuscar
            // 
            this.G6_BtnBuscar.BackColor = System.Drawing.Color.Gold;
            this.G6_BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G6_BtnBuscar.Location = new System.Drawing.Point(37, 277);
            this.G6_BtnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.G6_BtnBuscar.Name = "G6_BtnBuscar";
            this.G6_BtnBuscar.Size = new System.Drawing.Size(276, 30);
            this.G6_BtnBuscar.TabIndex = 7;
            this.G6_BtnBuscar.Text = "Buscar un elemento de la lista :";
            this.G6_BtnBuscar.UseVisualStyleBackColor = false;
            this.G6_BtnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(337, 282);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(325, 22);
            this.txtNumero.TabIndex = 8;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(361, 415);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 18);
            this.lblNum.TabIndex = 9;
            this.lblNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::G6_ENUNCIADO_2.Properties.Resources.logo_4;
            this.pictureBox1.Location = new System.Drawing.Point(36, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(79, 395);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 54);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Ingresar nuevos datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gold;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(37, 337);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(276, 28);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar un número :";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(337, 340);
            this.txtEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(325, 22);
            this.txtEliminar.TabIndex = 13;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(749, 395);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(141, 54);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Bienvenido usuario :)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(943, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.G6_BtnBuscar);
            this.Controls.Add(this.txtResulDesn);
            this.Controls.Add(this.G6_BtnDescendente);
            this.Controls.Add(this.ResulAscen);
            this.Controls.Add(this.G6_BtnAscendente);
            this.Controls.Add(this.textMostrar);
            this.Controls.Add(this.G6_BtnInsertar);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lista";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Lista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Números;
        private System.Windows.Forms.Button G6_BtnInsertar;
        private System.Windows.Forms.TextBox textMostrar;
        private System.Windows.Forms.Button G6_BtnAscendente;
        private System.Windows.Forms.TextBox ResulAscen;
        private System.Windows.Forms.Button G6_BtnDescendente;
        private System.Windows.Forms.TextBox txtResulDesn;
        private System.Windows.Forms.Button G6_BtnBuscar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button button1;
    }
}


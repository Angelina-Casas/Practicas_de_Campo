
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Números});
            this.dataGridView1.Location = new System.Drawing.Point(533, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(146, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // Números
            // 
            this.Números.HeaderText = "Números";
            this.Números.Name = "Números";
            // 
            // G6_BtnInsertar
            // 
            this.G6_BtnInsertar.BackColor = System.Drawing.Color.Gold;
            this.G6_BtnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G6_BtnInsertar.Location = new System.Drawing.Point(28, 65);
            this.G6_BtnInsertar.Name = "G6_BtnInsertar";
            this.G6_BtnInsertar.Size = new System.Drawing.Size(207, 23);
            this.G6_BtnInsertar.TabIndex = 1;
            this.G6_BtnInsertar.Text = "Numeros ingresados de la lista :";
            this.G6_BtnInsertar.UseVisualStyleBackColor = false;
            this.G6_BtnInsertar.Click += new System.EventHandler(this.G6_BtnInsertar_Click);
            // 
            // textMostrar
            // 
            this.textMostrar.Location = new System.Drawing.Point(253, 69);
            this.textMostrar.Name = "textMostrar";
            this.textMostrar.Size = new System.Drawing.Size(245, 20);
            this.textMostrar.TabIndex = 2;
            // 
            // G6_BtnAscendente
            // 
            this.G6_BtnAscendente.BackColor = System.Drawing.Color.Gold;
            this.G6_BtnAscendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G6_BtnAscendente.Location = new System.Drawing.Point(28, 119);
            this.G6_BtnAscendente.Name = "G6_BtnAscendente";
            this.G6_BtnAscendente.Size = new System.Drawing.Size(207, 24);
            this.G6_BtnAscendente.TabIndex = 3;
            this.G6_BtnAscendente.Text = "Ordenar de forma ascendente :";
            this.G6_BtnAscendente.UseVisualStyleBackColor = false;
            this.G6_BtnAscendente.Click += new System.EventHandler(this.G6_BtnAscendente_Click);
            // 
            // ResulAscen
            // 
            this.ResulAscen.Location = new System.Drawing.Point(253, 122);
            this.ResulAscen.Name = "ResulAscen";
            this.ResulAscen.Size = new System.Drawing.Size(245, 20);
            this.ResulAscen.TabIndex = 4;
            // 
            // G6_BtnDescendente
            // 
            this.G6_BtnDescendente.BackColor = System.Drawing.Color.Gold;
            this.G6_BtnDescendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G6_BtnDescendente.Location = new System.Drawing.Point(28, 172);
            this.G6_BtnDescendente.Name = "G6_BtnDescendente";
            this.G6_BtnDescendente.Size = new System.Drawing.Size(207, 26);
            this.G6_BtnDescendente.TabIndex = 5;
            this.G6_BtnDescendente.Text = "Ordenar de forma descendente :";
            this.G6_BtnDescendente.UseVisualStyleBackColor = false;
            this.G6_BtnDescendente.Click += new System.EventHandler(this.G6_BtnDescendente_Click);
            // 
            // txtResulDesn
            // 
            this.txtResulDesn.Location = new System.Drawing.Point(253, 176);
            this.txtResulDesn.Name = "txtResulDesn";
            this.txtResulDesn.Size = new System.Drawing.Size(245, 20);
            this.txtResulDesn.TabIndex = 6;
            // 
            // G6_BtnBuscar
            // 
            this.G6_BtnBuscar.BackColor = System.Drawing.Color.Gold;
            this.G6_BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G6_BtnBuscar.Location = new System.Drawing.Point(28, 225);
            this.G6_BtnBuscar.Name = "G6_BtnBuscar";
            this.G6_BtnBuscar.Size = new System.Drawing.Size(207, 24);
            this.G6_BtnBuscar.TabIndex = 7;
            this.G6_BtnBuscar.Text = "Buscar un elemento de la lista :";
            this.G6_BtnBuscar.UseVisualStyleBackColor = false;
            this.G6_BtnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(253, 229);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(245, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(271, 337);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 15);
            this.lblNum.TabIndex = 9;
            this.lblNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::G6_ENUNCIADO_2.Properties.Resources.logo_4;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(59, 321);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 44);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Ingresar Datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gold;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(28, 274);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(207, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar un número :";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(253, 276);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(245, 20);
            this.txtEliminar.TabIndex = 13;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(552, 321);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 44);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Bienvenido usuario :)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(271, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ibgresa los numero en las casillas de la lista";
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 392);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}


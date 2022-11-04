namespace IPClases_ABC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvtablaSubred = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroSubred = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp4 = new System.Windows.Forms.TextBox();
            this.txtIp3 = new System.Windows.Forms.TextBox();
            this.txtIp2 = new System.Windows.Forms.TextBox();
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClase = new System.Windows.Forms.TextBox();
            this.txtMascara = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablaSubred)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "SUBNETTING - ULASALLE";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(334, 151);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 35);
            this.btnGenerar.TabIndex = 37;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgvtablaSubred
            // 
            this.dgvtablaSubred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtablaSubred.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvtablaSubred.Location = new System.Drawing.Point(12, 192);
            this.dgvtablaSubred.Name = "dgvtablaSubred";
            this.dgvtablaSubred.Size = new System.Drawing.Size(807, 330);
            this.dgvtablaSubred.TabIndex = 36;
            this.dgvtablaSubred.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtablaSubred_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.FillWeight = 10F;
            this.Column4.HeaderText = "Nº";
            this.Column4.MaxInputLength = 300;
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID_RED";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RANGO_IP_CONFIGURABLE";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "BROADCAST";
            this.Column3.Name = "Column3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroSubred);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIp4);
            this.groupBox1.Controls.Add(this.txtIp3);
            this.groupBox1.Controls.Add(this.txtIp2);
            this.groupBox1.Controls.Add(this.txtIp1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 105);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numero de Subredes";
            // 
            // txtNumeroSubred
            // 
            this.txtNumeroSubred.Location = new System.Drawing.Point(195, 72);
            this.txtNumeroSubred.Name = "txtNumeroSubred";
            this.txtNumeroSubred.Size = new System.Drawing.Size(319, 20);
            this.txtNumeroSubred.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ingrese Numero Subred:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = ".";
            // 
            // txtIp4
            // 
            this.txtIp4.Location = new System.Drawing.Point(427, 32);
            this.txtIp4.Name = "txtIp4";
            this.txtIp4.Size = new System.Drawing.Size(87, 20);
            this.txtIp4.TabIndex = 47;
            // 
            // txtIp3
            // 
            this.txtIp3.Location = new System.Drawing.Point(343, 32);
            this.txtIp3.Name = "txtIp3";
            this.txtIp3.Size = new System.Drawing.Size(66, 20);
            this.txtIp3.TabIndex = 46;
            // 
            // txtIp2
            // 
            this.txtIp2.Location = new System.Drawing.Point(246, 32);
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.Size = new System.Drawing.Size(81, 20);
            this.txtIp2.TabIndex = 45;
            // 
            // txtIp1
            // 
            this.txtIp1.Location = new System.Drawing.Point(149, 32);
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(80, 20);
            this.txtIp1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ingrese IP de red:";
            // 
            // txtClase
            // 
            this.txtClase.Location = new System.Drawing.Point(641, 47);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(71, 20);
            this.txtClase.TabIndex = 56;
            // 
            // txtMascara
            // 
            this.txtMascara.Location = new System.Drawing.Point(641, 76);
            this.txtMascara.Name = "txtMascara";
            this.txtMascara.Size = new System.Drawing.Size(145, 20);
            this.txtMascara.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(585, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "CLASE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "MASCARA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(473, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(346, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "CHRISTIAN RODRIGUEZ Y LUISFELIPE MAMANI";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IPClases_ABC.Properties.Resources.xddd;
            this.pictureBox1.Location = new System.Drawing.Point(749, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 61);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClase);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMascara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvtablaSubred);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablaSubred)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvtablaSubred;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClase;
        private System.Windows.Forms.TextBox txtMascara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumeroSubred;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIp4;
        private System.Windows.Forms.TextBox txtIp3;
        private System.Windows.Forms.TextBox txtIp2;
        private System.Windows.Forms.TextBox txtIp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace AlmacenamiendoDeDatos
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
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.grb_opciones = new System.Windows.Forms.GroupBox();
            this.rb_opcion_rtf = new System.Windows.Forms.RadioButton();
            this.rb_opcion_xml = new System.Windows.Forms.RadioButton();
            this.rb_opcion_csv = new System.Windows.Forms.RadioButton();
            this.rb_opcion_txt = new System.Windows.Forms.RadioButton();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dbgrd_datos_csv = new System.Windows.Forms.DataGridView();
            this.grb_opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrd_datos_csv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_texto
            // 
            this.txt_texto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_texto.Location = new System.Drawing.Point(12, 12);
            this.txt_texto.Multiline = true;
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(611, 426);
            this.txt_texto.TabIndex = 0;
            this.txt_texto.Visible = false;
            // 
            // grb_opciones
            // 
            this.grb_opciones.Controls.Add(this.rb_opcion_rtf);
            this.grb_opciones.Controls.Add(this.rb_opcion_xml);
            this.grb_opciones.Controls.Add(this.rb_opcion_csv);
            this.grb_opciones.Controls.Add(this.rb_opcion_txt);
            this.grb_opciones.Location = new System.Drawing.Point(629, 12);
            this.grb_opciones.Name = "grb_opciones";
            this.grb_opciones.Size = new System.Drawing.Size(159, 165);
            this.grb_opciones.TabIndex = 1;
            this.grb_opciones.TabStop = false;
            this.grb_opciones.Text = "Qué desea abrir?";
            // 
            // rb_opcion_rtf
            // 
            this.rb_opcion_rtf.AutoSize = true;
            this.rb_opcion_rtf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_opcion_rtf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_opcion_rtf.Location = new System.Drawing.Point(37, 126);
            this.rb_opcion_rtf.Name = "rb_opcion_rtf";
            this.rb_opcion_rtf.Size = new System.Drawing.Size(83, 19);
            this.rb_opcion_rtf.TabIndex = 3;
            this.rb_opcion_rtf.TabStop = true;
            this.rb_opcion_rtf.Text = "Archivos rtf";
            this.rb_opcion_rtf.UseVisualStyleBackColor = true;
            this.rb_opcion_rtf.CheckedChanged += new System.EventHandler(this.rb_opcion_rtf_CheckedChanged);
            // 
            // rb_opcion_xml
            // 
            this.rb_opcion_xml.AutoSize = true;
            this.rb_opcion_xml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_opcion_xml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_opcion_xml.Location = new System.Drawing.Point(37, 89);
            this.rb_opcion_xml.Name = "rb_opcion_xml";
            this.rb_opcion_xml.Size = new System.Drawing.Size(93, 19);
            this.rb_opcion_xml.TabIndex = 2;
            this.rb_opcion_xml.TabStop = true;
            this.rb_opcion_xml.Text = "Archivos xml";
            this.rb_opcion_xml.UseVisualStyleBackColor = true;
            this.rb_opcion_xml.CheckedChanged += new System.EventHandler(this.rb_opcion_xml_CheckedChanged);
            // 
            // rb_opcion_csv
            // 
            this.rb_opcion_csv.AutoSize = true;
            this.rb_opcion_csv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_opcion_csv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_opcion_csv.Location = new System.Drawing.Point(37, 54);
            this.rb_opcion_csv.Name = "rb_opcion_csv";
            this.rb_opcion_csv.Size = new System.Drawing.Size(90, 19);
            this.rb_opcion_csv.TabIndex = 1;
            this.rb_opcion_csv.TabStop = true;
            this.rb_opcion_csv.Text = "Archivos csv";
            this.rb_opcion_csv.UseVisualStyleBackColor = true;
            this.rb_opcion_csv.CheckedChanged += new System.EventHandler(this.rb_opcion_csv_CheckedChanged);
            // 
            // rb_opcion_txt
            // 
            this.rb_opcion_txt.AutoSize = true;
            this.rb_opcion_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_opcion_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_opcion_txt.Location = new System.Drawing.Point(37, 19);
            this.rb_opcion_txt.Name = "rb_opcion_txt";
            this.rb_opcion_txt.Size = new System.Drawing.Size(85, 19);
            this.rb_opcion_txt.TabIndex = 0;
            this.rb_opcion_txt.TabStop = true;
            this.rb_opcion_txt.Text = "Archivos txt";
            this.rb_opcion_txt.UseVisualStyleBackColor = true;
            this.rb_opcion_txt.CheckedChanged += new System.EventHandler(this.rb_opcion_txt_CheckedChanged);
            // 
            // btn_borrar
            // 
            this.btn_borrar.BackColor = System.Drawing.Color.Red;
            this.btn_borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_borrar.FlatAppearance.BorderSize = 3;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.Location = new System.Drawing.Point(629, 408);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(158, 29);
            this.btn_borrar.TabIndex = 2;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.UseVisualStyleBackColor = false;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.Lime;
            this.btn_crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crear.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_crear.FlatAppearance.BorderSize = 3;
            this.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.Location = new System.Drawing.Point(630, 338);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(158, 29);
            this.btn_crear.TabIndex = 3;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_editar.FlatAppearance.BorderSize = 3;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(630, 373);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(158, 29);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Visible = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_abrir
            // 
            this.btn_abrir.BackColor = System.Drawing.Color.Yellow;
            this.btn_abrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_abrir.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btn_abrir.FlatAppearance.BorderSize = 3;
            this.btn_abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir.Location = new System.Drawing.Point(630, 303);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(158, 29);
            this.btn_abrir.TabIndex = 5;
            this.btn_abrir.Text = "ABRIR";
            this.btn_abrir.UseVisualStyleBackColor = false;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dbgrd_datos_csv
            // 
            this.dbgrd_datos_csv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgrd_datos_csv.Location = new System.Drawing.Point(12, 12);
            this.dbgrd_datos_csv.Name = "dbgrd_datos_csv";
            this.dbgrd_datos_csv.Size = new System.Drawing.Size(611, 426);
            this.dbgrd_datos_csv.TabIndex = 6;
            this.dbgrd_datos_csv.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.grb_opciones);
            this.Controls.Add(this.dbgrd_datos_csv);
            this.Controls.Add(this.txt_texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb_opciones.ResumeLayout(false);
            this.grb_opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgrd_datos_csv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.GroupBox grb_opciones;
        private System.Windows.Forms.RadioButton rb_opcion_rtf;
        private System.Windows.Forms.RadioButton rb_opcion_xml;
        private System.Windows.Forms.RadioButton rb_opcion_csv;
        private System.Windows.Forms.RadioButton rb_opcion_txt;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dbgrd_datos_csv;
    }
}


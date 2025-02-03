namespace EF_FP_GRUPO9
{
    partial class Enunciado2
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_regis = new System.Windows.Forms.Button();
            this.cmb_dia = new System.Windows.Forms.ComboBox();
            this.cmb_result = new System.Windows.Forms.ComboBox();
            this.txt_videojuego = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_datos = new System.Windows.Forms.DataGridView();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Videojuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_puntajetotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(65, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actividad en videojuegos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_regis);
            this.groupBox1.Controls.Add(this.cmb_dia);
            this.groupBox1.Controls.Add(this.cmb_result);
            this.groupBox1.Controls.Add(this.txt_videojuego);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(78, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 393);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de actividad";
            // 
            // btn_regis
            // 
            this.btn_regis.Location = new System.Drawing.Point(198, 288);
            this.btn_regis.Name = "btn_regis";
            this.btn_regis.Size = new System.Drawing.Size(193, 62);
            this.btn_regis.TabIndex = 6;
            this.btn_regis.Text = "Registrar";
            this.btn_regis.UseVisualStyleBackColor = true;
            this.btn_regis.Click += new System.EventHandler(this.btn_regis_Click);
            // 
            // cmb_dia
            // 
            this.cmb_dia.FormattingEnabled = true;
            this.cmb_dia.Location = new System.Drawing.Point(262, 55);
            this.cmb_dia.Name = "cmb_dia";
            this.cmb_dia.Size = new System.Drawing.Size(287, 37);
            this.cmb_dia.TabIndex = 5;
            this.cmb_dia.SelectedIndexChanged += new System.EventHandler(this.cmb_dia_SelectedIndexChanged);
            // 
            // cmb_result
            // 
            this.cmb_result.FormattingEnabled = true;
            this.cmb_result.Location = new System.Drawing.Point(262, 209);
            this.cmb_result.Name = "cmb_result";
            this.cmb_result.Size = new System.Drawing.Size(287, 37);
            this.cmb_result.TabIndex = 4;
            // 
            // txt_videojuego
            // 
            this.txt_videojuego.Location = new System.Drawing.Point(261, 136);
            this.txt_videojuego.Name = "txt_videojuego";
            this.txt_videojuego.Size = new System.Drawing.Size(288, 35);
            this.txt_videojuego.TabIndex = 3;
            this.txt_videojuego.TextChanged += new System.EventHandler(this.txt_videojuego_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Videojuego";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_datos);
            this.groupBox2.Location = new System.Drawing.Point(702, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1053, 466);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos ingresados";
            // 
            // dgv_datos
            // 
            this.dgv_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.Videojuego,
            this.Resultado,
            this.Puntuacion});
            this.dgv_datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_datos.Location = new System.Drawing.Point(3, 31);
            this.dgv_datos.Name = "dgv_datos";
            this.dgv_datos.RowHeadersWidth = 102;
            this.dgv_datos.RowTemplate.Height = 40;
            this.dgv_datos.Size = new System.Drawing.Size(1047, 432);
            this.dgv_datos.TabIndex = 0;
            this.dgv_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_datos_CellContentClick);
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.MinimumWidth = 12;
            this.Dia.Name = "Dia";
            this.Dia.Width = 250;
            // 
            // Videojuego
            // 
            this.Videojuego.HeaderText = "Videojuego";
            this.Videojuego.MinimumWidth = 12;
            this.Videojuego.Name = "Videojuego";
            this.Videojuego.Width = 250;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.MinimumWidth = 12;
            this.Resultado.Name = "Resultado";
            this.Resultado.Width = 250;
            // 
            // Puntuacion
            // 
            this.Puntuacion.HeaderText = "Puntuacion";
            this.Puntuacion.MinimumWidth = 12;
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.Width = 250;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_guardar);
            this.groupBox3.Controls.Add(this.btn_seleccionar);
            this.groupBox3.Location = new System.Drawing.Point(78, 588);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 321);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guardar actividad";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(146, 175);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(234, 88);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.Text = "Guardar datos de actividad";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(146, 65);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(234, 88);
            this.btn_seleccionar.TabIndex = 0;
            this.btn_seleccionar.Text = "Seleccionar ruta";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_puntajetotal);
            this.groupBox4.Location = new System.Drawing.Point(702, 691);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(570, 138);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Puntaje";
            // 
            // txt_puntajetotal
            // 
            this.txt_puntajetotal.BackColor = System.Drawing.Color.White;
            this.txt_puntajetotal.Enabled = false;
            this.txt_puntajetotal.Location = new System.Drawing.Point(130, 58);
            this.txt_puntajetotal.Name = "txt_puntajetotal";
            this.txt_puntajetotal.Size = new System.Drawing.Size(309, 35);
            this.txt_puntajetotal.TabIndex = 0;
            // 
            // Enunciado2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1808, 975);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Enunciado2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enunciado2";
            this.Load += new System.EventHandler(this.Enunciado2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_puntajetotal;
        private System.Windows.Forms.TextBox txt_videojuego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_dia;
        private System.Windows.Forms.ComboBox cmb_result;
        private System.Windows.Forms.Button btn_regis;
        private System.Windows.Forms.DataGridView dgv_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Videojuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuacion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_seleccionar;
    }
}
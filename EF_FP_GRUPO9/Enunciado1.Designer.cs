namespace EF_FP_GRUPO9
{
    partial class Enunciado1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_npalabra = new System.Windows.Forms.TextBox();
            this.txt_palabra_add = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_palabra_add = new System.Windows.Forms.Button();
            this.btn_npal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.box_list_pal = new System.Windows.Forms.ListBox();
            this.btn_eli = new System.Windows.Forms.Button();
            this.btn_ord = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso de arrays tipo string";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de palabras a ingresar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Palabra a agregar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lista de palabras ingresadas";
            // 
            // txt_npalabra
            // 
            this.txt_npalabra.Location = new System.Drawing.Point(443, 82);
            this.txt_npalabra.Name = "txt_npalabra";
            this.txt_npalabra.Size = new System.Drawing.Size(227, 35);
            this.txt_npalabra.TabIndex = 5;
            // 
            // txt_palabra_add
            // 
            this.txt_palabra_add.Location = new System.Drawing.Point(443, 173);
            this.txt_palabra_add.Name = "txt_palabra_add";
            this.txt_palabra_add.Size = new System.Drawing.Size(227, 35);
            this.txt_palabra_add.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_palabra_add);
            this.groupBox1.Controls.Add(this.btn_npal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_npalabra);
            this.groupBox1.Controls.Add(this.txt_palabra_add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(102, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 290);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // btn_palabra_add
            // 
            this.btn_palabra_add.Location = new System.Drawing.Point(741, 158);
            this.btn_palabra_add.Name = "btn_palabra_add";
            this.btn_palabra_add.Size = new System.Drawing.Size(172, 64);
            this.btn_palabra_add.TabIndex = 8;
            this.btn_palabra_add.Text = "Agregar";
            this.btn_palabra_add.UseVisualStyleBackColor = true;
            this.btn_palabra_add.Click += new System.EventHandler(this.btn_palabra_add_Click);
            // 
            // btn_npal
            // 
            this.btn_npal.Location = new System.Drawing.Point(741, 67);
            this.btn_npal.Name = "btn_npal";
            this.btn_npal.Size = new System.Drawing.Size(172, 64);
            this.btn_npal.TabIndex = 7;
            this.btn_npal.Text = "Ingresar";
            this.btn_npal.UseVisualStyleBackColor = true;
            this.btn_npal.Click += new System.EventHandler(this.btn_npal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.box_list_pal);
            this.groupBox2.Controls.Add(this.btn_eli);
            this.groupBox2.Controls.Add(this.btn_ord);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(102, 485);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 640);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida";
            // 
            // box_list_pal
            // 
            this.box_list_pal.FormattingEnabled = true;
            this.box_list_pal.ItemHeight = 29;
            this.box_list_pal.Location = new System.Drawing.Point(191, 118);
            this.box_list_pal.Name = "box_list_pal";
            this.box_list_pal.Size = new System.Drawing.Size(589, 352);
            this.box_list_pal.TabIndex = 8;
            // 
            // btn_eli
            // 
            this.btn_eli.Location = new System.Drawing.Point(541, 515);
            this.btn_eli.Name = "btn_eli";
            this.btn_eli.Size = new System.Drawing.Size(239, 85);
            this.btn_eli.TabIndex = 7;
            this.btn_eli.Text = "Eliminar palabras";
            this.btn_eli.UseVisualStyleBackColor = true;
            this.btn_eli.Click += new System.EventHandler(this.btn_eli_Click);
            // 
            // btn_ord
            // 
            this.btn_ord.Location = new System.Drawing.Point(214, 515);
            this.btn_ord.Name = "btn_ord";
            this.btn_ord.Size = new System.Drawing.Size(239, 85);
            this.btn_ord.TabIndex = 6;
            this.btn_ord.Text = "Ordenar de forma ascendente";
            this.btn_ord.UseVisualStyleBackColor = true;
            this.btn_ord.Click += new System.EventHandler(this.btn_ord_Click);
            // 
            // Enunciado1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 1209);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Enunciado1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enunciado1";
            this.Load += new System.EventHandler(this.Enunciado1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_npalabra;
        private System.Windows.Forms.TextBox txt_palabra_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_palabra_add;
        private System.Windows.Forms.Button btn_npal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_eli;
        private System.Windows.Forms.Button btn_ord;
        private System.Windows.Forms.ListBox box_list_pal;
    }
}
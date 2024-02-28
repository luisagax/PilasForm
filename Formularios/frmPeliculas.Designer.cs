
namespace Pilas.Formularios
{
    partial class frmPeliculas
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
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lboPeliculas = new System.Windows.Forms.ListBox();
            this.btnMostarElementos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelicula";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(248, 39);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(299, 26);
            this.txtPelicula.TabIndex = 1;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(248, 84);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(299, 26);
            this.txtDirector.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Director";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(248, 129);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(299, 26);
            this.txtGenero.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genero";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(472, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lboPeliculas
            // 
            this.lboPeliculas.FormattingEnabled = true;
            this.lboPeliculas.ItemHeight = 18;
            this.lboPeliculas.Location = new System.Drawing.Point(12, 195);
            this.lboPeliculas.Name = "lboPeliculas";
            this.lboPeliculas.Size = new System.Drawing.Size(535, 148);
            this.lboPeliculas.TabIndex = 8;
            // 
            // btnMostarElementos
            // 
            this.btnMostarElementos.Location = new System.Drawing.Point(367, 349);
            this.btnMostarElementos.Name = "btnMostarElementos";
            this.btnMostarElementos.Size = new System.Drawing.Size(180, 25);
            this.btnMostarElementos.TabIndex = 7;
            this.btnMostarElementos.Text = "Mostrar elementos";
            this.btnMostarElementos.UseVisualStyleBackColor = true;
            this.btnMostarElementos.Click += new System.EventHandler(this.btnMostarElementos_Click);
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(574, 379);
            this.Controls.Add(this.lboPeliculas);
            this.Controls.Add(this.btnMostarElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPeliculas";
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.frmPeliculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lboPeliculas;
        private System.Windows.Forms.Button btnMostarElementos;
    }
}
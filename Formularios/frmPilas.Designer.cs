
namespace Pilas
{
    partial class frmPilas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostarElementos = new System.Windows.Forms.Button();
            this.lboPeliculas = new System.Windows.Forms.ListBox();
            this.btnPeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "- PELICULAS -";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(410, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 25);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostarElementos
            // 
            this.btnMostarElementos.Location = new System.Drawing.Point(174, 157);
            this.btnMostarElementos.Name = "btnMostarElementos";
            this.btnMostarElementos.Size = new System.Drawing.Size(180, 25);
            this.btnMostarElementos.TabIndex = 4;
            this.btnMostarElementos.Text = "Mostrar elementos";
            this.btnMostarElementos.UseVisualStyleBackColor = true;
            this.btnMostarElementos.Click += new System.EventHandler(this.btnMostarElementos_Click);
            // 
            // lboPeliculas
            // 
            this.lboPeliculas.FormattingEnabled = true;
            this.lboPeliculas.ItemHeight = 18;
            this.lboPeliculas.Location = new System.Drawing.Point(174, 188);
            this.lboPeliculas.Name = "lboPeliculas";
            this.lboPeliculas.Size = new System.Drawing.Size(180, 94);
            this.lboPeliculas.TabIndex = 5;
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(174, 126);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(180, 25);
            this.btnPeek.TabIndex = 6;
            this.btnPeek.Text = "Mostrar ult. elemento";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(538, 292);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.lboPeliculas);
            this.Controls.Add(this.btnMostarElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPilas";
            this.Text = "Ejercicio de pilas";
            this.Load += new System.EventHandler(this.frmPilas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostarElementos;
        private System.Windows.Forms.ListBox lboPeliculas;
        private System.Windows.Forms.Button btnPeek;
    }
}


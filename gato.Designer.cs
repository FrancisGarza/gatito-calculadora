namespace test2
{
    partial class gato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gato));
            this.BtnHola = new System.Windows.Forms.Button();
            this.TxtGato = new System.Windows.Forms.TextBox();
            this.LbmGato = new System.Windows.Forms.Label();
            this.LbmApellido = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LbmNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHola
            // 
            this.BtnHola.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHola.ForeColor = System.Drawing.Color.Fuchsia;
            this.BtnHola.Location = new System.Drawing.Point(321, 186);
            this.BtnHola.Name = "BtnHola";
            this.BtnHola.Size = new System.Drawing.Size(132, 58);
            this.BtnHola.TabIndex = 0;
            this.BtnHola.Text = "hola";
            this.BtnHola.UseVisualStyleBackColor = true;
            this.BtnHola.Click += new System.EventHandler(this.BtnHola_Click);
            // 
            // TxtGato
            // 
            this.TxtGato.Location = new System.Drawing.Point(321, 68);
            this.TxtGato.Name = "TxtGato";
            this.TxtGato.Size = new System.Drawing.Size(132, 22);
            this.TxtGato.TabIndex = 1;
            // 
            // LbmGato
            // 
            this.LbmGato.AutoSize = true;
            this.LbmGato.Location = new System.Drawing.Point(212, 73);
            this.LbmGato.Name = "LbmGato";
            this.LbmGato.Size = new System.Drawing.Size(103, 17);
            this.LbmGato.TabIndex = 2;
            this.LbmGato.Text = "inserte nombre";
            // 
            // LbmApellido
            // 
            this.LbmApellido.AutoSize = true;
            this.LbmApellido.Location = new System.Drawing.Point(212, 103);
            this.LbmApellido.Name = "LbmApellido";
            this.LbmApellido.Size = new System.Drawing.Size(104, 17);
            this.LbmApellido.TabIndex = 3;
            this.LbmApellido.Text = "inserte apellido";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(321, 100);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(132, 22);
            this.TxtApellido.TabIndex = 4;
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(321, 128);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(132, 22);
            this.TxtNumero.TabIndex = 5;
           
            // 
            // LbmNumero
            // 
            this.LbmNumero.AutoSize = true;
            this.LbmNumero.Location = new System.Drawing.Point(200, 131);
            this.LbmNumero.Name = "LbmNumero";
            this.LbmNumero.Size = new System.Drawing.Size(115, 17);
            this.LbmNumero.TabIndex = 6;
            this.LbmNumero.Text = "numero de gatos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbmNumero);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.LbmApellido);
            this.Controls.Add(this.LbmGato);
            this.Controls.Add(this.TxtGato);
            this.Controls.Add(this.BtnHola);
            this.Name = "Form1";
            this.Text = "gatito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHola;
        private System.Windows.Forms.TextBox TxtGato;
        private System.Windows.Forms.Label LbmGato;
        private System.Windows.Forms.Label LbmApellido;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LbmNumero;
    }
}


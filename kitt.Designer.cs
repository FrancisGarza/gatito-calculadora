namespace test2
{
    partial class kitt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitt));
            this.BtnCalcu = new System.Windows.Forms.Button();
            this.Lbm1 = new System.Windows.Forms.Label();
            this.Lbm2 = new System.Windows.Forms.Label();
            this.TxtGato1 = new System.Windows.Forms.TextBox();
            this.TxtGato2 = new System.Windows.Forms.TextBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.LbmResultado = new System.Windows.Forms.Label();
            this.LbmGatitos = new System.Windows.Forms.Label();
            this.BtnRestar = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCalcu
            // 
            this.BtnCalcu.Location = new System.Drawing.Point(258, 253);
            this.BtnCalcu.Name = "BtnCalcu";
            this.BtnCalcu.Size = new System.Drawing.Size(120, 45);
            this.BtnCalcu.TabIndex = 0;
            this.BtnCalcu.Text = "sumar";
            this.BtnCalcu.UseVisualStyleBackColor = true;
            this.BtnCalcu.Click += new System.EventHandler(this.BtnCalcu_Click);
            // 
            // Lbm1
            // 
            this.Lbm1.AutoSize = true;
            this.Lbm1.Location = new System.Drawing.Point(224, 93);
            this.Lbm1.Name = "Lbm1";
            this.Lbm1.Size = new System.Drawing.Size(48, 17);
            this.Lbm1.TabIndex = 1;
            this.Lbm1.Text = "gato 1";
            // 
            // Lbm2
            // 
            this.Lbm2.AutoSize = true;
            this.Lbm2.Location = new System.Drawing.Point(224, 142);
            this.Lbm2.Name = "Lbm2";
            this.Lbm2.Size = new System.Drawing.Size(48, 17);
            this.Lbm2.TabIndex = 2;
            this.Lbm2.Text = "gato 2";
            // 
            // TxtGato1
            // 
            this.TxtGato1.Location = new System.Drawing.Point(278, 93);
            this.TxtGato1.Name = "TxtGato1";
            this.TxtGato1.Size = new System.Drawing.Size(100, 22);
            this.TxtGato1.TabIndex = 3;
            // 
            // TxtGato2
            // 
            this.TxtGato2.Location = new System.Drawing.Point(278, 137);
            this.TxtGato2.Name = "TxtGato2";
            this.TxtGato2.Size = new System.Drawing.Size(100, 22);
            this.TxtGato2.TabIndex = 4;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(278, 188);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(100, 22);
            this.TxtResultado.TabIndex = 5;
            // 
            // LbmResultado
            // 
            this.LbmResultado.AutoSize = true;
            this.LbmResultado.Location = new System.Drawing.Point(291, 222);
            this.LbmResultado.Name = "LbmResultado";
            this.LbmResultado.Size = new System.Drawing.Size(72, 17);
            this.LbmResultado.TabIndex = 6;
            this.LbmResultado.Text = "Resultado";
            // 
            // LbmGatitos
            // 
            this.LbmGatitos.AutoSize = true;
            this.LbmGatitos.Location = new System.Drawing.Point(138, 32);
            this.LbmGatitos.Name = "LbmGatitos";
            this.LbmGatitos.Size = new System.Drawing.Size(120, 17);
            this.LbmGatitos.TabIndex = 7;
            this.LbmGatitos.Text = "¿cuantos gatitos?";
            // 
            // BtnRestar
            // 
            this.BtnRestar.Location = new System.Drawing.Point(175, 253);
            this.BtnRestar.Name = "BtnRestar";
            this.BtnRestar.Size = new System.Drawing.Size(75, 45);
            this.BtnRestar.TabIndex = 8;
            this.BtnRestar.Text = "restar";
            this.BtnRestar.UseVisualStyleBackColor = true;
            this.BtnRestar.Click += new System.EventHandler(this.BtnRestar_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(94, 253);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(75, 45);
            this.BtnMulti.TabIndex = 9;
            this.BtnMulti.Text = "multiplicar\r\n\r\n";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // BtnDividir
            // 
            this.BtnDividir.Location = new System.Drawing.Point(13, 256);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(75, 42);
            this.BtnDividir.TabIndex = 10;
            this.BtnDividir.Text = "dividir";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // kitt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(414, 349);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.BtnRestar);
            this.Controls.Add(this.LbmGatitos);
            this.Controls.Add(this.LbmResultado);
            this.Controls.Add(this.TxtResultado);
            this.Controls.Add(this.TxtGato2);
            this.Controls.Add(this.TxtGato1);
            this.Controls.Add(this.Lbm2);
            this.Controls.Add(this.Lbm1);
            this.Controls.Add(this.BtnCalcu);
            this.Name = "kitt";
            this.Text = "kitten calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcu;
        private System.Windows.Forms.Label Lbm1;
        private System.Windows.Forms.Label Lbm2;
        private System.Windows.Forms.TextBox TxtGato1;
        private System.Windows.Forms.TextBox TxtGato2;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label LbmResultado;
        private System.Windows.Forms.Label LbmGatitos;
        private System.Windows.Forms.Button BtnRestar;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button BtnDividir;
    }
}
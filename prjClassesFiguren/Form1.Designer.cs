namespace prjClassesFiguren
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGrafischVlak = new System.Windows.Forms.Panel();
            this.btnVierkant = new System.Windows.Forms.Button();
            this.tbxAantalFiguren = new System.Windows.Forms.TextBox();
            this.lblAantalfiguren = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.crd1 = new System.Windows.Forms.ColorDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCirkel = new System.Windows.Forms.Button();
            this.btnKruis = new System.Windows.Forms.Button();
            this.btnMannetje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlGrafischVlak
            // 
            this.pnlGrafischVlak.Location = new System.Drawing.Point(26, 12);
            this.pnlGrafischVlak.Name = "pnlGrafischVlak";
            this.pnlGrafischVlak.Size = new System.Drawing.Size(470, 414);
            this.pnlGrafischVlak.TabIndex = 0;
            // 
            // btnVierkant
            // 
            this.btnVierkant.Location = new System.Drawing.Point(502, 63);
            this.btnVierkant.Name = "btnVierkant";
            this.btnVierkant.Size = new System.Drawing.Size(212, 23);
            this.btnVierkant.TabIndex = 1;
            this.btnVierkant.Text = "Vierkant tekenen";
            this.btnVierkant.UseVisualStyleBackColor = true;
            this.btnVierkant.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // tbxAantalFiguren
            // 
            this.tbxAantalFiguren.Location = new System.Drawing.Point(502, 34);
            this.tbxAantalFiguren.Name = "tbxAantalFiguren";
            this.tbxAantalFiguren.Size = new System.Drawing.Size(212, 23);
            this.tbxAantalFiguren.TabIndex = 0;
            this.tbxAantalFiguren.Text = "Aantal figuren";
            this.tbxAantalFiguren.TextChanged += new System.EventHandler(this.tbxAantalFiguren_TextChanged);
            // 
            // lblAantalfiguren
            // 
            this.lblAantalfiguren.AutoSize = true;
            this.lblAantalfiguren.Location = new System.Drawing.Point(502, 16);
            this.lblAantalfiguren.Name = "lblAantalfiguren";
            this.lblAantalfiguren.Size = new System.Drawing.Size(212, 15);
            this.lblAantalfiguren.TabIndex = 2;
            this.lblAantalfiguren.Text = "Voer hieronder in hoeveel figuren je wil";
            // 
            // btnColor
            // 
            this.btnColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Location = new System.Drawing.Point(720, 41);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 74);
            this.btnColor.TabIndex = 3;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(720, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCirkel
            // 
            this.btnCirkel.Location = new System.Drawing.Point(502, 92);
            this.btnCirkel.Name = "btnCirkel";
            this.btnCirkel.Size = new System.Drawing.Size(212, 23);
            this.btnCirkel.TabIndex = 5;
            this.btnCirkel.Text = "Cirkel tekenen";
            this.btnCirkel.UseVisualStyleBackColor = true;
            this.btnCirkel.Click += new System.EventHandler(this.btnCirkel_Click);
            // 
            // btnKruis
            // 
            this.btnKruis.Location = new System.Drawing.Point(502, 121);
            this.btnKruis.Name = "btnKruis";
            this.btnKruis.Size = new System.Drawing.Size(212, 23);
            this.btnKruis.TabIndex = 6;
            this.btnKruis.Text = "Kruis tekenen";
            this.btnKruis.UseVisualStyleBackColor = true;
            this.btnKruis.Click += new System.EventHandler(this.btnKruis_Click);
            // 
            // btnMannetje
            // 
            this.btnMannetje.Location = new System.Drawing.Point(502, 150);
            this.btnMannetje.Name = "btnMannetje";
            this.btnMannetje.Size = new System.Drawing.Size(212, 23);
            this.btnMannetje.TabIndex = 7;
            this.btnMannetje.Text = "Mannetje tekenen";
            this.btnMannetje.UseVisualStyleBackColor = true;
            this.btnMannetje.Click += new System.EventHandler(this.btnMannetje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMannetje);
            this.Controls.Add(this.btnKruis);
            this.Controls.Add(this.btnCirkel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblAantalfiguren);
            this.Controls.Add(this.tbxAantalFiguren);
            this.Controls.Add(this.btnVierkant);
            this.Controls.Add(this.pnlGrafischVlak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlGrafischVlak;
        private Button btnVierkant;
        private TextBox tbxAantalFiguren;
        private Label lblAantalfiguren;
        private Button btnColor;
        private ColorDialog crd1;
        private Button btnClear;
        private Button btnCirkel;
        private Button btnKruis;
        private Button btnMannetje;
    }
}
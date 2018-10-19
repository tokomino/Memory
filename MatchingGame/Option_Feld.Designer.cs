namespace MatchingGame
{
    partial class Option_Feld
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mylabel1 = new MatchingGame.Mylabel();
            this.mylabel2 = new MatchingGame.Mylabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flatbutton1 = new MatchingGame.Flatbutton();
            this.flatbutton2 = new MatchingGame.Flatbutton();
            this.SuspendLayout();
            // 
            // mylabel1
            // 
            this.mylabel1.AutoSize = true;
            this.mylabel1.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mylabel1.ForeColor = System.Drawing.Color.White;
            this.mylabel1.Location = new System.Drawing.Point(19, 59);
            this.mylabel1.Name = "mylabel1";
            this.mylabel1.Size = new System.Drawing.Size(166, 59);
            this.mylabel1.TabIndex = 0;
            this.mylabel1.Text = "Spalten";
            // 
            // mylabel2
            // 
            this.mylabel2.AutoSize = true;
            this.mylabel2.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mylabel2.ForeColor = System.Drawing.Color.White;
            this.mylabel2.Location = new System.Drawing.Point(19, 143);
            this.mylabel2.Name = "mylabel2";
            this.mylabel2.Size = new System.Drawing.Size(138, 59);
            this.mylabel2.TabIndex = 1;
            this.mylabel2.Text = "Zeilen";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(184, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 61);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "4";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(184, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 61);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "4";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flatbutton1
            // 
            this.flatbutton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton1.BorderThickness = 1F;
            this.flatbutton1.FlatButtonAppearance = null;
            this.flatbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flatbutton1.Location = new System.Drawing.Point(276, 61);
            this.flatbutton1.Name = "flatbutton1";
            this.flatbutton1.Size = new System.Drawing.Size(122, 61);
            this.flatbutton1.TabIndex = 7;
            this.flatbutton1.Text = "Bestätigen";
            this.flatbutton1.Click += new System.EventHandler(this.flatbutton1_Click);
            // 
            // flatbutton2
            // 
            this.flatbutton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton2.BorderThickness = 1F;
            this.flatbutton2.FlatButtonAppearance = null;
            this.flatbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flatbutton2.Location = new System.Drawing.Point(276, 145);
            this.flatbutton2.Name = "flatbutton2";
            this.flatbutton2.Size = new System.Drawing.Size(122, 61);
            this.flatbutton2.TabIndex = 8;
            this.flatbutton2.Text = "Bestätigen";
            this.flatbutton2.Click += new System.EventHandler(this.flatbutton2_Click);
            // 
            // Option_Feld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.flatbutton2);
            this.Controls.Add(this.flatbutton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mylabel2);
            this.Controls.Add(this.mylabel1);
            this.Name = "Option_Feld";
            this.Size = new System.Drawing.Size(430, 275);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mylabel mylabel1;
        private Mylabel mylabel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Flatbutton flatbutton1;
        private Flatbutton flatbutton2;
    }
}

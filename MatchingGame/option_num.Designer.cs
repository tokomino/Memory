namespace MatchingGame
{
    partial class option_num
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(option_num));
            this.flatbutton3 = new MatchingGame.Flatbutton();
            this.flatbutton2 = new MatchingGame.Flatbutton();
            this.flatbutton1 = new MatchingGame.Flatbutton();
            this.SuspendLayout();
            // 
            // flatbutton3
            // 
            this.flatbutton3.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flatbutton3.BackgroundImage")));
            this.flatbutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flatbutton3.BorderThickness = 1F;
            this.flatbutton3.FlatButtonAppearance = null;
            this.flatbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flatbutton3.Location = new System.Drawing.Point(286, 72);
            this.flatbutton3.Name = "flatbutton3";
            this.flatbutton3.Size = new System.Drawing.Size(120, 125);
            this.flatbutton3.TabIndex = 4;
            this.flatbutton3.Click += new System.EventHandler(this.flatbutton3_Click);
            // 
            // flatbutton2
            // 
            this.flatbutton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flatbutton2.BackgroundImage")));
            this.flatbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flatbutton2.BorderThickness = 1F;
            this.flatbutton2.FlatButtonAppearance = null;
            this.flatbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flatbutton2.Location = new System.Drawing.Point(151, 72);
            this.flatbutton2.Name = "flatbutton2";
            this.flatbutton2.Size = new System.Drawing.Size(120, 125);
            this.flatbutton2.TabIndex = 3;
            this.flatbutton2.Click += new System.EventHandler(this.flatbutton2_Click);
            // 
            // flatbutton1
            // 
            this.flatbutton1.BackColor = System.Drawing.Color.MediumBlue;
            this.flatbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flatbutton1.BackgroundImage")));
            this.flatbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flatbutton1.BorderThickness = 0F;
            this.flatbutton1.FlatButtonAppearance = null;
            this.flatbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flatbutton1.Location = new System.Drawing.Point(16, 72);
            this.flatbutton1.Name = "flatbutton1";
            this.flatbutton1.Size = new System.Drawing.Size(120, 125);
            this.flatbutton1.TabIndex = 2;
            this.flatbutton1.Click += new System.EventHandler(this.flatbutton1_Click);
            // 
            // option_num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.flatbutton3);
            this.Controls.Add(this.flatbutton2);
            this.Controls.Add(this.flatbutton1);
            this.Name = "option_num";
            this.Size = new System.Drawing.Size(430, 275);
            this.ResumeLayout(false);

        }

        #endregion
        private Flatbutton flatbutton1;
        private Flatbutton flatbutton2;
        private Flatbutton flatbutton3;
    }
}

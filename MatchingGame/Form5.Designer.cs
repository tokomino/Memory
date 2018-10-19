namespace MatchingGame
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flatbutton4 = new MatchingGame.Flatbutton();
            this.flatbutton2 = new MatchingGame.Flatbutton();
            this.flatbutton1 = new MatchingGame.Flatbutton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 66);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // flatbutton4
            // 
            this.flatbutton4.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton4.BorderThickness = 1F;
            this.flatbutton4.FlatButtonAppearance = null;
            this.flatbutton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatbutton4.Location = new System.Drawing.Point(34, 215);
            this.flatbutton4.Margin = new System.Windows.Forms.Padding(112);
            this.flatbutton4.Name = "flatbutton4";
            this.flatbutton4.Size = new System.Drawing.Size(146, 56);
            this.flatbutton4.TabIndex = 4;
            this.flatbutton4.Text = "Beenden";
            this.flatbutton4.Click += new System.EventHandler(this.flatbutton4_Click);
            // 
            // flatbutton2
            // 
            this.flatbutton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton2.BorderThickness = 1F;
            this.flatbutton2.FlatButtonAppearance = null;
            this.flatbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatbutton2.Location = new System.Drawing.Point(34, 151);
            this.flatbutton2.Margin = new System.Windows.Forms.Padding(112);
            this.flatbutton2.Name = "flatbutton2";
            this.flatbutton2.Size = new System.Drawing.Size(146, 56);
            this.flatbutton2.TabIndex = 2;
            this.flatbutton2.Text = "Optionen";
            this.flatbutton2.Click += new System.EventHandler(this.flatbutton2_Click);
            // 
            // flatbutton1
            // 
            this.flatbutton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton1.BorderThickness = 1F;
            this.flatbutton1.FlatButtonAppearance = null;
            this.flatbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatbutton1.Location = new System.Drawing.Point(34, 87);
            this.flatbutton1.Margin = new System.Windows.Forms.Padding(112);
            this.flatbutton1.Name = "flatbutton1";
            this.flatbutton1.Size = new System.Drawing.Size(146, 56);
            this.flatbutton1.TabIndex = 1;
            this.flatbutton1.Text = "Starten";
            this.flatbutton1.Click += new System.EventHandler(this.flatbutton1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(220, 302);
            this.Controls.Add(this.flatbutton4);
            this.Controls.Add(this.flatbutton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flatbutton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Flatbutton flatbutton1;
        private Flatbutton flatbutton2;
        private Flatbutton flatbutton4;
    }
}
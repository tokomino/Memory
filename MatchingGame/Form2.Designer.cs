namespace MatchingGame
{
    partial class Form2
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
            this.mylabel2 = new MatchingGame.Mylabel();
            this.mylabel1 = new MatchingGame.Mylabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.flatbutton4 = new MatchingGame.Flatbutton();
            this.flatbutton1 = new MatchingGame.Flatbutton();
            this.flatbutton2 = new MatchingGame.Flatbutton();
            this.flatbutton3 = new MatchingGame.Flatbutton();
            this.option_Feld1 = new MatchingGame.Option_Feld();
            this.option_num1 = new MatchingGame.option_num();
            this.option_Color1 = new MatchingGame.option_Color();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.mylabel2);
            this.panel1.Controls.Add(this.mylabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 77);
            this.panel1.TabIndex = 23;
            // 
            // mylabel2
            // 
            this.mylabel2.AutoSize = true;
            this.mylabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mylabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.mylabel2.ForeColor = System.Drawing.Color.White;
            this.mylabel2.Location = new System.Drawing.Point(439, 9);
            this.mylabel2.Name = "mylabel2";
            this.mylabel2.Size = new System.Drawing.Size(155, 48);
            this.mylabel2.TabIndex = 1;
            this.mylabel2.Text = "Starten";
            this.mylabel2.Click += new System.EventHandler(this.mylabel2_Click);
            // 
            // mylabel1
            // 
            this.mylabel1.AutoSize = true;
            this.mylabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.mylabel1.ForeColor = System.Drawing.Color.White;
            this.mylabel1.Location = new System.Drawing.Point(12, 9);
            this.mylabel1.Name = "mylabel1";
            this.mylabel1.Size = new System.Drawing.Size(190, 48);
            this.mylabel1.TabIndex = 0;
            this.mylabel1.Text = "Optionen";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.flatbutton4);
            this.panel2.Controls.Add(this.flatbutton1);
            this.panel2.Controls.Add(this.flatbutton2);
            this.panel2.Controls.Add(this.flatbutton3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 275);
            this.panel2.TabIndex = 30;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SidePanel.Location = new System.Drawing.Point(0, 12);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(18, 50);
            this.SidePanel.TabIndex = 0;
            // 
            // flatbutton4
            // 
            this.flatbutton4.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton4.BorderThickness = 1F;
            this.flatbutton4.FlatButtonAppearance = null;
            this.flatbutton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flatbutton4.Location = new System.Drawing.Point(21, 196);
            this.flatbutton4.Margin = new System.Windows.Forms.Padding(100);
            this.flatbutton4.Name = "flatbutton4";
            this.flatbutton4.Size = new System.Drawing.Size(130, 50);
            this.flatbutton4.TabIndex = 26;
            this.flatbutton4.Text = "Zurück";
            this.flatbutton4.Click += new System.EventHandler(this.flatbutton4_Click);
            // 
            // flatbutton1
            // 
            this.flatbutton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton1.BorderThickness = 1F;
            this.flatbutton1.FlatButtonAppearance = null;
            this.flatbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flatbutton1.Location = new System.Drawing.Point(21, 12);
            this.flatbutton1.Margin = new System.Windows.Forms.Padding(100);
            this.flatbutton1.Name = "flatbutton1";
            this.flatbutton1.Size = new System.Drawing.Size(130, 50);
            this.flatbutton1.TabIndex = 28;
            this.flatbutton1.Text = "Feld";
            this.flatbutton1.Click += new System.EventHandler(this.flatbutton1_Click);
            // 
            // flatbutton2
            // 
            this.flatbutton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton2.BorderThickness = 1F;
            this.flatbutton2.FlatButtonAppearance = null;
            this.flatbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flatbutton2.Location = new System.Drawing.Point(21, 74);
            this.flatbutton2.Margin = new System.Windows.Forms.Padding(100);
            this.flatbutton2.Name = "flatbutton2";
            this.flatbutton2.Size = new System.Drawing.Size(130, 50);
            this.flatbutton2.TabIndex = 29;
            this.flatbutton2.Text = "Spieleranzahl";
            this.flatbutton2.Click += new System.EventHandler(this.flatbutton2_Click);
            // 
            // flatbutton3
            // 
            this.flatbutton3.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton3.BorderThickness = 1F;
            this.flatbutton3.FlatButtonAppearance = null;
            this.flatbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flatbutton3.Location = new System.Drawing.Point(21, 136);
            this.flatbutton3.Margin = new System.Windows.Forms.Padding(100);
            this.flatbutton3.Name = "flatbutton3";
            this.flatbutton3.Size = new System.Drawing.Size(130, 50);
            this.flatbutton3.TabIndex = 24;
            this.flatbutton3.Text = "Farben";
            this.flatbutton3.Click += new System.EventHandler(this.flatbutton3_Click);
            // 
            // option_Feld1
            // 
            this.option_Feld1.BackColor = System.Drawing.Color.Blue;
            this.option_Feld1.Location = new System.Drawing.Point(177, 80);
            this.option_Feld1.Name = "option_Feld1";
            this.option_Feld1.Size = new System.Drawing.Size(430, 275);
            this.option_Feld1.TabIndex = 32;
            // 
            // option_num1
            // 
            this.option_num1.BackColor = System.Drawing.Color.Blue;
            this.option_num1.Location = new System.Drawing.Point(177, 80);
            this.option_num1.Name = "option_num1";
            this.option_num1.Size = new System.Drawing.Size(430, 275);
            this.option_num1.TabIndex = 33;
            // 
            // option_Color1
            // 
            this.option_Color1.BackColor = System.Drawing.Color.Blue;
            this.option_Color1.Location = new System.Drawing.Point(177, 80);
            this.option_Color1.Name = "option_Color1";
            this.option_Color1.Size = new System.Drawing.Size(430, 278);
            this.option_Color1.TabIndex = 34;
            // 
            // Form2
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(606, 352);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.option_Feld1);
            this.Controls.Add(this.option_num1);
            this.Controls.Add(this.option_Color1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Werte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Mylabel mylabel1;
        private Flatbutton flatbutton4;
        private Flatbutton flatbutton1;
        private Flatbutton flatbutton2;
        private System.Windows.Forms.Panel panel2;
        private Flatbutton flatbutton3;
        private System.Windows.Forms.Panel SidePanel;
        private Option_Feld option_Feld1;
        private option_num option_num1;
        private option_Color option_Color1;
        private Mylabel mylabel2;
    }
}
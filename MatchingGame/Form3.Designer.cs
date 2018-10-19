namespace MatchingGame
{
    partial class Form3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mylabel1 = new MatchingGame.Mylabel();
            this.flatbutton2 = new MatchingGame.Flatbutton();
            this.flatbutton1 = new MatchingGame.Flatbutton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 271);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.mylabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 69);
            this.panel1.TabIndex = 11;
            // 
            // mylabel1
            // 
            this.mylabel1.AutoSize = true;
            this.mylabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.mylabel1.ForeColor = System.Drawing.Color.White;
            this.mylabel1.Location = new System.Drawing.Point(12, 9);
            this.mylabel1.Name = "mylabel1";
            this.mylabel1.Size = new System.Drawing.Size(206, 48);
            this.mylabel1.TabIndex = 0;
            this.mylabel1.Text = "Spielende";
            // 
            // flatbutton2
            // 
            this.flatbutton2.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton2.BorderThickness = 0F;
            this.flatbutton2.FlatButtonAppearance = null;
            this.flatbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flatbutton2.Location = new System.Drawing.Point(261, 358);
            this.flatbutton2.Name = "flatbutton2";
            this.flatbutton2.Size = new System.Drawing.Size(105, 43);
            this.flatbutton2.TabIndex = 10;
            this.flatbutton2.Text = "Schließen";
            this.flatbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flatbutton1
            // 
            this.flatbutton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flatbutton1.BorderThickness = 0F;
            this.flatbutton1.FlatButtonAppearance = null;
            this.flatbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flatbutton1.Location = new System.Drawing.Point(372, 358);
            this.flatbutton1.Name = "flatbutton1";
            this.flatbutton1.Size = new System.Drawing.Size(105, 43);
            this.flatbutton1.TabIndex = 9;
            this.flatbutton1.Text = "Rematch";
            this.flatbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(489, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flatbutton2);
            this.Controls.Add(this.flatbutton1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endscreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Flatbutton flatbutton1;
        private Flatbutton flatbutton2;
        private System.Windows.Forms.Panel panel1;
        private Mylabel mylabel1;
    }
}
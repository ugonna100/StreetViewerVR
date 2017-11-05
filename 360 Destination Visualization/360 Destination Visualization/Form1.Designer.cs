namespace _360_Destination_Visualization
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.FromText = new System.Windows.Forms.TextBox();
            this.ToText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PDirectory = new System.Windows.Forms.TextBox();
            this.Set = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(245, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FromText
            // 
            this.FromText.Cursor = System.Windows.Forms.Cursors.Default;
            this.FromText.Location = new System.Drawing.Point(195, 184);
            this.FromText.Name = "FromText";
            this.FromText.Size = new System.Drawing.Size(255, 20);
            this.FromText.TabIndex = 1;
            this.FromText.TextChanged += new System.EventHandler(this.FromText_TextChanged);
            // 
            // ToText
            // 
            this.ToText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ToText.Location = new System.Drawing.Point(195, 262);
            this.ToText.Name = "ToText";
            this.ToText.Size = new System.Drawing.Size(255, 20);
            this.ToText.TabIndex = 2;
            this.ToText.TextChanged += new System.EventHandler(this.ToText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(154, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "To:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(144, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Python Directory:";
            // 
            // PDirectory
            // 
            this.PDirectory.Location = new System.Drawing.Point(147, 98);
            this.PDirectory.Name = "PDirectory";
            this.PDirectory.Size = new System.Drawing.Size(361, 20);
            this.PDirectory.TabIndex = 6;
            this.PDirectory.TextChanged += new System.EventHandler(this.PDirectory_TextChanged);
            // 
            // Set
            // 
            this.Set.Location = new System.Drawing.Point(515, 98);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(40, 19);
            this.Set.TabIndex = 7;
            this.Set.Text = "SET";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::_360_Destination_Visualization.Properties.Resources._5467699_street_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 493);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.PDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToText);
            this.Controls.Add(this.FromText);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Destination Visualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FromText;
        private System.Windows.Forms.TextBox ToText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PDirectory;
        private System.Windows.Forms.Button Set;
    }
}


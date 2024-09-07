namespace tic_tac_toe
{
    partial class myform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myform));
            this.New = new System.Windows.Forms.Button();
            this.Exist = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(28, 330);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(298, 49);
            this.New.TabIndex = 0;
            this.New.Text = "New Game";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Exist
            // 
            this.Exist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exist.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exist.Location = new System.Drawing.Point(90, 403);
            this.Exist.Name = "Exist";
            this.Exist.Size = new System.Drawing.Size(178, 67);
            this.Exist.TabIndex = 1;
            this.Exist.Text = "Exit";
            this.Exist.UseVisualStyleBackColor = true;
            this.Exist.Click += new System.EventHandler(this.Exist_Click);
            this.Exist.MouseLeave += new System.EventHandler(this.Exist_MouseLeave);
            this.Exist.MouseHover += new System.EventHandler(this.Exist_MouseHover);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 12);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(111, 97);
            this.A1.TabIndex = 2;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.Button_Click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(129, 12);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(111, 97);
            this.A2.TabIndex = 3;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.Button_Click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(246, 12);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(111, 97);
            this.A3.TabIndex = 4;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.Button_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(246, 115);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(111, 97);
            this.B3.TabIndex = 7;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(129, 115);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(111, 97);
            this.B2.TabIndex = 6;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(12, 115);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(111, 97);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(246, 218);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(111, 97);
            this.C3.TabIndex = 10;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.Button_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(129, 218);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(111, 97);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.Button_Click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(12, 218);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(111, 97);
            this.C1.TabIndex = 8;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.Button_Click);
            // 
            // myform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(362, 498);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.Exist);
            this.Controls.Add(this.New);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "myform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Exist;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
    }
}


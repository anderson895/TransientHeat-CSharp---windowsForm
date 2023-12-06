namespace TransientHeat
{
    partial class MainMenu
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSolver = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Stencil", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.Location = new System.Drawing.Point(311, 210);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(162, 48);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSolver
            // 
            this.btnSolver.Font = new System.Drawing.Font("Stencil", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSolver.Location = new System.Drawing.Point(311, 279);
            this.btnSolver.Name = "btnSolver";
            this.btnSolver.Size = new System.Drawing.Size(162, 48);
            this.btnSolver.TabIndex = 1;
            this.btnSolver.Text = "Solver";
            this.btnSolver.UseVisualStyleBackColor = true;
            this.btnSolver.Click += new System.EventHandler(this.btnSolver_Click);
            // 
            // btnDev
            // 
            this.btnDev.Font = new System.Drawing.Font("Stencil", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDev.Location = new System.Drawing.Point(291, 348);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(208, 48);
            this.btnDev.TabIndex = 2;
            this.btnDev.Text = "Developer";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(82, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(672, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRANSIENT HEAT CONDUCTION SOLVER  FOR SLAB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 160);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(319, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "WELCOME !";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDev);
            this.Controls.Add(this.btnSolver);
            this.Controls.Add(this.btnAbout);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAbout;
        private Button btnSolver;
        private Button btnDev;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}
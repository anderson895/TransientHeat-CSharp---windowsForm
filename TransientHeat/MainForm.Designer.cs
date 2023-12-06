namespace TransientHeat
{
    partial class MainForm
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
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblThermalConductivity = new System.Windows.Forms.Label();
            this.txtThermalConductivity = new System.Windows.Forms.TextBox();
            this.lblDensity = new System.Windows.Forms.Label();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.lblSpecificHeat = new System.Windows.Forms.Label();
            this.txtSpecificHeat = new System.Windows.Forms.TextBox();
            this.lblDeltaX = new System.Windows.Forms.Label();
            this.txtDeltaX = new System.Windows.Forms.TextBox();
            this.lblDeltaT = new System.Windows.Forms.Label();
            this.txtDeltaT = new System.Windows.Forms.TextBox();
           
            this.lblNumberOfNodes = new System.Windows.Forms.Label();
            this.txtNumberOfNodes = new System.Windows.Forms.TextBox();
            
          
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(48, 115);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(100, 15);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "Temperature (°C):";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(263, 115);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(116, 23);
            this.txtTemperature.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(48, 145);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 15);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time (s):";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(263, 145);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(116, 23);
            this.txtTime.TabIndex = 3;
            // 
            // lblThermalConductivity
            // 
            this.lblThermalConductivity.AutoSize = true;
            this.lblThermalConductivity.Location = new System.Drawing.Point(48, 184);
            this.lblThermalConductivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThermalConductivity.Name = "lblThermalConductivity";
            this.lblThermalConductivity.Size = new System.Drawing.Size(180, 15);
            this.lblThermalConductivity.TabIndex = 6;
            this.lblThermalConductivity.Text = "Thermal Conductivity (W/(m·K)):";
            // 
            // txtThermalConductivity
            // 
            this.txtThermalConductivity.Location = new System.Drawing.Point(263, 184);
            this.txtThermalConductivity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtThermalConductivity.Name = "txtThermalConductivity";
            this.txtThermalConductivity.Size = new System.Drawing.Size(116, 23);
            this.txtThermalConductivity.TabIndex = 7;
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Location = new System.Drawing.Point(48, 214);
            this.lblDensity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(93, 15);
            this.lblDensity.TabIndex = 8;
            this.lblDensity.Text = "Density (kg/m³):";
            // 
            // txtDensity
            // 
            this.txtDensity.Location = new System.Drawing.Point(263, 214);
            this.txtDensity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(116, 23);
            this.txtDensity.TabIndex = 9;
            // 
            // lblSpecificHeat
            // 
            this.lblSpecificHeat.AutoSize = true;
            this.lblSpecificHeat.Location = new System.Drawing.Point(48, 244);
            this.lblSpecificHeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecificHeat.Name = "lblSpecificHeat";
            this.lblSpecificHeat.Size = new System.Drawing.Size(130, 15);
            this.lblSpecificHeat.TabIndex = 10;
            this.lblSpecificHeat.Text = "Specific Heat (J/(kg·K)):";
            // 
            // txtSpecificHeat
            // 
            this.txtSpecificHeat.Location = new System.Drawing.Point(263, 244);
            this.txtSpecificHeat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSpecificHeat.Name = "txtSpecificHeat";
            this.txtSpecificHeat.Size = new System.Drawing.Size(116, 23);
            this.txtSpecificHeat.TabIndex = 11;
            // 
            // lblDeltaX
            // 
            this.lblDeltaX.AutoSize = true;
            this.lblDeltaX.Location = new System.Drawing.Point(48, 274);
            this.lblDeltaX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeltaX.Name = "lblDeltaX";
            this.lblDeltaX.Size = new System.Drawing.Size(72, 15);
            this.lblDeltaX.TabIndex = 12;
            this.lblDeltaX.Text = "Δx (Delta X):";
            // 
            // txtDeltaX
            // 
            this.txtDeltaX.Location = new System.Drawing.Point(263, 274);
            this.txtDeltaX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeltaX.Name = "txtDeltaX";
            this.txtDeltaX.Size = new System.Drawing.Size(116, 23);
            this.txtDeltaX.TabIndex = 13;
            // 
            // lblDeltaT
            // 
            this.lblDeltaT.AutoSize = true;
            this.lblDeltaT.Location = new System.Drawing.Point(48, 304);
            this.lblDeltaT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeltaT.Name = "lblDeltaT";
            this.lblDeltaT.Size = new System.Drawing.Size(69, 15);
            this.lblDeltaT.TabIndex = 14;
            this.lblDeltaT.Text = "Δt (Delta T):";
            // 
            // txtDeltaT
            // 
            this.txtDeltaT.Location = new System.Drawing.Point(263, 304);
            this.txtDeltaT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDeltaT.Name = "txtDeltaT";
            this.txtDeltaT.Size = new System.Drawing.Size(116, 23);
            this.txtDeltaT.TabIndex = 15;
            // 
            // lblNumberOfNodes
            // 
            this.lblNumberOfNodes.AutoSize = true;
            this.lblNumberOfNodes.Location = new System.Drawing.Point(48, 334);
            this.lblNumberOfNodes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfNodes.Name = "lblNumberOfNodes";
            this.lblNumberOfNodes.Size = new System.Drawing.Size(105, 15);
            this.lblNumberOfNodes.TabIndex = 16;
            this.lblNumberOfNodes.Text = "Number of Nodes:";
            // 
            // txtNumberOfNodes
            // 
            this.txtNumberOfNodes.Location = new System.Drawing.Point(263, 334);
            this.txtNumberOfNodes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumberOfNodes.Name = "txtNumberOfNodes";
            this.txtNumberOfNodes.Size = new System.Drawing.Size(116, 23);
            this.txtNumberOfNodes.TabIndex = 17;
            
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(149, 412);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(88, 27);
            this.btnSolve.TabIndex = 20;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(153, 445);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 538);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblNumberOfTimeSteps);
            this.Controls.Add(this.txtNumberOfTimeSteps);
            this.Controls.Add(this.lblNumberOfNodes);
            this.Controls.Add(this.txtNumberOfNodes);
            this.Controls.Add(this.lblDeltaT);
            this.Controls.Add(this.txtDeltaT);
            this.Controls.Add(this.lblDeltaX);
            this.Controls.Add(this.txtDeltaX);
            this.Controls.Add(this.lblSpecificHeat);
            this.Controls.Add(this.txtSpecificHeat);
            this.Controls.Add(this.lblDensity);
            this.Controls.Add(this.txtDensity);
            this.Controls.Add(this.lblThermalConductivity);
            this.Controls.Add(this.txtThermalConductivity);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.txtTemperature);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Transient Heat Conduction Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
      
        private System.Windows.Forms.Label lblThermalConductivity;
        private System.Windows.Forms.TextBox txtThermalConductivity;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.Label lblSpecificHeat;
        private System.Windows.Forms.TextBox txtSpecificHeat;
        private System.Windows.Forms.Label lblDeltaX;
        private System.Windows.Forms.TextBox txtDeltaX;
        private System.Windows.Forms.Label lblDeltaT;
        private System.Windows.Forms.TextBox txtDeltaT;
        private System.Windows.Forms.Label lblNumberOfNodes;
        private System.Windows.Forms.TextBox txtNumberOfNodes;
        private System.Windows.Forms.Label lblNumberOfTimeSteps;
        private System.Windows.Forms.TextBox txtNumberOfTimeSteps;
        private System.Windows.Forms.Button btnSolve;
        private Button btnBack;
    }
}

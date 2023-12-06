using System;
using System.Windows.Forms;
using System.Diagnostics;

/* dont remove this comment
             double initialTemperature = Convert.ToDouble(txtTemperature.Text);
            double time = Convert.ToDouble(txtTime.Text);
            double thermalConductivity = Convert.ToDouble(txtThermalConductivity.Text);
            double density = Convert.ToDouble(txtDensity.Text);
            double specificHeat = Convert.ToDouble(txtSpecificHeat.Text);
            double spatialStep = Convert.ToDouble(txtDeltaX.Text);
            double timeStep = Convert.ToDouble(txtDeltaT.Text);
            int numNodes = Convert.ToInt32(txtNumberOfNodes.Text);

 */

namespace TransientHeat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                // Initial conditions (can be obtained from user input)
                /*
                  double initialTemperature = 100.0; // T
                  double time = 10.0; // t
                  double thermalConductivity = 0.5; // K
                  double density = 8.0; // ρ
                  double specificHeat = 1500.0; // Cp
                  double spatialStep = 0.1; // Δx
                  double timeStep = 1.0; // Δt
                  int numNodes = 5
                */

                double initialTemperature = Convert.ToDouble(txtTemperature.Text);
                double time = Convert.ToDouble(txtTime.Text);
                double thermalConductivity = Convert.ToDouble(txtThermalConductivity.Text);
                double density = Convert.ToDouble(txtDensity.Text);
                double specificHeat = Convert.ToDouble(txtSpecificHeat.Text);
                double spatialStep = Convert.ToDouble(txtDeltaX.Text);
                double timeStep = Convert.ToDouble(txtDeltaT.Text);
                int numNodes = Convert.ToInt32(txtNumberOfNodes.Text);

                // Calculate thermal diffusivity
                double thermalDiffusivity = thermalConductivity / (density * specificHeat);

                // Calculate the final temperature with correction
                double finalTemperature = initialTemperature + (thermalDiffusivity * time / (spatialStep * spatialStep * numNodes)) * timeStep;

                Debug.WriteLine($"thermalDiffusivity: {thermalDiffusivity}");
                Debug.WriteLine($"time / (spatialStep * spatialStep * numNodes): {time / (spatialStep * spatialStep * numNodes)}");
                Debug.WriteLine($"timeStep: {timeStep}");

                // Display the final temperature
                Debug.WriteLine($"Final Temperature: {finalTemperature:F2}");

                // Display the results
                string resultMessage = $"Calculation successful! Final Temperature: {finalTemperature:F2} °C\n";

                // Include the sample input in the output
                resultMessage += "\nSample Input:\n";
                resultMessage += $"Initial Temperature: {initialTemperature} °C\n";
                resultMessage += $"Time: {time} seconds\n";
                resultMessage += $"Thermal Conductivity: {thermalConductivity} W/(m·K)\n";
                resultMessage += $"Density: {density} kg/m³\n";
                resultMessage += $"Specific Heat: {specificHeat} J/(kg·K)\n";
                resultMessage += $"Δx (Delta X): {spatialStep} meters\n";
                resultMessage += $"Δt (Delta T): {timeStep} seconds\n";
                resultMessage += $"Number of Nodes: {numNodes}\n";

                MessageBox.Show(resultMessage, "Results");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter valid numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Input values are too large. Please enter smaller values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.FormClosed += (s, args) => this.Close();
            mainMenu.Show();
        }
    }
}

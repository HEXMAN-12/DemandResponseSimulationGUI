using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DemandResponseSimulationGUI
{
    public partial class DemandResponseSimulator : Form
    {
        private List<Consumer> consumers = new List<Consumer>();
        private double priceSignal = 0;

        public DemandResponseSimulator()
        {
            InitializeComponent();
        }

        // Consumer structure
        public class Consumer
        {
            public int ID { get; set; }
            public double InitialDemand { get; set; }
            public double Sensitivity { get; set; }
            public double AdjustedDemand { get; set; }
        }

        private void AddConsumerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate ConsumerID
                if (!int.TryParse(ConsumerID.Text, out int id) || id <= 0)
                {
                    MessageBox.Show("Please enter a valid positive integer for Consumer ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate InitialDemand
                if (!double.TryParse(InitialDemand.Text, out double initialDemand) || initialDemand <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number for Initial Demand.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate PriceSensitivity
                if (!double.TryParse(PriceSensitivity.Text, out double sensitivity) || sensitivity < 0)
                {
                    MessageBox.Show("Please enter a valid non-negative number for Price Sensitivity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (consumers.Any(c => c.ID == id))
                {
                    MessageBox.Show($"A consumer with ID {id} already exists. Please use a unique ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add consumer
                var consumer = new Consumer
                {
                    ID = id,
                    InitialDemand = initialDemand,
                    Sensitivity = sensitivity,
                    AdjustedDemand = initialDemand // Default to initial demand
                };

                consumers.Add(consumer);

                // Add to DataGridView
                dataGridView1.Rows.Add(consumer.ID, consumer.InitialDemand, consumer.Sensitivity, consumer.AdjustedDemand);

                // Clear input fields
                ConsumerID.Clear();
                InitialDemand.Clear();
                PriceSensitivity.Clear();

                MessageBox.Show($"Consumer {id} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPriceSignalButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PriceSignal.Value < 0)
                {
                    MessageBox.Show("Price Signal cannot be negative. Please enter a valid value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                priceSignal = (double)PriceSignal.Value;
                MessageBox.Show($"Price signal has been set to {priceSignal:F2}. All consumer demand calculations will reflect this value.", "Price Signal Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RunSimulationButton_Click(object sender, EventArgs e)
        {
            if (consumers.Count == 0)
            {
                MessageBox.Show("Please add consumers before running the simulation.", "No Consumers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Adjust demand based on price signal
                foreach (var consumer in consumers)
                {
                    consumer.AdjustedDemand = consumer.InitialDemand - (consumer.Sensitivity * priceSignal);
                    if (consumer.AdjustedDemand < 0)
                        consumer.AdjustedDemand = 0; // Ensure demand isn't negative
                }

                // Sort by adjusted demand
                var sortedConsumers = consumers.OrderByDescending(c => c.AdjustedDemand).ToList();

                // Update DataGridView with adjusted demands
                dataGridView1.Rows.Clear();
                foreach (var consumer in sortedConsumers)
                {
                    dataGridView1.Rows.Add(consumer.ID, consumer.InitialDemand, consumer.Sensitivity, consumer.AdjustedDemand);
                }

                // Log detailed results to RichTextBox
                richTextBox1.Clear();
                richTextBox1.AppendText("Demand Response Simulation Results:\n");
                richTextBox1.AppendText("=================================================\n");
                richTextBox1.AppendText($"Price Signal: {priceSignal:F2}\n\n");
                richTextBox1.AppendText("Consumer Details (Sorted by Adjusted Demand):\n");
                richTextBox1.AppendText("-------------------------------------------------\n");

                foreach (var consumer in sortedConsumers)
                {
                    richTextBox1.AppendText($"Consumer ID: {consumer.ID}\n");
                    richTextBox1.AppendText($"    Initial Demand: {consumer.InitialDemand:F2} kW\n");
                    richTextBox1.AppendText($"    Sensitivity: {consumer.Sensitivity:F2}\n");
                    richTextBox1.AppendText($"    Adjusted Demand: {consumer.AdjustedDemand:F2} kW\n");
                    richTextBox1.AppendText("-------------------------------------------------\n");
                }

                MessageBox.Show("Simulation completed successfully! Check the output details in the table and results box.", "Simulation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error during simulation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            consumers.Clear();
            dataGridView1.Rows.Clear();
            richTextBox1.Clear();
            MessageBox.Show("All consumer data has been cleared.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Empty/Unused Event Handlers
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void ConsumerID_TextChanged(object sender, EventArgs e) { }
        private void InitialDemand_TextChanged(object sender, EventArgs e) { }
        private void PriceSensitivity_TextChanged(object sender, EventArgs e) { }
        private void PriceSignal_ValueChanged(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
    }
}

namespace DemandResponseSimulationGUI
{
    partial class DemandResponseSimulator
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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.ConsumerID = new System.Windows.Forms.TextBox();
            this.InitialDemand = new System.Windows.Forms.TextBox();
            this.PriceSensitivity = new System.Windows.Forms.TextBox();
            this.PriceSignal = new System.Windows.Forms.NumericUpDown();
            this.AddConsumerButton = new System.Windows.Forms.Button();
            this.SetPriceSignalButton = new System.Windows.Forms.Button();
            this.RunSimulationButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDemandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SensitivityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdjustedDemandColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PriceSignal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(268, 28);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(281, 24);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Demand Response Simulator";
            // 
            // ConsumerID
            // 
            this.ConsumerID.Location = new System.Drawing.Point(664, 91);
            this.ConsumerID.Name = "ConsumerID";
            this.ConsumerID.Size = new System.Drawing.Size(106, 20);
            this.ConsumerID.TabIndex = 1;
            this.ConsumerID.TextChanged += new System.EventHandler(this.ConsumerID_TextChanged);
            // 
            // InitialDemand
            // 
            this.InitialDemand.Location = new System.Drawing.Point(664, 142);
            this.InitialDemand.Name = "InitialDemand";
            this.InitialDemand.Size = new System.Drawing.Size(106, 20);
            this.InitialDemand.TabIndex = 2;
            this.InitialDemand.TextChanged += new System.EventHandler(this.InitialDemand_TextChanged);
            // 
            // PriceSensitivity
            // 
            this.PriceSensitivity.Location = new System.Drawing.Point(664, 192);
            this.PriceSensitivity.Name = "PriceSensitivity";
            this.PriceSensitivity.Size = new System.Drawing.Size(106, 20);
            this.PriceSensitivity.TabIndex = 3;
            this.PriceSensitivity.TextChanged += new System.EventHandler(this.PriceSensitivity_TextChanged);
            // 
            // PriceSignal
            // 
            this.PriceSignal.DecimalPlaces = 2;
            this.PriceSignal.Location = new System.Drawing.Point(664, 242);
            this.PriceSignal.Name = "PriceSignal";
            this.PriceSignal.Size = new System.Drawing.Size(106, 20);
            this.PriceSignal.TabIndex = 4;
            this.PriceSignal.ValueChanged += new System.EventHandler(this.PriceSignal_ValueChanged);
            // 
            // AddConsumerButton
            // 
            this.AddConsumerButton.Location = new System.Drawing.Point(85, 303);
            this.AddConsumerButton.Name = "AddConsumerButton";
            this.AddConsumerButton.Size = new System.Drawing.Size(101, 24);
            this.AddConsumerButton.TabIndex = 5;
            this.AddConsumerButton.Text = "Add Consumer";
            this.AddConsumerButton.UseVisualStyleBackColor = true;
            this.AddConsumerButton.Click += new System.EventHandler(this.AddConsumerButton_Click);
            // 
            // SetPriceSignalButton
            // 
            this.SetPriceSignalButton.Location = new System.Drawing.Point(210, 303);
            this.SetPriceSignalButton.Name = "SetPriceSignalButton";
            this.SetPriceSignalButton.Size = new System.Drawing.Size(101, 25);
            this.SetPriceSignalButton.TabIndex = 6;
            this.SetPriceSignalButton.Text = "Set Price Signal";
            this.SetPriceSignalButton.UseVisualStyleBackColor = true;
            this.SetPriceSignalButton.Click += new System.EventHandler(this.SetPriceSignalButton_Click);
            // 
            // RunSimulationButton
            // 
            this.RunSimulationButton.Location = new System.Drawing.Point(338, 303);
            this.RunSimulationButton.Name = "RunSimulationButton";
            this.RunSimulationButton.Size = new System.Drawing.Size(101, 26);
            this.RunSimulationButton.TabIndex = 7;
            this.RunSimulationButton.Text = "Run Simulation";
            this.RunSimulationButton.UseVisualStyleBackColor = true;
            this.RunSimulationButton.Click += new System.EventHandler(this.RunSimulationButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(461, 306);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(101, 23);
            this.ClearListButton.TabIndex = 8;
            this.ClearListButton.Text = "Clear List";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(582, 306);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.InitialDemandColumn,
            this.SensitivityColumn,
            this.AdjustedDemandColumn});
            this.dataGridView1.Location = new System.Drawing.Point(48, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(444, 180);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // InitialDemandColumn
            // 
            this.InitialDemandColumn.HeaderText = "Initial Demand";
            this.InitialDemandColumn.Name = "InitialDemandColumn";
            // 
            // SensitivityColumn
            // 
            this.SensitivityColumn.HeaderText = "Sensitivity";
            this.SensitivityColumn.Name = "SensitivityColumn";
            // 
            // AdjustedDemandColumn
            // 
            this.AdjustedDemandColumn.HeaderText = "Adjusted Demand";
            this.AdjustedDemandColumn.Name = "AdjustedDemandColumn";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 10F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.Location = new System.Drawing.Point(126, 349);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(523, 129);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "Enter Values Within These Limits:\n\nConsumer ID: Positive integer (unique).\nInitia" +
    "l demand (kW): 0.1 to 1000.\nPrice sensitivity: 0.0 to 1.0.\nPrice signal: Positiv" +
    "e number.";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(525, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consumer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(525, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Initial Demand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(525, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price Sensitivity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(525, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price Signal";
            // 
            // DemandResponseSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(815, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.RunSimulationButton);
            this.Controls.Add(this.SetPriceSignalButton);
            this.Controls.Add(this.AddConsumerButton);
            this.Controls.Add(this.PriceSignal);
            this.Controls.Add(this.PriceSensitivity);
            this.Controls.Add(this.InitialDemand);
            this.Controls.Add(this.ConsumerID);
            this.Controls.Add(this.InstructionLabel);
            this.Name = "DemandResponseSimulator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PriceSignal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TextBox ConsumerID;
        private System.Windows.Forms.TextBox InitialDemand;
        private System.Windows.Forms.TextBox PriceSensitivity;
        private System.Windows.Forms.NumericUpDown PriceSignal;
        private System.Windows.Forms.Button AddConsumerButton;
        private System.Windows.Forms.Button SetPriceSignalButton;
        private System.Windows.Forms.Button RunSimulationButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialDemandColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SensitivityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdjustedDemandColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


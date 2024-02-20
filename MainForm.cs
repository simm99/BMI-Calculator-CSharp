namespace Assignment_3_windowsforms
{
    public partial class MainForm : Form
    {
        // Declare the BMICalculator instance here
        private BMICalculator bmiCalculator = new BMICalculator();

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            // Initialize height and weight variables
            double height = 0, weight = 0;
            bool heightParsed = false, weightParsed = double.TryParse(txtWeight.Text, out weight);
            string userName = txtName.Text; // Get the user's name from txtName

            // Parsing height based on unit system selected
            if (rbMetric.Checked)
            {
                heightParsed = double.TryParse(txtHeight.Text, out height);
                height /= 100; // Convert cm to meters for Metric
            }
            else if (rbImperial.Checked)
            {
                // Assuming additional TextBoxes txtHeightFeet and txtHeightInches are used for Imperial
                bool feetParsed = double.TryParse(txtHeightFeet.Text, out double feet);
                bool inchesParsed = double.TryParse(txtHeightInches.Text, out double inches);
                if (feetParsed && inchesParsed)
                {
                    height = feet * 12 + inches; // Convert feet and inches to total inches
                    heightParsed = true;
                }
            }

            // Check if inputs are valid and positive
            if (heightParsed && weightParsed && height > 0 && weight > 0)
            {
                // Set properties in bmiCalculator
                bmiCalculator.Height = height;
                bmiCalculator.Weight = weight;
                bmiCalculator.UnitType = rbMetric.Checked ? UnitTypes.Metric : UnitTypes.Imperial;

                // Calculate BMI
                double bmi = bmiCalculator.CalculateBMI();
                string category = bmiCalculator.DetermineWeightCategory(bmi);

                // Display BMI result and category
                lblResult.Text = $"Your BMI: {bmi:F2}"; // Make sure you have a label named lblResult on your form
                lblWeightCategory.Text = $"Weight Category: {category}"; // Make sure you have a label named lblWeightCategory on your form

                // Update the GroupBox title to include the user's name
                groupBox2.Text = !string.IsNullOrWhiteSpace(userName) ? $"Results for {userName}" : "Results";

                // After calculating min and max weight for the normal BMI range
                double minWeight = bmiCalculator.CalculateMinNormalWeight();
                double maxWeight = bmiCalculator.CalculateMaxNormalWeight();

                // Check the unit system and adjust the display text accordingly
                if (bmiCalculator.UnitType == UnitTypes.Metric)
                {
                    // For Metric, display the weight range in kilograms (kg)
                    lblNormalWeightRange.Text = $"Normal Weight Range: {minWeight:F2} kg - {maxWeight:F2} kg";
                }
                else // For Imperial
                {
                    // For Imperial, display the weight range in pounds (lbs)
                    lblNormalWeightRange.Text = $"Normal Weight Range: {minWeight:F2} lbs - {maxWeight:F2} lbs";
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numerical values for height and weight.");
            }
        }


        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbMetric_CheckedChanged(object sender, EventArgs e)
        {
            bool isMetricSelected = rbMetric.Checked;
            txtHeight.Visible = isMetricSelected; // Show for Metric
            txtHeightFeet.Visible = !isMetricSelected; // Hide for Metric
            txtHeightInches.Visible = !isMetricSelected; // Hide for Metric
            // If Metric is selected, hide the ft and in labels
            lblFt.Visible = rbImperial.Checked;
            lblIn.Visible = rbImperial.Checked;
            if (rbMetric.Checked)
            {
                label2.Text = "Height (cm)";
                label3.Text = "Weight (kg)";
            }
        }

        private void rbImperial_CheckedChanged(object sender, EventArgs e)
        {
            bool isImperialSelected = rbImperial.Checked;
            txtHeight.Visible = !isImperialSelected; // Hide for Imperial
            txtHeightFeet.Visible = isImperialSelected; // Show for Imperial
            txtHeightInches.Visible = isImperialSelected; // Show for Imperial
            // If Imperial is selected, show the ft and in labels
            lblFt.Visible = rbImperial.Checked;
            lblIn.Visible = rbImperial.Checked;
            if (rbImperial.Checked)
            {
                label2.Text = "Height";
                label3.Text = "Weight (lbs)";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rbMetric.Checked = true;
        }
    }
}

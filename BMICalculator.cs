public enum UnitTypes
{
    Metric,
    Imperial
}

public class BMICalculator
{
    public double Weight { get; set; }
    public double Height { get; set; }
    public UnitTypes UnitType { get; set; }

    public double CalculateBMI()
    {
        if (UnitType == UnitTypes.Metric)
        {
            return Weight / (Height * Height);
        }
        else // Imperial
        {
            return (703 * Weight) / (Height * Height);
        }
    }

    public string DetermineWeightCategory(double bmi)
    {
        if (bmi < 18.5) return "Underweight";
        else if (bmi >= 18.5 && bmi <= 24.9) return "Normal weight";
        else if (bmi >= 25 && bmi <= 29.9) return "Overweight (Pre-obesity)";
        else if (bmi >= 30 && bmi <= 34.9) return "Overweight (Obesity class I)";
        else if (bmi >= 35 && bmi <= 39.9) return "Overweight (Obesity class II)";
        else return "Overweight (Obesity class III)";
    }

    public double CalculateMinNormalWeight()
    {
        double factor = UnitType == UnitTypes.Metric ? 1 : 703;
        return 18.5 * (Height * Height) / factor;
    }

    public double CalculateMaxNormalWeight()
    {
        double factor = UnitType == UnitTypes.Metric ? 1 : 703;
        return 24.9 * (Height * Height) / factor;
    }
}

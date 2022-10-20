namespace Unit_Testing;

public class CalculateIdealWeight
{
    public double Height { get; set; }
    public string? Gender { get; set; }

    public double GetIdealWeight()
    {
        switch (Gender)
        {
            case "Male":
                return (Height - 100) - ((Height - 150) / 4);
            case "Female":
                return (Height - 100) - ((Height - 150) / 2);
            default:
                return 0;
        }
    }
}

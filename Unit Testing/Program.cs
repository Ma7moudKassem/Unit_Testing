using Unit_Testing;

CalculateIdealWeight calculateIdealWeight = new CalculateIdealWeight
{
    Height = 180,
    Gender = "Female",
};

Console.WriteLine(calculateIdealWeight.GetIdealWeight());
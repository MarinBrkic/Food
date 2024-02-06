using System;

public class FoodType
{
    private string name;
    private int protein;
    private int carbs;
    private int fat;
    private static int counter = 0;

    public FoodType(string name, int protein, int carbs, int fat)
    {
        this.name = name;
        this.protein = protein;
        this.carbs = carbs;
        this.fat = fat;
        counter++;
    }

    public string Name { get { return name; } }
    public int Protein { get { return protein; } }
    public int Carbs { get { return carbs; } }
    public int Fat { get { return fat; } }

    public static int GetNumberOfCreatedInstances()
    {
        return counter;
    }

    public string ToString()
    {
        return $"{name}: p - {protein}%, c - {carbs}%, f - {fat}%";
    }
}

public class Food
{
    private FoodType type;
    private int weight;

    public Food(FoodType type, int weight)
    {
        this.type = type;
        this.weight = weight;
    }

    public FoodType Type { get { return type; } }
    public int Weight { get { return weight; } }

    public double GetProtein()
    {
        return (type.Protein / 100.0) * weight;
    }

    public double GetCarbs()
    {
        return (type.Carbs / 100.0) * weight;
    }

    public double GetFat()
    {
        return (type.Fat / 100.0) * weight;
    }

    public string ToString()
    {
        return $"{type.ToString()}, w – {weight}g";
    }

    public string ToStringInGrams()
    {
        return $"{type.Name}: p – {GetProtein():F1}g, c – {GetCarbs():F1}g, f – {GetFat():F1}g, w – {weight}g";
    }
}

class Program
{
    static void Main()
    {
        FoodType foodType = new FoodType("banana", 4, 93, 3);
        Food food = new Food(foodType, 110);

        Console.WriteLine(food.ToString());
        Console.WriteLine(food.ToStringInGrams());
        Console.WriteLine($"Broj kreiranih instanci FoodType: {FoodType.GetNumberOfCreatedInstances()}");
    }

}
using System;
class HomeAnimals
{
    public enum TypeOfAnimal
    {
        Dog = 1,
        Cat,
        Pig,
        Horse,
        Chupakabra
    }
 
    private string name;
    private double weight;
    private TypeOfAnimal type;
   
    public HomeAnimals(string name, double weight, TypeOfAnimal type)
    {
        this.name = name;
        this.weight = weight;
        this.type = type;
    }

    
    public string Name
    {
        set
        {
            name = value;
        }
        get
        {
            return name;
        }
    }

    public double Weight
    {
        set
        {
            if (value > 0)
                weight = value;
        }
        get
        {
            return weight;
        }
    }
    public TypeOfAnimal Type
    {
        set
        {
            type = value;
        }
        get
        {
            return type;
        }
    }

   
    public string CompareWeight(double weight)
    {
        if (this.weight < weight)
            return "Этот зверь весит меньше";
        else if (this.weight == weight)
            return "Этот зверь точно такого веса";
        else return "Этот зверь тяжелее";
    }

    public string CompareWeight(HomeAnimals animal)
    {
        if (this.weight < animal.Weight)
            return "Этот зверь весит меньше";
        else if (this.weight == animal.Weight)
            return "Этот зверь точно такого веса";
        else return "Этот зверь тяжелее";
    }
}


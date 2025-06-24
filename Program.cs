using System;

public interface IPrototype
{
    IPrototype Clone();
}

public class ConcretePrototype : IPrototype
{
    public int Id { get; set; }
    public string Name { get; set; }

    public IPrototype Clone()
    {
        return (IPrototype)this.MemberwiseClone();
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}");
    }
}

class Program
{
    static void Main()
    {
        ConcretePrototype original = new ConcretePrototype { Id = 1, Name = "Original" };
        ConcretePrototype clone = (ConcretePrototype)original.Clone();

        clone.Id = 2;
        clone.Name = "Clone";

        original.Display(); 
        clone.Display();     
    }
}
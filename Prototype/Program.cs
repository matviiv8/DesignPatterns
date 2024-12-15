using Prototype;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person
        {
            Age = 42,
            BirthDate = Convert.ToDateTime("1977-01-01"),
            Name = "Jack Daniels",
            IdInfo = new IdInfo(666)
        };

        Person person2 = person1.ShallowCopy();
        Person person3 = person1.DeepCopy();

        Console.WriteLine("Original values of person1, person2, and person3:");
        DisplayValues("person1", person1);
        DisplayValues("person2", person2);
        DisplayValues("person3", person3);

        person1.Age = 32;
        person1.BirthDate = Convert.ToDateTime("1900-01-01");
        person1.Name = "Frank";
        person1.IdInfo.IdNumber = 7878;

        Console.WriteLine("\nAfter modifying person1:");
        DisplayValues("person1", person1);
        DisplayValues("person2", person2);
        DisplayValues("person3", person3);
    }

    static void DisplayValues(string label, Person person)
    {
        Console.WriteLine($"{label} -> Name: {person.Name}, Age: {person.Age}, BirthDate: {person.BirthDate:MM/dd/yy}, ID#: {person.IdInfo.IdNumber}");
    }
}
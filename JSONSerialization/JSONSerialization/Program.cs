// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.IO;
public class Person
{
    public string? Name  { get; set; }
    public byte Age { get; set; }
    public string? Summary { get; set; }

    public string? Gender { get; set; }
}

public class Program
{

    public static void Main()
    {
        
        var joana = new Person
        {
            Name = "JOana",
            Age = 25,
            Summary = "cool",
            Gender = "female"
        };

        var hanna = new Person
        {
            Name = "HAnna",
            Age = 30,
            Summary = "cool",
            Gender = "female"
        };

        List<Person> personList = new List<Person>();
        personList.Add(joana); 
        personList.Add(hanna);    


        string filename = @"..\..\..\person.txt";
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize<List<Person>>(personList, options);

        // Überprüfung
        Console.WriteLine(jsonString);
        
        // JSON string in das File schreiben
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(jsonString);
        }

       // Liste von Personen vom File als Objekte eingelesen
        List<Person> r_personList;

        using (StreamReader r = new StreamReader(filename))
        {
            string json = r.ReadToEnd();
            // Ein Objekt wird aus dem JSON String kreiert
            r_personList = JsonSerializer.Deserialize<List<Person>>(json);
        }


        foreach (var item in r_personList)
        {
            Console.WriteLine(item.Name);
            Console.WriteLine(item.Age);
            Console.WriteLine(item.Summary);
            Console.WriteLine(item.Gender);
        }




        Console.Read();
    }
}

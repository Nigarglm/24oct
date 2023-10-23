namespace _24oct_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> students = new List<Person>
            {
                new Person {Name="Nuray",Surname="Memmedova",Age=19},
                new Person {Name="Huseyn",Surname="Huseynov",Age=22},
                new Person {Name="Aytac",Surname="Yusifli",Age=23 },
            };

            var name = students.FindAll(p => p.Name=="Nuray");
            foreach (var person in name) 
            {
                Console.WriteLine(person.Name);
            }

            var surname = students.FindAll(p => p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));
            foreach (var person in surname)
            {
                Console.WriteLine($"Soyadi 'ov' ve 'ova' ile biten telebe: {person.Name} {person.Surname} ");
            }

            var age = students.FindAll(p => p.Age >= 20);
            foreach(var person in age)
            {
                Console.WriteLine($"Yashi 20-den chox olan telebe: {person.Name} {person.Surname}");
            }

        }
    }
}
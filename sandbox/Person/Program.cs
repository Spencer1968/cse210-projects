class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        // if (person is Doctor d)
        // {
        //     Console.WriteLine(d.GetPersonInformation());
        // }
        // else if (person is Police p) {
        //     Console.WriteLine(p.GetPersonInformation());
        // }
        // else
        // {
        //     Console.WriteLine(person.GetPersonInformation());
        // }
        Console.Write($"Salary: {person.GetSalary()} ");
        Console.WriteLine(person.GetPersonInformation());
    }
    public static void Main()
    {
        // Person myPerson = new Person("John", "Revelator", 50, 180.0);
        // Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 45, 279, "knife");
        // Console.WriteLine(myDoctor.GetPersonInformation());
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        Police myPolice = new Police("Gary", "Goodman", 61, 181, "Guns");
        // Console.WriteLine(myPolice.GetPoliceInformation());

        List<Person> myPeople = new List<Person>();

        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }
}
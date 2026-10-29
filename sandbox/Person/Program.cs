class Program
{
    public static void Main()
    {
        Person myPerson = new Person("John", "Revelator", 50, 180.0);
        Console.WriteLine(myPerson.GetPersonInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 45, 279, "knife");
        Console.WriteLine(myDoctor.GetPersonInformation());
        Console.WriteLine(myDoctor.GetDoctorInformation());

        Police myPolice = new Police("Gary", "Goodman", 61, 181, "Guns");
        Console.WriteLine(myPolice.GetPoliceInformation());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myDoctor);
        myPeople.Add(myPerson);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
            Console.WriteLine(person.GetPersonInformation());
        }
    }
}
class Police : Person
{
    private string _weapons;
    public Police(string firstname, string lastName, int age, double weight, string weapons)
    : base(firstname, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public string GetPoliceInformation()
    {
        // return $"Tools: {_tools}: {GetPersonInformation()}";
        return $"{GetPersonInformation()} and uses a {_weapons}";
    }
}
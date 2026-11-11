class Police : Person
{
    private string _weapons;
    public Police(string firstname, string lastName, int age, double weight, string weapons)
    : base(firstname, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public override string GetPersonInformation()
    {
        // return $"Tools: {_tools}: {GetPersonInformation()}";
        return $"{base.GetPersonInformation()} and uses {_weapons}";
    }

    public override double GetSalary()
    {
        return 145000.21;
    }
}
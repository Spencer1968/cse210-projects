class Doctor : Person
{
    private string _tools;
    public Doctor(string firstname, string lastName, int age, double weight, string tools)
    : base(firstname, lastName, age, weight)
    {
        _tools = tools;
    }

    public override string GetPersonInformation()
    {
        // return $"Tools: {_tools}: {GetPersonInformation()}";
        return $"{base.GetPersonInformation()} and uses {_tools}";
    }

    public override double GetSalary()
    {
        return 550000;
    }
}
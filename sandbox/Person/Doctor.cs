class Doctor : Person
{
    private string _tools;
    public Doctor(string firstname, string lastName, int age, double weight, string tools)
    : base(firstname, lastName, age, weight)
    {
        _tools = tools;
    }

    public string GetDoctorInformation()
    {
        // return $"Tools: {_tools}: {GetPersonInformation()}";
        return $"{GetPersonInformation()} and uses a {_tools}";
    }
}
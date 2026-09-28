 namespace HR_system
 {
    internal abstract class   Person 
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public void setName(string firstName, string lastName)
    {
        if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException("First name and last name cannot be empty.");
        }
        FirstName = firstName;
        LastName = lastName;
    }
    

    public DateTime DateofBirth  { get; private set ; }
    

    public double Basicsalary { get; set; }

   public void setDateofBirth(DateTime dateOfBirth)
{
    if (dateOfBirth > DateTime.Now)
    {
        throw new ArgumentException("Date of birth cannot be in the future.");
    }

    DateofBirth = dateOfBirth;
}
}
}

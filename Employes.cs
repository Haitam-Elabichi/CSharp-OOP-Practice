using HR_system;

var employee = new Employee();
employee.setName("John Doe", "Smith");
employee.Position = "Software Engineer";
employee.setDateofBirth(new DateTime(1998, 5, 15));
employee.TaxPercentage = 20.0;
employee.Salary = 80000.0;
employee.Basicsalary = 60000.0;

PrintPesronDetails(employee);

Console.WriteLine($"Position: \t {employee.Position}");
Console.WriteLine($"Salary: \t ${employee.Salary:f1}");
Console.WriteLine($"Tax Percentage: \t {employee.TaxPercentage:f1}%");

Console.WriteLine("---------------------------------");


var applicant = new Applicant();
applicant.setName("Jane", "Doe");
applicant.setDateofBirth(new DateTime(1995, 8, 20));
applicant.Basicsalary = 50000.0;


PrintPesronDetails(applicant);









void PrintPesronDetails(Person person)
{
    Console.WriteLine($"Full Name: \t {person.FirstName} {person.LastName}");

  
     
    Console.WriteLine($"Basic Salary: \t ${person.Basicsalary:f1}");
    Console.WriteLine($"Date of Birth: \t {person.DateofBirth:d}");
}
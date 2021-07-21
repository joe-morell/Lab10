using System;
class Employee {

  // Fields
  private string firstname;
  private string id;
  private int age;
  private string lastname;
  private string address;
  private string phoneNumber;
  private string title;
  private double yearlySalary;
  private string employmentStatus;

  // Properties
  public string Firstname {get; set;}
  public string Lastname {get; set;}
  public string Id {get; set;}
  public string EmploymentStatus{get; set;}
  public int Age {
    get { return age;}
    set {
      if (value >= 18) {
        age = value;
      }
      else {
        age = 18;
      }
    }
  }
  public double YearlySalary {
    get { return yearlySalary; }
    set { 
      if (value >= 1000) {
        yearlySalary = value;
      }
      else {
        yearlySalary = 1000;
      }
    }
  }

  public Employee() {

    Firstname = "Uknown";
    Lastname = "Uknown";
    Id = "Unknown";
    Age = 0;
    EmploymentStatus = "Active";

  }

  public Employee (string eFirstname, string eLastname, string eId, int eAge, double eYearlySalary) {

    Firstname = eFirstname;
    Lastname = eLastname;
    Id = eId;
    Age = eAge;
    YearlySalary = eYearlySalary;
    EmploymentStatus = "Active";

  }

  public void Intro() {

    Console.WriteLine("Firstname: " + Firstname);
    Console.WriteLine("Lastname: " + Lastname);
    Console.WriteLine("Age: " + Age);
    Console.WriteLine("ID: " + Id);

  }

  public void IncreaseSalary(double percent) {

    if (percent >= 0) {
      YearlySalary = YearlySalary * (1 + (percent / 100));
      Console.WriteLine("Yearly salary updated to " + YearlySalary);
    }
    else {
      Console.WriteLine("Invalid input, Yearly Salary not updated");
    }
  }

  public void RemoveEmployee() {

    if (EmploymentStatus == "Inactive") {
      Console.WriteLine("Employee already inactive");
    }
    else if (EmploymentStatus == "Active") {
      EmploymentStatus = "Inactive";
      Console.WriteLine("Employee removed");
    }

  }
}
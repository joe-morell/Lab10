using System;

class MainClass {
  public static void Main (string[] args) {

    Employee employee1 = new Employee();
    employee1.Intro();

    Employee employee2 = new Employee("Robert", "Downey", "12321", 12, 100);
    employee2.Intro();
    Console.WriteLine("Yearly Salary: " + employee2.YearlySalary);

    Employee employee3 = new Employee("John", "Smith", "S0089", 38, 50000);
    employee3.Intro();
    Console.WriteLine("Yearly Salary: " + employee3.YearlySalary);
    employee3.IncreaseSalary(-2);
    employee3.RemoveEmployee();

    Employee employee4 = new Employee("Maria", "Lambert", "S0100", 26, 80000);
    employee4.Intro();
    Console.WriteLine("Yearly Salary: " + employee4.YearlySalary);
    employee4.IncreaseSalary(7);
    employee4.RemoveEmployee();
    employee4.RemoveEmployee();

   


  }
}

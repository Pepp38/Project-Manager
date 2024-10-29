// Employees information is stored in the Employees table.

using System;
using System.Collections.Generic;

public class Employee
{
    public int Id { get; set; } // Primary key
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public DateTime HireDate { get; set; }
    public decimal Salary { get; set; }
    public decimal Bonus { get; set; }
    public decimal TotalSalary => Salary + Bonus; // Automatic calculation of total salary

    // One-to-many relationship with the Projet table
    public ICollection<Projet> Projets { get; set; } = new List<Projet>();

    public Employee() {}

    public Employee(string lastName, string firstName, string email, string phone, string position, DateTime hireDate, decimal salary, decimal bonus)
    {
        this.LastName = lastName;
        this.FirstName = firstName;
        this.HireDate = hireDate;
        this.Salary = salary;
        this.Bonus = bonus;
    }
}
using System;

class MainClass {
  public static void Main (string[] args) {

		// EMPLOYEE PRACTICE APP
		EmployeeModel employee = new EmployeeModel
		(
			"Jeff",
			"Eckman",
			"j03@gmail.com",
			"123-456-7890",
			111,
			EmployeePostion.Manager,
			80000.00
		);

		Console.WriteLine(employee.ToString());

		employee.GetRaise();

		Console.WriteLine(employee.ToString());

    Console.ReadLine();
  }
}

public class PersonModel
{
	private string FirstName { get; set; }
	private string LastName { get; set; }
	private string Email { get; set; }
	private string PhoneNumber { get; set; }

	public PersonModel(string FirstName, string LastName, string Email, string PhoneNumber)
	{
		this.FirstName = FirstName;
		this.LastName = LastName;
		this.Email = Email;
		this.PhoneNumber = PhoneNumber;
	}

	public override string ToString()
	{
		return $@"
		Name: { FirstName } { LastName }
		Email: { Email }
		Phone Number: { PhoneNumber }";
	}
}

public class EmployeeModel : PersonModel
{
	private int EmployeeID { get; set; }
	private EmployeePostion position;
	private double salary;

	public EmployeePostion Position
	{
		get
		{
			return position;
		}
	}

	public double Salary
	{
		get
		{
			return salary;
		}
	}

	public EmployeeModel(string FirstName, string LastName, string Email, string PhoneNumber, int EmployeeID, EmployeePostion position, double salary)
	: base(FirstName, LastName, Email, PhoneNumber)
	{
		this.EmployeeID = EmployeeID;
		this.position = position;
		this.salary = salary;
	}

	public override string ToString()
	{
		return $@"
		{ base.ToString() }
		Employee ID: { EmployeeID }
		Postion: { Position }
		Salary: { Salary }";
	}

	public void GetRaise()
	{
		salary += Pay.Raises(this);
	}
}

public class Pay
{
	public static double Raises(EmployeeModel employee)
	{
		double raise;

		if (employee.Position == EmployeePostion.Floor)
		{
			raise = 0.20;	
		}
		else if (employee.Position == EmployeePostion.Lead)
		{
			raise = 0.40;
		}
		else
		{
			raise = 0.60;
		}

		return raise * employee.Salary;
	} 
}

public enum EmployeePostion
{
	Floor,
	Lead,
	Manager
}


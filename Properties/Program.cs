using System;
public class Student()
{
    private int _id;
    private string _name;
    private string _email;


    public void setdetail(string NAME, string Email)
    {
        if (string.IsNullOrEmpty(NAME))
        {
            throw new Exception("There is no name enterd by user");
        }
        else if (string.IsNullOrEmpty(Email))
        {
            throw new Exception("there is no email entered by user");

        }
        else
        {
            this._name = NAME;
            this._email = Email;
        }
    }

    public void SetData(int ID)
    {
        if (ID < 0)
        {
            throw new Exception("this id noun be negative");

        }
        else
        {
            this._id = ID;
        }
    }
    public string Getemail()
    {

        return this._email;
    }
    public string Getname()
    {
        return this._name;
    }

    public int getid()
    {
        return this._id;
    }
}
class Program { 
public static void Main()
{
Student student = new Student();
        Console.WriteLine("Please Enter id");
        student.SetData(int.Parse(Console.ReadLine()));
        Console.WriteLine("Enter the name ");
        Console.WriteLine("Enter email");
        student.setdetail(Console.ReadLine(),Console.ReadLine());
        Console.WriteLine("Student Id =\t{0}",student.getid());
        Console.WriteLine("Name =\t{0}\nEmail =\t{1}",student.Getname(),student.Getemail());
        



    }
}
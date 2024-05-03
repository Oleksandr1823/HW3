using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserApp;

internal class User
{
    private string _FirstName;
    private string _lastName;
    private GenderType _Gender;
    public string FirstName
    {
        get => _FirstName;
        set => _FirstName = EnterName("FirstName", value);
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = EnterName("LastName", value);
    }

    public int Age { get; init; }

    public GenderType Gender
    {
        get => _Gender;
        set => _Gender = value;
    }

    public User()
    {
        
    }

    public User(string firstName, string lastName, GenderType gender)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Age = 20;
    }

    public void EnterGender(string genderStr)
    {
        do
        {
            if (Enum.TryParse(genderStr, true, out GenderType gender))
            {
                _Gender = gender;
                break;
            }
            Console.WriteLine("Invalid input. Gender must be a value (Male, Female, or Unknown). Try again.");
            genderStr = Console.ReadLine();
        } while (true);
    }

    private string EnterName(string nameFild, string name)
    {
        do
        {
            if (Regex.IsMatch(name, @"^[^\d\s]+$"))
            {
                return name;
            }
            Console.WriteLine(nameFild + " must be a text value. Try again.");
            name = Console.ReadLine();
        } while (true);
    }

    public override string ToString()
    {
        if (Age > 10)
        {
            return $"Hi, my name is {FirstName} and last name {LastName}. I am {Age} years old. I am {Gender}";
        }
        else
        {
            return $"Hi, my name is {FirstName} and last name {LastName}. I am a baby. I am {Gender}";
        }
    }
}
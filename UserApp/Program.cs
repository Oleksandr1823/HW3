
using System.Reflection;
using System.Text.RegularExpressions;
using UserApp;

var user1 = new User("Oleksandr", "Rohanov", GenderType.Male);
Console.WriteLine(user1);

var user2 = new User
{
    Age = 8
};
Console.Write("Enter First Name: ");
user2.FirstName = Console.ReadLine();

Console.Write("Enter Last Name: ");
user2.LastName = Console.ReadLine();

Console.Write("Enter gender (Male, Female або Unknown): ");
string str = Console.ReadLine();
user2.EnterGender(str);

Console.WriteLine(user2);


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
int age = -2;
if (age >= 0)
{
    System.Console.WriteLine("valid");
}
else
{
    System.Console.WriteLine("invalid");
}
*/
/*
int age = -2;
string result = (age >= 0) ? "valid" : "invalid";
Console.WriteLine(result);
*/
/*
double value = 20D/6D;
Console.WriteLine(value);
Console.WriteLine(string.Format("{0:0.00}", value));
*/


//  // tryparase function
//  Console.WriteLine("enter a number :");
//  int numInput = Convert.ToInt32(Console.ReadLine());

//arrays


// int[] scores = { 3, 6, 99, 12 };

// //Console.WriteLine($"Array size: {scores.Count()}");

// foreach (var item in scores)
// {
//     // Console.WriteLine($"Array item: {item}");

// }


// int[] ages = new int[] { 3, 5, 66, 7 };
// int v = ages.First();
// Console.WriteLine(v);

// var names = new string[] { "mike", "steve" };

// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine($"Array item: {names[i]}");
// }
/*

int AddTwoNumber(int    first, int second, int third = 0)
{
    var sum = first + second + third;
    Console.WriteLine(sum);
    return sum;
 }

bool IsAdult(int age)
{
    if (age >= 18)
    {
        return true;
    }
    else
    {
        return false;
    }
}


//method overloading

var mySchool = new School();

mySchool.PrintName("Zee");
mySchool.PrintName("OLa");
mySchool.PrintName("OLa", 22);





// Console.WriteLine("Enter your age: ");
// var studentAge = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Student age {studentAge}, Is adult: {IsAdult(studentAge)}");




// var number = AddTwoNumber(44, 8);
// AddTwoNumber(10, 33);
// AddTwoNumber(5, 8, 1000);

*/
// int AddTwoNumber(int firstNumber, int secondNumber)
// {
//     int sum = firstNumber + secondNumber;
//     Console.WriteLine(sum);
//     return sum;
// }
//     int Sum =  AddTwoNumber(89,34);
//     Console.WriteLine("Enter first number :" );  


using OOP;

BankAccount account1 = new BankAccount("Mickael Jones", "082983302330", 0);
// account1.AccountName = "Mickael Jones";
// account1.AccountNumber = "082983302330";
account1.Credit(3000);  
account1.Credit(5000);


var account2 = new BankAccount();
account2.AccountName = "Alhaji Sule";
account2.AccountNumber = "829299828308";
account2.Credit(300);
account2.Credit(660);
account1.WalletId = "ederdkjfdjkslksksffsfs";

Console.WriteLine($"My  account name is {account1.AccountName.ToUpper()} " +
$"with account number: {account1.AccountNumber} \n. My balance is ${account1.Balance} Crypto WalletId: {account1.WalletId}");

account1.Debit(7000);

Console.WriteLine("Account Balance = " + account1.Balance);
Console.WriteLine("Account2 Balance = " + account2.Balance);



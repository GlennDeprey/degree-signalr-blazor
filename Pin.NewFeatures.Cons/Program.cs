using Pin.NewFeatures.Cons.Models;
using Pin.NewFeatures.Cons.Types;
using System.Text;


var consLog = new StringBuilder();

// PRIMARY CONSTRUCTOR
consLog.AppendLine($"PRIMARY CONSTRUCTOR - EXAMPLE 1");
consLog.AppendLine($"-----------------------------------------");
// Example 1 - Primary constructor directly added to the class itself
// This is a primary constructor
var student = new Student("Glenn", "Deprey");
consLog.AppendLine($"Student: {student.Fullname}");
student.ChangeName("Kiano", "Deprey");
consLog.AppendLine($"Student: {student.Fullname}");
consLog.AppendLine($"-----------------------------------------");
consLog.AppendLine($"PRIMARY CONSTRUCTOR - EXAMPLE 2");
consLog.AppendLine($"-----------------------------------------");

// Example 2 - Primary constructor with default values
var howestStudent = new HowestPerson("Glenn", "Deprey");
consLog.AppendLine($"Howest {howestStudent.Status}: {howestStudent.Fullname} with email {howestStudent.Email}");

// Student to staff
var howestDries = new HowestPerson("Dries", "Deboosere");
consLog.AppendLine($"Howest {howestDries.Status}: {howestDries.Fullname} with email {howestDries.Email}");
howestDries.ChangeStatus(HowestPersonType.Staff);
consLog.AppendLine($"Howest {howestDries.Status}: {howestDries.Fullname} with email {howestDries.Email}");

// Staff
var howestJoachim = new HowestPerson("Joachim", "FRANÇOIS", HowestPersonType.Staff);
consLog.AppendLine($"Howest {howestJoachim.Status}: {howestJoachim.Fullname} with email {howestJoachim.Email}");
consLog.AppendLine($"-----------------------------------------");

//////////////////////////////////////////////////////////////////////////////////////

// COLLECTION EXPRRSSIONS
consLog.AppendLine($"COLLECTION EXPRRSSIONS - EXAMPLE 1");
consLog.AppendLine($"-----------------------------------------");
// Example 1
// Adding different types based on IEnumerable
List<int> numbers1 = new List<int> { 1, 5 , 4, 78 , 12};
HashSet<int> numbers2 = new HashSet<int>{ 6, 7, 8, 9, 10 };

int[] MergeNumbersArray(IEnumerable<int> first, IEnumerable<int> second)
    => [.. first, .. second];

// Combining everything depending on IEnumerable<int>
int[] mergedNumbers = MergeNumbersArray(numbers1, numbers2);
consLog.AppendLine($"Final values: {string.Join(", ", mergedNumbers)}");
consLog.AppendLine($"-----------------------------------------");

consLog.AppendLine($"COLLECTION EXPRRSSIONS - EXAMPLE 2");
consLog.AppendLine($"-----------------------------------------");

// Example 2
// Mix and match
int[] array1 = [1, 2, 3, 4];
int[] finalvalues = [0, .. array1, 5, 6];
consLog.AppendLine($"Final values: {string.Join(", ", finalvalues)}");
consLog.AppendLine($"-----------------------------------------");

consLog.AppendLine($"COLLECTION EXPRRSSIONS - EXAMPLE 3");
consLog.AppendLine($"-----------------------------------------");

// Example 3
// Hides the new List<int>() constructor
List<int> test = [];
consLog.AppendLine("You can write List<int> test = []; This is the same as creating a new list");
consLog.AppendLine($"-----------------------------------------");

//////////////////////////////////////////////////////////////////////////////////////


// DEFAULT LAMBDA PARAMETERS
// Example 1
consLog.AppendLine($"DEFAULT LAMBDA PARAMETERS - EXAMPLE 1");
consLog.AppendLine($"-----------------------------------------");

decimal salePrice = 45m;
var calculateWithTax = (decimal price, decimal tax = 0.2m) =>
{
    var result = price + (price * tax);
    consLog.AppendLine($"Price with {tax * 100}% tax: {result}");
};

calculateWithTax(salePrice); // 54
calculateWithTax(salePrice, 0.3m); // 58.5
calculateWithTax(salePrice, 0.1m); // 49.5
calculateWithTax(salePrice, 0.5m); // 67.5
calculateWithTax(salePrice, 0.0m); // 45
// Calculate with trump tariffs
calculateWithTax(salePrice, 1.25m); // 101.25

consLog.AppendLine($"-----------------------------------------");

// Example 2
// System to do actions on a bank account
consLog.AppendLine($"DEFAULT LAMBDA PARAMETERS - EXAMPLE 2");
consLog.AppendLine($"-----------------------------------------");
decimal balance = 400m;
var atmSystem = (decimal balance = 0, decimal inputAmount = 0, PaymentType type = PaymentType.Summary) =>
{
    if (inputAmount < 0)
    {
        consLog.AppendLine("Input Amount cannot be negative.");
        return;
    }

    switch (type)
    {
        case PaymentType.Deposit:
            balance += inputAmount;
            consLog.AppendLine($"Current balance: {balance}");
            break;
        case PaymentType.Withdraw:
            if (balance >= inputAmount)
            {
                balance -= inputAmount;
                consLog.AppendLine($"Current balance: {balance}");
            }
            else
            {
                consLog.AppendLine("Insufficient funds.");
            }
            break;
        case PaymentType.Summary:
            consLog.AppendLine($"Current balance: {balance}");
            break;
        default:
            consLog.AppendLine("Invalid payment option.");
            break;
    }
};
// Wrong input amount
atmSystem(balance, -500, PaymentType.Deposit);

// summary of balance
atmSystem(balance);

// deposit
atmSystem(balance, 1000, PaymentType.Deposit);

// withdraw to much
atmSystem(balance, 500, PaymentType.Withdraw);

// withdraw
atmSystem(balance, 100, PaymentType.Withdraw);

// Add to negative balance
atmSystem(-balance, 1000, PaymentType.Deposit);

// Wrong case
atmSystem(balance, 1000, PaymentType.WrongCase);
consLog.AppendLine($"-----------------------------------------");

Console.WriteLine(consLog.ToString());
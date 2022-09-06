using PasswordGenerator;
using password_generator_test_app;

var pwdPrefix = new Password().IncludeUppercase().LengthRequired(2);
var pwdSuffix = new Password().IncludeNumeric().LengthRequired(6);
RandomGenerator randomGenerator = new RandomGenerator();
var prefix = "";
do 
{
    prefix = randomGenerator.RandomString(2);
} while (prefix.Contains("I") && prefix.Contains("O"));
var password = randomGenerator.RandomString(2, false) + pwdSuffix.Next();
Console.WriteLine($"New password is {password}");



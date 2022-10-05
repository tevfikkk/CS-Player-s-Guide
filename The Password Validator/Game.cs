Console.Write("Provide a password: ");
string? password = Console.ReadLine();

PasswordValidator passwordValidator = new PasswordValidator(password ?? string.Empty);

if (passwordValidator.PasswordLenght())
{
    Console.WriteLine("Password must be between 6 and 13 characters long.");
}

if (passwordValidator.SymbolAndT())
{
    Console.WriteLine("Password mustn't contain the letter T and the symbol &.");
}

if (!passwordValidator.UpperLowerDigit())
{
    Console.WriteLine("Password must contain upper and lower case letters and at least one number.");
}

if (!passwordValidator.PasswordLenght() && !passwordValidator.SymbolAndT() && passwordValidator.UpperLowerDigit())
{
    Console.WriteLine("Password is valid.");
}


Console.ReadKey(true);
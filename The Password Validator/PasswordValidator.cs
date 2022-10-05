class PasswordValidator
{
    public string Password { get; private set; } = string.Empty;

    public PasswordValidator(string password) => Password = password;

    public bool PasswordLenght() => Password.Length < 6 || Password.Length > 13;

    public bool SymbolAndT()
    {
        if (Password.Contains('T') || Password.Contains('&'))
        {
            return true;
        }
        return false;
    }

    // Password must contain upper and lower case letters and at least one number
    public bool UpperLowerDigit()
    {
        foreach (char c in Password)
        {
            if (char.IsUpper(c) && char.IsLower(c) || char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
}
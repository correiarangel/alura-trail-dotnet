class UserHelpper
{
    static public User? CreatUser(string name, string email, string password)
    {

        if (!IsValidePassword(password))
        {
            Console.WriteLine("A senha digitada é fraca!");
            return null;
        }

        Console.WriteLine("A senha digitada é forte!");

        return new User(name, email, password);
    }

    static bool IsValidePassword(string password)
    {
        var totalCaracters = password.Length;
        var totalCapitalLetters = password.Count(c => char.IsUpper(c));
        var totalLowercaseLetters = password.Count(c => char.IsLower(c));
        var totalNumbers = password.Count(c => char.IsDigit(c));
        var totalSymbols = password.Count(c => !char.IsLetterOrDigit(c));

        if (totalCaracters > 8 && totalCapitalLetters > 0 && totalLowercaseLetters > 0 && totalNumbers > 0 && totalSymbols > 0)
        {
            return true;
        }
        return false;
    }

    static public void ValidedCreatUser()
    {
        var user = CreatUser("Rangel", "rangel@email.com", "1A4567b890");

        if (user is null)
        {
            Console.WriteLine("Usuario não foi criado");
        }
        else
        {
            Console.WriteLine($"Usuario criado com sucesso: {user.Name} - {user.Email}");
        }

    }
}
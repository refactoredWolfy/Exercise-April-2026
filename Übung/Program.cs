using System;
using System.Text;


public class Programm {


    public static void Main(string[] args)
    {

        string fullName = "Horst Skoff";
        Console.WriteLine($"{{{fullName}}} ---> {GetInitials(fullName)}");
        Console.ReadKey();  


    }

    public static string GetInitials(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName))
        {
            throw new ArgumentException("Name cannot be null or whitespace", nameof(fullName));
        }

        string[] words = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        StringBuilder initials = new StringBuilder();

        foreach (string word in words)
        {
            initials.Append(char.ToUpper(word[0]));
        }

        return initials.ToString();
    }







}



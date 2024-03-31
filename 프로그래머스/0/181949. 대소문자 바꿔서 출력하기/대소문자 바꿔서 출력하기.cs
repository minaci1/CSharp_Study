using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        int a = s.Length;

        var result = new System.Text.StringBuilder(s.Length);

        foreach(char c in s)
        {
            if (char.IsUpper(c))
            {
                result.Append(char.ToLower(c));
                continue;
            }else if(char.IsLower(c))
            {
                result.Append(char.ToUpper(c));
            }

        }

          Console.Write(result.ToString());      
    }
}
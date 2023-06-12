int grades_sum(string str, int res=0)
{
    if (str.Length == 1)
    {
        res += Convert.ToInt32(str[0]) - 48;
        return res;
    }
    else
    {
        res += Convert.ToInt32(str[0]) - 48;
        return grades_sum(str.Substring(1, str.Length - 1), res);
    }
}

string user_input = Console.ReadLine();
Console.WriteLine(grades_sum(user_input));

int my_pow(int n0, int n, int count=1, int res = 1)
{
    if (count == n)
    {
        res *= n0;
        return res;
    }
    else
    {
        res *= n0;
        count++;
        return my_pow(n0, n, count, res);
    }
}

Console.WriteLine(my_pow(3, 5));

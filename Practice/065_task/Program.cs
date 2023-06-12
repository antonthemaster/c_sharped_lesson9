void natural_row(int n0, int n)
{
    if (n0 == n)
    {
        Console.Write(n0);
        return;
    }
    else
    {
        Console.Write(n0 + ", ");
        natural_row(n0 + 1, n);
    }
}

natural_row(1, 5);


string fib(int num, int start = 1){
    if (start == num){
        return num + "";
    }
    return num + ", " + fib(num-1);
}

Console.WriteLine(fib(3));

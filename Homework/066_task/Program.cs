int fib(int end, int start){
    if (start == end){
        return end;
    }
    return start + fib(end, start -1);
}

Console.WriteLine(fib(4, 8));

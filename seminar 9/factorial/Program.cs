//написать реукрсивный метод нахожд факториала

// fact(5) = 120
//Fact(6) = 720

uint Fact(uint number)
{
    if (number == 0 || number == 1)
    return 1;
    return number * Fact(number -1);
}

Console.WriteLine(Fact(5));

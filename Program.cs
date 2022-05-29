    double a;
    double b;
    double total;
    char oper;

    Console.WriteLine("Введите первое число:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите оператор(+,-,*,/,%:");
    oper = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Введите второе число:");
    b = Convert.ToDouble(Console.ReadLine());

    if (oper == '+')
    {
        total = a + b;
        Console.WriteLine(a + " + " + b + " = " + total);
    }

    else if (oper == '-')
    {
        total = a - b;
        Console.WriteLine(a + " - " + b + " = " + total);
    }

    else if (oper == '*')
    {
        total = a * b;
        Console.WriteLine(a + " * " + b + " = " + total);
    }

    else if (oper == '/')
    {
        total = a / b;
        Console.WriteLine(a + " / " + b + " = " + total);
    }

    else if (oper == '%')
    {
    total = a * (b/100);
    Console.WriteLine("Процент от числа " + a + " по числу " + b + " равен " + total + "%");
    }

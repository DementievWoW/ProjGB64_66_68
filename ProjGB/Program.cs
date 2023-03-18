//64
Console.WriteLine("Введите натуральное число больше 1:");
int number = Convert.ToInt16(Console.ReadLine());
void NumberCounter(int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter(number - 1);
}

NumberCounter(number);
////66

//Console.WriteLine("Введите начальное число M:");
//int numberM = Convert.ToInt16(Console.ReadLine());

//Console.WriteLine("Введите начальное число M:");
//int numberN = Convert.ToInt16(Console.ReadLine());

//void NumberSum(int numberM, int numberN, int sum)
//{
//    if (numberM > numberN)
//    {
//        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
//        return;
//    }
//    sum += numberM++;
//    NumberSum(numberM, numberN, sum);
//}

//NumberSum(numberM, numberN, 0);
////68

////int m = InputNumbers("Введите m: ");
////int n = InputNumbers("Введите n: ");

////int functionAkkerman = Ack(m, n);

////Console.Write($"Функция Аккермана = {functionAkkerman} ");

////int Ack(int m, int n)
////{
////    if (m == 0) return n + 1;
////    else if (n == 0) return Ack(m - 1, 1);
////    else return Ack(m - 1, Ack(m, n - 1));
////}

////int InputNumbers(string input)
////{
////    Console.Write(input);
////    int output = Convert.ToInt32(Console.ReadLine());
////    return output;
////}

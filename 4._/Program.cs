/*4. Составить алгоритм, вычисляющий значение функции F(n) = 1!*2!*3!*…*n!, где n! = 
1*2*3*…*n. Можно использовать только один оператор цикла*/

double Factorial(int n)
{
    // 1! = 1;
    // 0! = 1;
    if (n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(6));

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
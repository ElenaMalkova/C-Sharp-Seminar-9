// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetAkkerman (int m, int n) {
    int answer = 0;
    if (m == 0) answer = n + 1;
    if (m > 0 && n == 0) answer = GetAkkerman(m-1, 1);
    if (m > 0 && n > 0) answer = GetAkkerman(m-1, GetAkkerman(m, n-1));
return answer;
}
System.Console.WriteLine(GetAkkerman (1, 1));


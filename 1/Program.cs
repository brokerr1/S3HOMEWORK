/*Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

/*Console.Write("Введите 5-ти значное число: ");
var number = Convert.ToString(Console.ReadLine());
if (number.Length == 5)
{
    if (number.Reverse().SequenceEqual(number))
    {
        Console.WriteLine("Число является палиндром!");
    } 
    else Console.WriteLine("Число не является палиндром!");
}
else Console.WriteLine("Введенно не корректорное число!");*/
Console.Write("Введите 5-ти значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (IsPalindrome(number) == true)
{
    Console.WriteLine("Число является палиндром!");
}
else
{
    Console.WriteLine("Число не является палиндром!");
}
static bool IsPalindrome(int num)
{
    if (num >= 0 && num <10)
                return true;
            int numLength = GetLength(num);
            int[] digits = new int[numLength];
            for (int i = numLength - 1; i >= 0; i--) {
                digits[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < numLength/2; i++) {
                if (digits[i] != digits[numLength - i - 1])
                    return false;
            }
            return true;
        }
        
        static int GetLength(int num)
        {
            int n = 0;
            while (num > 0) {
                num /= 10;
                n++;
            }
            return n;
        }

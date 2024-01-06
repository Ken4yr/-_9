// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

int Input(string msg)
{
   Console.Write(msg + " => ");
   return Convert.ToInt32(Console.ReadLine());
}

int SummNumbers(int firstNumber, int secondNumber)

{
   if (firstNumber > secondNumber)
   {
      return 0; //Возвращаем ноль, если ввести первое число больше второго
   }
   return firstNumber + SummNumbers(firstNumber + 1, secondNumber); //Накапливаем сумму
}

int firstNumber = Input("Введите число M");
int secondNumber = Input("Введите число N");
Console.Write($"Сумма чисел от {firstNumber} до {secondNumber} => {SummNumbers(firstNumber, secondNumber)}");
SummNumbers(firstNumber, secondNumber);
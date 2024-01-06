// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int Input(string msg)
{
   Console.Write(msg + " => ");
   return Convert.ToInt32(Console.ReadLine());
}

int Akerman(int firstNumber, int secondNumber)
{
   if (firstNumber == 0)
   {
      return secondNumber + 1;
   }
   if (firstNumber != 0 && secondNumber == 0)
   {
      return Akerman(firstNumber - 1, 1);
   }
   if (firstNumber > 0 && secondNumber > 0)
   {
      return Akerman(firstNumber - 1, Akerman(firstNumber, secondNumber - 1));
   }
   return Akerman(firstNumber, secondNumber);
}

int firstNumber = Input("Введите число m");
int secondNumber = Input("Введите число n");
Console.WriteLine($"Функция Аккермана для чисел {firstNumber}, {secondNumber} => {Akerman(firstNumber, secondNumber)}");
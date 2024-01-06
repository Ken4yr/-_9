// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Input(string msg)
{
   Console.Write(msg + " => ");
   return Convert.ToInt32(Console.ReadLine());
}

void Number(int firstNumber, int secondNumber)
{
   if(firstNumber > secondNumber) 
   {
      return; //Выход из функции
   }
   
   if(firstNumber % 2 == 0) //Проверка на четность (равен ли остаток  при делении на 2 нулю)
   {
      Console.Write($"{firstNumber}; "," ");
      Number(firstNumber + 2, secondNumber); //Увеличиваем первое число на 2, второе записываем
   }

   else
   {
      Number(firstNumber + 1, secondNumber);//Если пользователь введет нечетные
   }
}
int firstNumber = Input("Введите M");
int secondNumber = Input("Введите N");
Console.WriteLine($"Четные натуральные числа от {firstNumber} до {secondNumber}:");
Number(firstNumber, secondNumber);
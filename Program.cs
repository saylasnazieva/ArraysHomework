 // Задача 1. Необходимо написать программу которая по заданному номеру четверти покажет диапазон вожможных координат точек в этой четверти 
/*
  void ShowRange(int quart)
  {
    if(quart == 1)
       Console.WriteLine("x > 0 and y > 0");
    else if(quart == 2)
       Console.WriteLine("x < 0 and y > 0");
    else if(quart == 3)
      Console.WriteLine("x < 0 and y < 0");
    else if(quart == 4)
       Console.WriteLine("x > 0 and y < 0");
    else 
       Console.WriteLine("Wrong number!");
  }

  Console.Write("Input a number of quart: ");
  int quartNum = Convert.ToInt32(Console.ReadLine());

  ShowRange(quartNum);  
  */

  // Задача 19.Напишите программу,которая принимает на вход пятизначное число и проверяет является ли оно палиндромом.
  //14212->нет
  //12821->да
  //23432
   /*
 Console.WriteLine("Введите число: ");
string =  Console.ReadLine();
int =  number.Length;

if (len == 5)
{
    if (number [0] == number [4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
} 
  */

/*
// Задача 21.Напишите программу , которая на вход координаты двух точек и находит расстояние между ними в 3D прострастве.
// A (3,6,8);B (2,1,-7) -> 15.84
// A (7,-5,0); B (1,-1,9) -> 11.53
 int aX, aY, aZ;
            int bX, bY, bZ;

            Console.WriteLine("Введите посследовательность координат: ");
            Console.Write("aX: ");
            aX = Convert.ToInt32(Console.ReadLine());
            Console.Write("aY: ");
            aY = Convert.ToInt32(Console.ReadLine());
            Console.Write("aZ: ");
            aZ = Convert.ToInt32(Console.ReadLine());

            Console.Write("bX: ");
            bX = Convert.ToInt32(Console.ReadLine());
            Console.Write("bY: ");
            bY = Convert.ToInt32(Console.ReadLine());
            Console.Write("bZ: ");
            bZ = Convert.ToInt32(Console.ReadLine());

            resultDoub = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
            resultDoub = Math.Sqrt(resultDoub);
            resultDoub = Math.Round(resultDoub, 2);
            Console.WriteLine(resultDoub);

            break; 
*/

// Задача 23. Напишите программу, которая на вход число (N) и выдает таблицу кубов от 1 до N.
// 3->1, 8,27
// 5-> ,1,8,27,64,125.int number = ReadInt("Введите число N: ");

/*
for (int i = 1; i <= number; i++)
{ 
 Console.Write($"{i*i*i} ");
}


int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}
*/










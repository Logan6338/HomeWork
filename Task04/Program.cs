﻿Console.WriteLine("Напишите число");
int N = Convert.ToInt32(Console.ReadLine());
   for(int i=2; i<=N; i+=2)
   {
    Console.Write("{0} ", i);
   }
  Console.ReadKey();
  return 0;
   
    int i, n;
                //float a;
                StreamWriter f = new StreamWriter("output.txt", false);
                Console.WriteLine("Сколько чисел будем вводить: ");
                n = int.Parse(Console.ReadLine());
                //f.WriteLine("{0}", n);
                float[] mass = new float[n];
                Console.WriteLine("Введите строку чисел: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write("mass[{0}]: ", i);
                    mass[i] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine("Полученная строка:");
                for (i = 0; i < n; i++) 
                {
                    f.Write("{0}", mass[i]);
                    Console.Write("{0}" + " ", mass[i]);
                }
                f.Close();
               
                StreamReader fIn = new StreamReader("output.txt");
                Console.SetIn(fIn);
                string line = Console.ReadLine();
                string[] mas = line.Split(' ');
                float[] b = new float[mas.Length];
                for (i = 0; i < b.Length; i++)
                {
                    b[i] = float.Parse(mas[i]);
                    Console.Write("\nСчитанный массив: {0}\n" + " ", b[i]);
                }
                    for (i = 0; i < b.Length; i++)
                    {
                       
                           Console.Write("\nПолученный массив: {0}\n" + " ", b[i]);
                       }
                  
                fIn.Close();
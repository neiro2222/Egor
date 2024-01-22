using System;
class step_arrays {
    int[][] Array;
    int n;
    public step_arrays(int N) {
        n = N;
        Array = new int[N][];
        for (int i = 0; i < n; i++) {
            Console.WriteLine($"Введите размер {i + 1} строчки :");
            int m = int.Parse(Console.ReadLine());
            int[] tmp = new int[m];
            Console.WriteLine($"Введите элементы {i + 1} строчки :");
            for (int j = 0; j < m; j++) {
                tmp[j] = int.Parse(Console.ReadLine());;
            }
        }
    }
    public step_arrays() {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        n = rnd.Next(2,10);
        Array = new int[n][];
        for (int i = 0; i < n; i++) {
            int m = rnd.Next(2,10);
            int[] tmp = new int[m];
            for (int j = 0; j < m; j++) {
                tmp[j] = rnd.Next(10);
            }
            Array[i] = tmp;
        }
    }
    public void print() {
        Console.WriteLine("Выводится размеры и элементы ступенчатого массива : ");
        Console.WriteLine($"{n} строчек");
        for (int i = 0; i < n; i++) {
            Console.Write($"размер {i+1} строчки = ");
            Console.Write(Array[i].Length);
            Console.WriteLine();
            int m = Array[i].Length;
            for (int j = 0; j < m; j++) {
                Console.Write($"{Array[i][j]} ");
            }
            Console.WriteLine();
        }
    }
    
    public double average {
        get
        {
            double ans = 0;
            double all_size = 0;
            for (int i = 0; i < n; i++) {
                int m = Array[i].Length;
                all_size += m;
                for (int j = 0; j < m; j++) {
                    ans += Array[i][j];
                }
            }
            return ans / all_size;
        }
    }
    
    public void change_even_el() {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < Array[i].Length; j++) {
                if (Array[i][j] % 2 == 0) {
                    Array[i][j] = i * j;
                }
            }
        }
    }
    
}
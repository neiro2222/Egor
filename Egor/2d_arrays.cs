using System;
class _2d_arrays {
    int n, m;
    int[][] Array;
    
    public _2d_arrays(int N, int M) {
        n = N;
        m = M;
        Array = new int[n][];
        Console.WriteLine("Введите элементы массива :");
        for (int i = 0; i < n; i++) {
            int[] tmp = new int[m];
            for (int j = 0; j < m; j++) {
                tmp[j] = int.Parse(Console.ReadLine());
            }
            Array[i] = tmp;
        }
    }
    public _2d_arrays() {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        n = rnd.Next(2,10);
        m = rnd.Next(2,10);
        Array = new int[n][];
        for (int i = 0; i < n; i++) {
            int[] tmp = new int[m];
            for (int j = 0; j < m; j++) {
                tmp[j] = rnd.Next(10);
            }
            Array[i] = tmp;
        }
    }
    public double average
    {
        get
        {
            double sum = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    sum += Array[i][j];
                }
            }
            return sum / (n + m);
        }
    }    

    public void print_even_strings() {
        Console.WriteLine("элементы четных строк в обратном порядке ");
        for (int i = 0; i < n; i++) {
            if ((i + 1) % 2 == 0) {
                for (int j = m-1; j >= 0; j--) {
                    Console.Write($"{Array[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    public void determinant_of_the_matrix() {
        if (n != m) {
            Console.WriteLine("Это не матрица !");
            return;
        }
        if (n == 2) 
        {
            int ans = Array[0][0] * Array[1][1] - Array[1][0] * Array[0][1];
            Console.WriteLine(ans);
            return;
        }
        int[][] new_matrix = init_new_matrix(n, Array);
        int answer = ans(n, new_matrix);
        Console.WriteLine(answer);
    }
    public static int[][] init_new_matrix(int n, int[][] matrix) {
        int[][] new_matrix = new int[n][];
        for (int i = 0; i < n; i++) {
            int[] tmp = new int[2*n - 1];
            for (int j = 0; j < n; j++) {
                tmp[j] = matrix[i][j];
            }
            for (int j = 0; j < n - 1; j++) {
                tmp[j+n] = matrix[i][j];
            }
            new_matrix[i] = tmp;
        }
        return new_matrix;
    }
    public static int ans(int n, int[][] new_matrix) {
        int answer = 0;
        for (int i = 0; i < n; i++) {
        int line = 1;
        for (int j = 0; j < n; j++) {
            line*= new_matrix[j][i + j];
        }
        answer += line;
        }
        for (int i = 0; i < n; i++) {
            int line = 1;
            for (int j = 0; j < n; j++) {
                line*= new_matrix[n - j - 1][i +  j];
            }
            answer -= line;
        }
        return answer;
    }

    public void print() {
        Console.WriteLine("Выводится размеры и содержимое массива : ");
        Console.Write($"{n} ");
        Console.Write(m);
        Console.WriteLine();
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                Console.Write($"{Array[i][j]} ");
            }
            Console.WriteLine();
        }
    }

}
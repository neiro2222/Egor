using System;
class d1_arrays {
    public int inf = 1000000000;
    private int n;
    int[] a;
    public d1_arrays(int size) {
        n = size;
        a = new int[n];
        Console.WriteLine("Введите элементы массива :");
        for (int i = 0; i < n; i++) {
            a[i] = int.Parse(Console.ReadLine());
        }
    }
    public d1_arrays() {
        Console.WriteLine("Массив вводится случайно");
        Random rnd = new Random();
        n = rnd.Next(1, 20);
        a = new int[n];
        for (int i = 0; i < n; i++) {
            a[i] = rnd.Next(200);
        }
    }
    public void print() {
        Console.WriteLine("Выводится размер и содержимое массива : ");
        Console.WriteLine(n);
        for (int i = 0; i < n; i++) {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine();
    }
    public double average
    {
        get
        {
            double sum = 0;
            for (int i = 0; i < n; i++) {
                sum += a[i];
            }
            return sum / n;
        }
    }
    public void change() {
        int[] tmp = new int[n];
        int s = 0;
        int j = 0;
        for (int i = 0; i < n; i++) {
            if (Math.Abs(a[i]) < 100) {
                s += 1;
                tmp[j] = a[i];
                j++;
            }
        }
        Array.Resize(ref a, s);
        for (int i = 0; i < s; i++) {
            a[i] = tmp[i];
        }
        n = s;
        Console.WriteLine("Удалены элементы по модулю больше 100");
        Console.WriteLine("Новый массив : ");
    }
    public void repeat() {
        Array.Sort(a);
        int pred = inf;
        int[] tmp = new int[n];
        int s = 0;
        for (int i = 0; i < n; i++) {
            if (a[i] != pred) {
                tmp[s] = a[i];
                s += 1;
                pred = a[i];
            }
        }
        Array.Resize(ref a, s);
        for (int i = 0; i < s; i++) {
            a[i] = tmp[i];
        }
        n = s;
        Console.WriteLine("Удалены повторяющиеся элементы ");
        Console.WriteLine("Новый массив : ");
    }
}
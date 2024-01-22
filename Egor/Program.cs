using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите размер массива или введите -1, если хотите заполнить массив случайно : ");
    int n = int.Parse(Console.ReadLine());
    d1_arrays first;
    if (n != -1) {
        first = new d1_arrays(n);
    } else {
        first = new d1_arrays();
    }
    first.print();
    Console.WriteLine($"Среднее {first.average}");
    first.change();
    first.print();
    first.repeat();
    first.print();
    
    Console.WriteLine("Введите размеры двумерного массива или введите -1 -1, если хотите заполнить двумерный массив случайно : ");
    int n_1 = int.Parse(Console.ReadLine());
    int m_1 = int.Parse(Console.ReadLine());
    _2d_arrays second;
    if (n_1 != -1 && m_1 != -1) {
        second = new _2d_arrays(n_1, m_1);
    } else {
        second = new _2d_arrays();
    }
    second.print();
    Console.WriteLine($"Среднее {second.average}");
    second.print_even_strings();
    Console.WriteLine("Определитель матрицы ");
    second.determinant_of_the_matrix();

    Console.WriteLine("Введите количество строчек ступенчатого массива, введите -1, если хотите заполнить ступенчатый массив случайно : ");
    int n_2 = int.Parse(Console.ReadLine());
    step_arrays third;
    if (n_2 != -1) {
        third = new step_arrays(n_2);
    } else {
        third = new step_arrays();
    }
    third.print();
    Console.WriteLine($"Среднее {third.average}");
    third.change_even_el();
    Console.WriteLine("Изменились все четные по значению элементы массива на произведения их индексов :");
    Console.WriteLine("Новая матрица :");
    third.print();
  }
}
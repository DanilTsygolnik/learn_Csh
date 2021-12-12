using System;

class Example2 {
    static void Main() {
        int x,y;
        x = 100;
        y = x / 2;
        
        Console.WriteLine("Variable x contains value: " + x);
        
        // метод также выводит значение аргумента в консоль
        // однако в отличие от WrileLine() переход на новую строку не производится
        Console.Write("Variable y contains value: ");
        
        Console.WriteLine(y);
    }
}

using System;

class SumProd {
    static void Main() {
        int counter, sum, prod;
        sum = 0;
        prod = 1;
        for (counter = 1; counter <= 10; counter++) {
            sum = sum + counter;
            prod = prod * counter;
            if (counter < 10) {
                Console.WriteLine("Current step number: " + counter);
                Console.WriteLine("Current sum: " + sum);
                Console.WriteLine("Current product: " + prod);
            }
            if (counter == 10) {
                Console.WriteLine("Final sum: " + sum);
                Console.WriteLine("Final product: " + prod);
            }
            Console.WriteLine();
        }
    }
}

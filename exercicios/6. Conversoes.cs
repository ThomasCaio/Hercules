namespace Conversoes;

public static class Run {
    public static void Default(double value) {
        System.Console.Clear();
        System.Console.WriteLine($"Valor: {value}");
        System.Console.WriteLine("Selecione um método de conversão: ");
        System.Console.WriteLine("P: Polegadas -> Centímetros");
        System.Console.WriteLine("G: Galão -> Litros");
        System.Console.WriteLine("M: Milhas -> Quilômetros");
        System.Console.Write("Opção: ");
        char option = Console.ReadKey().KeyChar;
        System.Console.WriteLine();
        if (new char[]{'p', 'g', 'm'}.Contains(option)) {
            if (option == 'p') {value = ToCentimeter(value);} 
            else if (option == 'g') {value = ToLiter(value);}
            else if (option == 'm') {value = ToKilometer(value);}
        }
        else {Default(value);}
        System.Console.WriteLine($"{char.ToUpper(option)}: {value}");
    }
    public static double ToCentimeter(double inches) {
        return inches * 2.54;
    }

    public static double ToLiter(double gallons) {
        return gallons * 3.78;
    }

    public static double ToKilometer(double miles) {
        return miles * 1.609;
    }
}
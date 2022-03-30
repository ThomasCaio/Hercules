namespace Heron;

public static class Run {
    public static void Default() {
        System.Console.WriteLine("Lado A: ");
        var ladoA = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Lado B: ");
        var ladoB = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Lado C: ");
        var ladoC = Convert.ToDouble(Console.ReadLine());

        if (
            Math.Abs(ladoB - ladoC) < ladoA && ladoB + ladoC > ladoA &&
            Math.Abs(ladoA - ladoC) < ladoB && ladoA + ladoC > ladoB &&
            Math.Abs(ladoA - ladoB) < ladoC && ladoA + ladoB > ladoC
        ) {
            double P = (ladoA + ladoB + ladoC) / 2;
            double Area = Math.Sqrt(P*(P - ladoA) * (P - ladoB) * (P - ladoC));
            System.Console.WriteLine($"Semiperímetro: {P}");
            System.Console.WriteLine($"Área: {Area}");
        }
        
    }
}
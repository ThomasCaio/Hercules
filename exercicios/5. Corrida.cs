namespace Corrida;

public static class Run {
    public static void Default(int size) {
        double sum = 0;
        for (double i = 0; i <= size; i++) {
            sum += i * Math.Pow(i, i);
        }
        System.Console.WriteLine(sum);
    }
}
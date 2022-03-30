namespace ValorOuRef;

public static class Run{
    public static void Default() {
        int x = 1;
        int y = 1;
        System.Console.WriteLine($"X:{x} antes de somar +1");
        System.Console.WriteLine($"Y:{y} antes de somar +1");
        MaisUm(ref x, y);
        System.Console.WriteLine($"X:{x} somando +1 com parâmetro de referência.");
        System.Console.WriteLine($"Y:{y} somando +1 com parâmetro de valor.");
    }

    public static void MaisUm(ref int x, int y) {
        x += 1;
        y += 1;
    }
}
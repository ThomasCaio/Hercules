namespace Soldados;

public static class Run {
    public static void Default(){
        System.Console.WriteLine($"{"Dec", -6}|{"Hex", -6}|{"Oct", -6}|{"Symb.", -6}");
        int i = 0;
        do {
            System.Console.WriteLine($"{i, -6}|{i.ToString("X"), -6}|{Convert.ToString(i, 8), -6}|{(char)i, -6}");
            i++;
        } while (i < 128);
    }
} 
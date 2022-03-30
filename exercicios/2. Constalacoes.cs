namespace Constelacoes;

public static class Run {
    public static void Default() {
        System.Console.Clear();
        System.Console.WriteLine("Escolha uma constelação: ");
        System.Console.WriteLine("1: Capricórnio");
        System.Console.WriteLine("2: Câncer");
        System.Console.WriteLine("3: Áries");
        System.Console.Write("Opção: ");
        var option = System.Console.ReadKey().KeyChar;
        System.Console.WriteLine();
        if (!(new char[]{'1', '2', '3'}.Contains(option))) {
            Default();
        }
        string[] capricorn = {
            "Capricórnio",
            "*".PadLeft(20),
            "*".PadLeft(19),
            "*  *".PadLeft(10),
            "*  *",
            "   *            *",
            "*".PadLeft(8),
            "*".PadLeft(9),
            "*   *".PadLeft(16),

        };
        string[] cancer = {
            "Câncer",
            "*",
            "",
            "*".PadLeft(6),
            "*".PadLeft(8),
            "",
            "*".PadLeft(14),
            "*".PadLeft(7)

        };
        string[] aries = {
            "Áries",
            "*",
            "*".PadLeft(10),
            "*".PadLeft(15),
            "*".PadLeft(17),
        };
        string[] result = {};
        if (option == '1') {result = capricorn;}
        else if (option == '2') {result = cancer;}
        else if (option == '3'){result = aries;}

        foreach (string s in result){
            System.Console.WriteLine(s);
        }
    }
}
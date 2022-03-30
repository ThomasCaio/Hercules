namespace Oraculo;
using System.Diagnostics;

public static class Run{

    public static void Default(int? key=null) {
        if (key == null){
            System.Console.Write("Key: ");
            key = (int)System.Console.ReadKey().KeyChar;
            System.Console.WriteLine();
        }

        if (key >= 48 && key <= 57) {
            System.Console.WriteLine("Dígito");
        }
        else if (key >= 65 && key <= 90) {
            System.Console.WriteLine("Maiúsculo");
        }
        else if (key >= 97 && key <= 122) {
            System.Console.WriteLine("Minúsculo");
        }
        else {
            System.Console.WriteLine("Símbolo especial");
        }
    }
}
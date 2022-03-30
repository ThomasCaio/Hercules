namespace Acusacoes;


public static class Run{
    public static void Default(int? value1=null,int? value2=null) {
        if (value1 == null && value2 == null){
            Console.Write($"Valor 1: ");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Valor 2: ");
            value2 = Convert.ToInt32(Console.ReadLine());
        }
        int value = Math.Max((int)value1, (int)value2);
        System.Console.WriteLine($"{value} é o maior.");
        if (IsPrime(value)) {
            System.Console.WriteLine($"{value} é primo.");
        }
        else {
            System.Console.WriteLine($"{value} não é primo.");
        }
    }

    public static bool IsPrime(int value) {
        for (int i = 2; i <= value; i++) {
            if (value % i == 0) {
                if (value == i) {
                    return true;
                }
                return false;
            }
        }
        return false;
    }
}
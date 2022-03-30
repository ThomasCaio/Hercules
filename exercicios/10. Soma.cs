namespace Soma;

public static class Run {
    public static void Default() {
        System.Console.Write("Insira um valor: ");
        var input = Console.ReadLine();
        int sum = 0;
        input.ToList().ForEach(c => {
            sum += (int)Char.GetNumericValue(c);
            });
        System.Console.WriteLine($"{string.Join("+",input.ToArray())} = {sum}");
    }
}
namespace Busca;

public static class Run {
    public static void Default() {
        System.Console.WriteLine("Tamanho do array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        List<int> list = new List<int>();
        for (int i = 0; i < size; i++) {
            int v = Convert.ToInt32(System.Console.ReadLine());
            list.Add(v);
        }
        list.Sort();
        System.Console.Write($"[{string.Join(", ", list)}]");
    }
}
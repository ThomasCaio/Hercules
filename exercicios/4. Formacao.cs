namespace Formacao;

public static class Run {
    public static void Default(int size) {
        int[,] matrix = new int[size, size];
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++){
                if (i == j) {
                    matrix[i,j] = 1;
                } else {matrix[i,j] = 0;}
            }
        }
        for (int i = 0; i < size; i++) {
            for (int j = 0; j < size; j++){
                    System.Console.Write(string.Format("{0}\t", matrix[i,j]));
            }
            System.Console.WriteLine();
        }
    }
}
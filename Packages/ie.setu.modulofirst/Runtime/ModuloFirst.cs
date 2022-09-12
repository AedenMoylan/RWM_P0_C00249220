public class ModuloFirst
{
    public static int[] modulo(int[] xs)
    {
        int firstNum = xs[0];
        int[] result = new int[xs.Length];

        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xs[i] % firstNum;
        }

        return result;
    }
}

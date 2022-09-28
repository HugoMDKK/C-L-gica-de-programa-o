namespace Exercício_68_02
{
    class Program
    {
        static void Main(String[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            // Dados de entrada
            for (int i = 0; i < M; i++)
            {
                String[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int fila = int.Parse(Console.ReadLine());
            // Decrementando o valor da fila 
            fila = fila - 1;

            //Ultimo da fila escolhida
            int ultimoDaFila = mat[fila, N - 1];

            //Mover todos a direita, menos o ultimo da fila, em uma contagem descrecente da direita para esquerda
            for (int j = N - 1; j > 0; j--)
            {
                mat[fila, j] = mat[fila, j - 1];
            }

            // Agora armezanando o ultimo na primeira posicao da fila
            mat[fila, 0] = ultimoDaFila;

            //Agora imprimir a matriz alterada:
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

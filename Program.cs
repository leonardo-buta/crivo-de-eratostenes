using System.Collections;

var n = Convert.ToInt32(Console.ReadLine());
var lista = SieveOfEratosthenes(n);

lista.ForEach(x => Console.WriteLine(x));

List<int> SieveOfEratosthenes(int n)
{
    var primos = new List<int>();
    var raiz = (int)Math.Sqrt(n);
    var arrayRemovidos = new BitArray(n + 1);

    for (int i = 2; i <= n; ++i)
    {
        if (!arrayRemovidos[i])
        {
            primos.Add(i);

            if (i <= raiz)
            {
                for (int j = i * i; j <= n; j += i)
                {
                    arrayRemovidos[j] = true;
                }
            }
        }
    }
    return primos;
}

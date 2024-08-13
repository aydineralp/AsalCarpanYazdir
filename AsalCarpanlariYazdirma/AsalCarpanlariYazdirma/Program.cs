namespace AsalCarpanlariYazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            List<int> asalCarpanlar = AsalCarpanlar(sayi);

            if (asalCarpanlar.Count == 0)
            {
                Console.WriteLine("Girilen sayı 1 veya negatif olduğu için asal çarpanı yoktur.");
            }
            else
            {
                Console.WriteLine($"{sayi} sayısının asal çarpanları: {string.Join(", ", asalCarpanlar)}");
            }
        }

        static List<int> AsalCarpanlar(int sayi)
        {
            List<int> carpanlar = new List<int>();

            for (int i = 2; i <= sayi; i++)
            {
                while (sayi % i == 0)
                {
                    carpanlar.Add(i);
                    sayi /= i;
                }
            }

            return carpanlar;
        }
    }
}

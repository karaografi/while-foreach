internal class Program
{
    private static void Main(string[] args)
    {
        //While
        // 1 den başlayarak console dan girilen sayıya kadar (sayı dahil) ortalama hesaplayıp console yazdıran program
        Console.Write("Bir Sayı Giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac ++;
        }

        Console.WriteLine(toplam/sayi);

        // char character = 'a';

        // while (character < 'z')
        // {
        //     Console.Write(character);
        //     character ++;
        // }


        string[] arabalar = {"BMW","FORD","TOYATA","NISSAN"};


        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }


    }
}
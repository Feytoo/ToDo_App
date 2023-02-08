using ToDo_App.enums;
using ToDo_App.datas;

namespace ToDo_App.operations;

public class Operations
{
    public static void display_boards(List<Card> liste)
    {
        Console.WriteLine("ToDo Line");
        Console.WriteLine("************************");
        foreach(var item in liste)
        {
            if (item.status.ToString()== "ToDo")
            {
                Console.WriteLine($"Baslik: {item.Headline}");
                Console.WriteLine($"Icerik: {item.Content}");
                Console.WriteLine($"Atanan Kisi: {item.Member}");
                Console.WriteLine($"Buyukluk: {item.Size}");
                Console.WriteLine("-");
            }
        }
        Console.WriteLine();

        Console.WriteLine("IN Progress Line");
        Console.WriteLine("************************");
        foreach(var item in liste)
        {
            if (item.status.ToString()== "InProgress")
            {
                Console.WriteLine($"Baslik: {item.Headline}");
                Console.WriteLine($"Icerik: {item.Content}");
                Console.WriteLine($"Atanan Kisi: {item.Member}");
                Console.WriteLine($"Buyukluk: {item.Size}");
                Console.WriteLine("-");
            }
        }
        Console.WriteLine();

        Console.WriteLine("Done Line");
        Console.WriteLine("************************");
        foreach(var item in liste)
        {
            if (item.status.ToString()== "Done")
            {
                Console.WriteLine($"Baslik: {item.Headline}");
                Console.WriteLine($"Icerik: {item.Content}");
                Console.WriteLine($"Atanan Kisi: {item.Member}");
                Console.WriteLine($"Buyukluk: {item.Size}");
                Console.WriteLine("-");
            }
        }
    }

    public static void add_toboard(List<Card> cards, List<Member> users)
    {
        Card newCard = new Card();
        Console.WriteLine("Baslik Giriniz: ");
        string header = Console.ReadLine();
        Console.WriteLine("Icerik Giriniz: ");
        string cont = Console.ReadLine();
        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5): ");
        int sizer = Convert.ToInt32(Console.ReadLine());
        Sizes size = SizeSecme(sizer);
        Console.WriteLine("Kişi Seçiniz: ");
        string name = Console.ReadLine();

       
        
        newCard.Headline = header;
        newCard.Content = cont;
        newCard.Member = name;
        newCard.Size = size;
        newCard.status = Status.ToDo;
        cards.Add(newCard);
    }

    public static Sizes SizeSecme(int num)
        {
            Sizes sum = (Sizes)1;
            switch (num)
            {
                case 1:
                    sum = (Sizes)1;
                    break;
                case 2:
                    sum = (Sizes)2;
                    break;
                case 3:
                    sum = (Sizes)3;
                    break;
                case 4:
                    sum = (Sizes)4;
                    break;
                case 5:
                    sum = (Sizes)5;
                    break;
            }
            return sum;
        }
    
    public static void delete_fromboard(List<Card> cards)
    {
        Console.WriteLine("Oncelikle Silmek Istediginiz Karti Secmeniz Gerekiyor.");
        Console.Write("Lutfen Kart Basligini Yaziniz: ");
        string baslik = Console.ReadLine();
        int count = 0;
        foreach (var item in cards.ToList())
        {
            if (item.Headline == baslik)
            {
                cards.Remove(item);
                count++;
                break;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Aradiğiniz krtiterlere uygun kart board'da bulunamadi. Lütfen bir seçim yapiniz.");
            Console.WriteLine("Silmeyi sonlandirmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
                return;
            else
                delete_fromboard(cards);
        }
    }

    public static void remove_fromboard(List<Card> cards)
    {
        Console.WriteLine("Oncelikle Silmek Istediginiz Karti Secmeniz Gerekiyor.");
        Console.Write("Lutfen Kart Basligini Yaziniz: ");
        string baslik = Console.ReadLine();
        int count = 0;
        foreach (var item in cards.ToList())
        {
            if(item.Headline == baslik)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine($"Baslik: {item.Headline}");
                Console.WriteLine($"Icerik: {item.Content}");
                Console.WriteLine($"Atanan Kisi: {item.Member}");
                Console.WriteLine($"Buyukluk: {item.Size}");
                Console.WriteLine($"Line: {item.status}");
                Console.WriteLine();
                Console.WriteLine("Lutfen tasimak istediginiz Line'i seciniz.");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int choise = Convert.ToInt32(Console.ReadLine());
                switch(choise)
                {
                    case 1:
                    {
                        item.status = Status.ToDo;
                        break;
                    }
                    case 2:
                    {
                        item.status = Status.InProgress;
                        break
                    }
                    case 3:
                    {
                        item.status = Status.Done;
                        break;
                    }
                }
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Aradiğiniz krtiterlere uygun kart board'da bulunamadi. Lütfen bir seçim yapiniz.");
            Console.WriteLine("Silmeyi sonlandirmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
                return;
            else
                remove_fromboard(cards);
        }
    }
}
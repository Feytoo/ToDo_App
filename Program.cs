using ToDo_App.enums;
using ToDo_App.datas;
using ToDo_App.operations;
namespace ToDo_App;
class Program
{
    static void Main(string[] args)
    {
        List<Member> users = new List<Member>();
        List<Card> cards = new List<Card>();
        Database database = new Database();
        database.Data(users, cards);
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Board Listelemek");
        Console.WriteLine("(2) Board'a Kart Eklemek");
        Console.WriteLine("(3) Board'dan Kart Silmek");
        Console.WriteLine("(4) Kart Tasimak");
        Console.WriteLine("(9) Cikis Yap");
        int karar = int.Parse(Console.ReadLine());
        bool control = true;
        while (control)
        {
            switch (karar)
            {
                case 1:
                {
                    Operations.display_boards(cards);
                    break;
                }
                case 2:
                {
                    Operations.add_toboard(cards, users);
                    break;
                }
                case 3:
                {
                    Operations.delete_fromboard(cards);
                    break;
                }
                case 4:
                {
                    Operations.remove_fromboard(cards);
                    break;
                }
                case 9:
                {
                    control = false;
                    break;
                }
            }
            if (control)
            {
                Console.Write("Yapmak Istediginiz Yeni Islemi Seciniz: ");
                karar = int.Parse(Console.ReadLine());
                Console.WriteLine("**********************");
            }
        }
    }
}

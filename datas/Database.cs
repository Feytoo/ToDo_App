namespace ToDo_App.datas;

public class Database
{
    public void Data(List<Member> members, List<Card> cards)
    {
        Member member1 = new Member();
        member1.Name = "Fatih";
        member1.Id = 1;
        members.Add(member1);

        Member member2 = new Member();
        member2.Name = "Kismet";
        member2.Id = 2;
        members.Add(member2);

        Member member3 = new Member();
        member3.Name = "Selahattin";
        member3.Id = 3;
        members.Add(member3);

        Card card1 = new Card();
        card1.Headline = "Fizyoterapist";
        card1.Content = "Masaj";
        card1.Member = member1.Name;
        card1.Size = enums.Sizes.M;
        card1.status = enums.Status.InProgress;
        cards.Add(card1);

        Card card2 = new Card();
        card2.Headline = "Kondisyoner";
        card2.Content = "Kosu";
        card2.Member = member2.Name;
        card2.Size = enums.Sizes.L;
        card2.status = enums.Status.ToDo;
        cards.Add(card2);

        Card card3 = new Card();
        card3.Headline = "Antrenor";
        card3.Content = "Toplanti";
        card3.Member = member3.Name;
        card3.Size = enums.Sizes.XL;
        card3.status = enums.Status.ToDo;
        cards.Add(card3);
    }
}
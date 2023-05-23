using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace BootcampDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t CLUB LOGIC\n");
            Club footballClub1 = new Club();
            Club footballClub2 = new Club();
            footballClub1.Name = "Real Madrid";
            Console.WriteLine("Enter club name: ");
            footballClub2.Name = Console.ReadLine();
            FootballPlayer footballPlayer1 = new FootballPlayer("Ronaldo", footballClub1);
            string footballPlayer2Name = "Messi";
            FootballPlayer footballPlayer2 = new FootballPlayer(footballPlayer2Name, footballClub2);
            

            Console.WriteLine(footballPlayer1.FirstName + " igra " + footballPlayer1.GetPlayerSport(footballPlayer1));

            Console.ReadLine();
            // U gornjem dijelu sam instancirao dva kluba, gdje sam im postavljao parametar ime na dva razlicita nacina,
            // rucno i kroz konzolu, instancirao sam dva nogometasa i primjenio metodu dohvacanja sporta koji igraju
            // sportovi su postavljeni kroz konstruktor

            Console.WriteLine("\t SPORT LOGIC\n");
            Club club3 = new Club();
            club3.Country = "England";
            club3.Name = "Chelsea";
            BasketballPlayer basketballPlayer = new BasketballPlayer("Giannis", club3);
            FootballPlayer footballPlayer3 = new FootballPlayer("Ibrahimovic", club3);
            Console.WriteLine
                ($"{basketballPlayer.FirstName} igra {basketballPlayer.GetPlayerSport(basketballPlayer)} za {club3.Name} ");
            Console.WriteLine
                ($"{footballPlayer3.FirstName} igra {footballPlayer3.GetPlayerSport(footballPlayer3)} za {club3.Name} ");

            Console.ReadLine();
            //U gornjem dijelu sam instancirao jedan klub, rucno postavio neke od svojstava te na primjeru ispisivanja u konzolu
            //Pokazao da overrideana metoda GetPlayerSport dohvaca razlicit sport za razlicite objekte iako igraju u istoimenom klubu

            Console.WriteLine("\t LIST LOGIC\n");
            List<Club> clubs = new List<Club>();
            string endKey = "f";
            do
            {
                Club club = new Club();
                Console.WriteLine("Unesite ime kluba: ");
                club.Name = Console.ReadLine();
                clubs.Add(club);

                Console.WriteLine("Press 'f' to stop or any key to continue");
                endKey = Console.ReadLine();
            }
            while (endKey != "f");

            Console.WriteLine("Vasa liga se sastoji od sljedecih klubova: ");
            foreach(Club club in clubs)
            {
                Console.WriteLine(club.Name);
            }
        }

    }
}

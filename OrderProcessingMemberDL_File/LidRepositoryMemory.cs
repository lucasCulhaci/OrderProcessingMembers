using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Models;
using OrderProcessingMembersBL.Models.Status;

namespace OrderProcessingMemberDL_File
{
    public class LidRepositoryMemory : ILidRepositoryMemory
    {

        private Dictionary<int, Member> leden;
        private int lidID = 1;

        public LidRepositoryMemory()
        {

            leden = new();

            // This is mock data, only used to simulate the application
            var adres = new Adres("x", "x", "x", "x", "x");

            leden.Add(lidID, new Member(lidID, "Gebruiker1", "mail1@outlook.com", adres, new StandardStatus()));
            lidID++;

            leden.Add(lidID, new Member(lidID, "Gebruiker2", "mail2@outlook.com", adres, new BronzeStatus()));
            lidID++;

            leden.Add(lidID, new Member(lidID, "Gebruiker3", "mail3@outlook.com", adres, new SilverStatus()));
            lidID++;

            leden.Add(lidID, new Member(lidID, "Gebruiker4", "mail4@outlook.com", adres, new GoldStatus()));
            lidID++;
        }

        public List<Member> GeefLeden()
        {
            return leden.Values.ToList();
        }

    }
}

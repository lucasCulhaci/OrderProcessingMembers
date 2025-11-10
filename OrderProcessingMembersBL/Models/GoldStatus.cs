using BL.Interfaces;
using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models
{
    public class GoldStatus : ILevering,  IPrijs, IWelkomstpakket, INaamplaat, IAvondmaal, IAfhaalservice
    {

        public Levering TypeLevering()
        {
            return Levering.Express;
        }

        public decimal BerekenKost(decimal kost)
        {
            return kost * 3;
        }

        public string Welkomstpakket()
        {
            return "Welkomstpakket!";
        }

        public string Naamplaat(string naam)
        {
            return "Naamplaat: " + naam;
        }

        public string Avondmaal()
        {
            return "Avondmaal!";
        }

        public string Afhaalservice()
        {
            return "Afhaalservice!";
        }
    }
}

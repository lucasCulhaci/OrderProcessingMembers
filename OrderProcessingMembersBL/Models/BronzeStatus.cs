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
    public class BronzeStatus : ILevering, IPrijs, INaamplaat, IAvondmaal
    {

        public Levering TypeLevering()
        {
            return Levering.Standard;
        }

        public decimal BerekenKost(decimal kost)
        {
            return kost + 100;
        }

        public string Naamplaat(string naam)
        {
            return "Naamplaat: " + naam;
        }

        public string Avondmaal()
        {
            return "Avondmaal!";
        }

    }
}

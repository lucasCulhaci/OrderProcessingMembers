using BL.Interfaces;
using OrderProcessingMembersBL.Enums;
using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models.Status
{
    // IStatus is used to group every type of status, the Interface itself doesn't contain any logic
    public class SilverStatus : IStatus, ILevering, IPrijs, IWelkomstpakket, INaamplaat, IAvondmaal
    {

        public Levering TypeLevering()
        {
            return Levering.Express;
        }

        public decimal BerekenKost(decimal kost)
        {
            return kost * 2;
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
    }
}

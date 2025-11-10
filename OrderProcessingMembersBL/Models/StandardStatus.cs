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
    public class StandardStatus : ILevering, IPrijs
    {
        public decimal BerekenKost(decimal kost)
        {
            return kost;
        }

        public Levering TypeLevering()
        {
            return Levering.Standard;
        }
    }
}

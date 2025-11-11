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
    public class StandardStatus
    {
        public virtual decimal BerekenKost(decimal kost)
        {
            return kost;
        }

        public virtual Levering TypeLevering()
        {
            return Levering.Standard;
        }
    }
}

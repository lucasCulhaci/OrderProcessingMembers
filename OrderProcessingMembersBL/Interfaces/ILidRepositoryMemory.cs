using OrderProcessingMembersBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Interfaces
{
    public interface ILidRepositoryMemory
    {
        public List<Member> GeefLeden();
    }
}

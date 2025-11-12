using OrderProcessingMembersBL.Interfaces;
using OrderProcessingMembersBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Manager
{
    public class OrderProcessingMembersBeheerder
    {
        private ILidRepositoryMemory _repo;
        public OrderProcessingMembersBeheerder(ILidRepositoryMemory repo)
        {
            _repo = repo;
        }

        public List<Member> GeefLeden()
        {
            return _repo.GeefLeden();
        }
    }
}

using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingMembersBL.Models
{
    public class Lid(int ID, string Naam, string Email, Adres Adres, IStatus Status)
    {


        public override string ToString()
        {
            return $"ID: {ID}, Naam: {Naam}, Email: {Email},\n Adres: {Adres},\n Status: {Status}";
        }

    }
}

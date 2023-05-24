using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Cybergame_managers.Interface
{
    public interface ICustomer
    {
        IList<Customer> getAll();
        Customer getByID(int customerID);
        int UpdateMoney(Customer customer);
        int Insert(Customer customer);
        int checkMember_ID(int customerID);
        int Delete(int customerID);
        IList<Customer> SearchLinq(Customer mb);

    }
}

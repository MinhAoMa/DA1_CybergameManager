using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Cybergame_managers
{
    public class Order
    {
        public int idOrder;
        public DateTime timeCre;
        public int idEmployee;
        public int idCustomer;
        public decimal money;
        public string payment;

        public Order() { }

        public Order(int idOrder, DateTime timeCre, int idEmployee, int idCustomer, decimal money, string payment)
        {
            this.idOrder = idOrder;
            this.timeCre = timeCre;
            this.idEmployee = idEmployee;
            this.idCustomer = idCustomer;
            this.money = money;
            this.payment = payment;
        }
        public int IDOrder
        {
            get { return idOrder; }
            set { idOrder = value; }
        }
        public DateTime TimeCre
        {
            get { return timeCre; }
            set { timeCre = value; }
        }
        public int IDEmployee
        {
            get { return idEmployee; }
            set
            {
                idEmployee = value;
            }
        }
        public decimal Money
        {
            get { return money; }
            set
            {
                money = value;
            }
        }
        public string Payment
        {
            get { return payment; }
            set
            {
                payment = value;
            }
        }
        public int IDCustomer
        {
            get { return idCustomer; }
            set
            {
                idCustomer = value;
            }
        }

    }
}

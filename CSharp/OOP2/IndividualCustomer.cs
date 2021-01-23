using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Gerçek veya bireysel müşteri
    class IndividualCustomer : Customer //Müşteride olan tüm özellikler Burada da geçerli olur.
    {

        public string TcNo { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}

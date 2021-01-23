using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri
    class CorporateCustomer : Customer //Miras veya inheratance denilir.
    {//Tüzel müşteri bir müşteridir demek.

        public string CompanyName { get; set; }
        public string VergiNo { get; set; }
    }
}

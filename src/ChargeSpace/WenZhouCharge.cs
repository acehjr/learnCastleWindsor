using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iInterface;
namespace ChargeSpace
{
    //默认情况下，它会按照字母先后顺序选择注入哪个class
    //public class VenZhouCharge : ICharge
    //{
    //    public IPrinter printer { set; get; }

    //    public void ClinicChcarge()
    //    {
    //        Console.WriteLine("XenZhou门诊收费2");
    //        printer.ClinicPrint(2);
    //    }
    //}
    public class WenZhouCharge : ICharge
    {
        //不用引入PrintSpace就能pint了
        public IPrinter printer { set; get; }

        public void ClinicChcarge()
        {
            Console.WriteLine("温州门诊收费");
            printer.ClinicPrint(100000);
        }
    }

   
}

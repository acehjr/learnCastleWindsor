using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iInterface;
namespace PrintSpace
{
    public class WenZhouPrinter : IPrinter
    {
        public void RegPrint(int regID)
        {
            Console.WriteLine("温州挂号打印 " + regID.ToString());
        }
        public void ClinicPrint(int chargeID)
        {
            Console.WriteLine("温州门诊打印 " + chargeID.ToString());
        }
    } 
}

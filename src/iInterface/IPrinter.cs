using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iInterface
{
    public interface IPrinter
    {
        void RegPrint(int regID);
        void ClinicPrint(int chargeID);
    }  
}

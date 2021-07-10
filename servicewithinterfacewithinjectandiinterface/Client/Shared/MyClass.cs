using servicewithinterfacewithinjectandiinterface.Client.Resounces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicewithinterfacewithinjectandiinterface.Client.Shared
{
    public class MyClass : MyInterFace

    {
        public List<Data> GetData()
        {
            return new List<Data>()
            {
                new Data(){Id=101, Name="Yatendra", Address="Noida"}
            };
        }
    }
}

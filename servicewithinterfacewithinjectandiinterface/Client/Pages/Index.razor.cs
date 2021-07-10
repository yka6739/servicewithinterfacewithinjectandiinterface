using servicewithinterfacewithinjectandiinterface.Client.Resounces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicewithinterfacewithinjectandiinterface.Client.Pages
{
    public partial class Index
    {
        private List<Data> d;
        protected override void OnInitialized()
        {
            d = ccc.GetData();
        }

    }
}

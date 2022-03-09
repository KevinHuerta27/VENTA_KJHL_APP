using System;
using System.Collections.Generic;
using System.Text;
using VENTA_KJHL_APP.ViewModels;

namespace VENTA_KJHL_APP.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}

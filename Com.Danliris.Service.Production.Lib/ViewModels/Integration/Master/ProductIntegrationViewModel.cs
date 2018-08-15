﻿using Com.Danliris.Service.Production.Lib.Utilities.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Finishing.Printing.Lib.ViewModels.Integration.Master
{
    public class ProductIntegrationViewModel : BaseViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public dynamic Price { get; set; }
    }
}

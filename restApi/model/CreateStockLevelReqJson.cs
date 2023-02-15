﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restApi.model
{
    internal class CreateStockLevelReqJson
    {
        public string dataSourceCode { get; set; }
        public string manufacturerCode { get; set; }
        public DateTime stockDate { get; set; }
        public string productCode { get; set; }
        public double itemQuantity { get; set; }
        public int quantityInPackage { get; set; }
        public double packageQuantity { get; set; }
        public string itemBarcode { get; set; }
        public string packageBarcode { get; set; }
        public double listPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregorioRheginald_SuperKiwiStore
{

    /* ID: 1815101
     Author: Rheginald Gregorio 
    Description:  The Inventory Class focuses on inventory details of an item found on the inventory list text file .*/
    class Inventory
    {
        public string Name { get; set; }
        public string ItemCode { get; set; }
        public string Quantity { get; set; }
        public string Weight { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }

        public override string ToString()
        {
            return ItemCode;
        }
    }
}

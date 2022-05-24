using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year3_collaborative_project.classes
{
    class clsCustomerConfig
    {
        //Create member Variables
        private int _iColourId;
        private String _sColourName;
        private Decimal _dColourPrice;

        private int _iModID;
        private string _sModName;
        private decimal _dModPrice;
        private decimal _dTotalModPrice;


        //Create Get/Set for member variables
        public int iColourId { get => _iColourId; set => _iColourId = value; }
        public string sColourName { get => _sColourName; set => _sColourName = value; }
        public decimal dColourPrice { get => _dColourPrice; set => _dColourPrice = value; }

        public int iModID { get => _iModID; set => _iModID = value; }
        public string sModName { get => _sModName; set => _sModName = value; }
        public decimal dModPrice { get => _dModPrice; set => _dModPrice = value; }
        public decimal dTotalModPrice { get => _dTotalModPrice; set => _dTotalModPrice = value; }
    }
}

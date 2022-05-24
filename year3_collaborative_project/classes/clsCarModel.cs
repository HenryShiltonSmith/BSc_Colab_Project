using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year3_collaborative_project.classes
{
    class clsCarModel
    
        {
            //Create member Variables
        private int _iModelId;
        private int _iMakeId;
        private String _sModelName;
        private Decimal _dModelPrice;
        private int _iEngineSize;
        private int _iDoors;
        private string _sFuel;
        private string _sTransmission;
        private double _iMPG;
        private string _sDriveType;
        private double _dEmissions;
        private int _iYear;

        //Create Get/Set for member variables
        public int iModelId { get => _iModelId; set => _iModelId = value; }
        public int iMakeId { get => _iMakeId; set => _iMakeId = value; }
        public string sModelName { get => _sModelName; set => _sModelName = value; }
        public decimal dModelPrice { get => _dModelPrice; set => _dModelPrice = value; }
        public int iEngineSize { get => _iEngineSize; set => _iEngineSize = value; }
        public int iDoors { get => _iDoors; set => _iDoors = value; }

        public string sFuel { get => _sFuel; set => _sFuel = value; }
        public string sTransmission { get => _sTransmission; set => _sTransmission = value; }
        public double iMPG { get => _iMPG; set => _iMPG = value; }
        public string sDriveType { get => _sDriveType; set => _sDriveType = value; }
        public double dEmissions { get => _dEmissions; set => _dEmissions = value; }
        public int iYear { get => _iYear; set => _iYear = value; }


    }

}

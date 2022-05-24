using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year3_collaborative_project.classes
{
    class clsCarMake
    {
        //Create member Variables
        private int _iMakeId;
        private string _sMakeName;
        private string _sAddNewMake;
        private int _iInsertMakeID;

        //Create Get/Set for member variables

        public int iMakeId { get => _iMakeId; set => _iMakeId = value; }
        public string sMakeName { get => _sMakeName; set => _sMakeName = value; }
        public string sAddNewMake { get => _sAddNewMake; set => _sAddNewMake = value; }
        public int iInsertMakeID { get => _iInsertMakeID; set => _iInsertMakeID = value; }

    }
}

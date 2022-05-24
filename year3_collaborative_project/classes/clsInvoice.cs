using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year3_collaborative_project.classes
{
    class clsInvoice
    {
        public void invoice_creation(int iModelID, int iAPRID, int iColourID, List<int> ilSelectedMods, List<decimal> ilSelectModPrice)
        {
            clsDatabase_Vehicles clsVehicles = new clsDatabase_Vehicles();
            clsDatabase_Modifications clsMods = new clsDatabase_Modifications();
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();
            clsDatabase_Invoicing clsInvoicing = new clsDatabase_Invoicing();

            int iCustomerID = clsUser.IUserID;

            decimal dTotalPrice = (Convert.ToDecimal(ilSelectModPrice.Sum()) + clsVehicles.GetModelPrice(iModelID) + clsMods.GetColourPrice(iColourID)) * (clsConfigs.GetAPRPercent(iAPRID) / 100);
            
            string sSelectedMods = string.Join(",", ilSelectedMods);
            string sSelectedModsPrice = string.Join(",", ilSelectModPrice);

            clsInvoicing.AddInvoice(iCustomerID, iModelID, iAPRID, iColourID, sSelectedMods, sSelectedModsPrice, dTotalPrice);
        }

        public void ConfigurationSave(int iModelID,int iMakeID, int iAPRID, int iColourID, List<int> ilSelectedMods, List<int> ilSelectModPrice)
        {
            clsDatabase_Configs clsConfigs = new clsDatabase_Configs();

            int iCustomerID = clsUser.IUserID;
            int iTotalPrice = Convert.ToInt32(ilSelectModPrice.Sum());
            string sSelectedMods = string.Join(",", ilSelectedMods);
            string sSelectedModsPrice = string.Join(",", ilSelectModPrice);

            clsConfigs.SaveConfiguration(iCustomerID,iMakeID, iModelID, iAPRID, iColourID, sSelectedMods, sSelectedModsPrice, iTotalPrice);
        }
    }
}

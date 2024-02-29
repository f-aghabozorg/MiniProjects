using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal interface IWareHouseDB
    {

        DataTable SelectAll();
        DataTable Search(string parameter);
        DataTable SelectRow(string DCHR_INVID, string DCHR_PRID, string DCHR_RCID, string DCHR_DATE_TIME);
        bool Insert(string DCHR_INVID, string DCHR_PRID, string DCHR_RCID, string DCHR_DCHRNUM, string DCHR_DATE_TIME);
        bool Update(string DCHR_INVID, string DCHR_PRID, string DCHR_RCID, string DCHR_DCHRNUM, string DCHR_DATE_TIME);
        bool Delete(string DCHR_INVID, string DCHR_PRID, string DCHR_RCID, string DCHR_DATE_TIME);

    }
}

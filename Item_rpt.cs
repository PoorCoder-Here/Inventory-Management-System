using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_Client_V1.masterDataSet7TableAdapters
{
	public partial class Item_TransacTableAdapter : global::System.ComponentModel.Component
	{
		public void SetSQL(string theSQL)
		{
			this.CommandCollection[0].CommandText = theSQL;

		}
	}
}

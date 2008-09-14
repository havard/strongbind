using System;
using System.Collections.Generic;
using System.Text;

namespace OX.DataBinding.TestApp
{
    public interface IBusinessObject
    {
        string Name
        {
            get;
        }
    }

    public class BusinessObject : IBusinessObject
    {
        #region IBusinessObject Members

        public string Name
        {
            get { return "It's me!"; }
        }

        public void DoStuff()
        {
        }

        #endregion
    }
}

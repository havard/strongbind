using System;
using System.Collections.Generic;
using System.Text;

namespace OX.DataBinding
{
    public class BindingPair
    {
        private object source;
        private string member;

        public object Object
        {
            get { return source; }
        }

        public string Member
        {
            get { return member; }
        }

        public BindingPair(object source, string member)
        {
            this.source = source;
            this.member = member;
        }
    }
}

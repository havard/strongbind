using System;

namespace OX.Strongbind
{
    public static class BindingPairHolder
    {
        private static object syncroot = new object();
        private static BindingPair sourcePair;

        internal static BindingPair ConsumeBindingPair()
        {
            BindingPair toReturn = null;
            lock (syncroot)
            {
                toReturn = sourcePair;
                sourcePair = null;
            }
            return toReturn;
        }

        public static void DeclareBindingPair(object source, string member)
        {
            // Can't validate like this due to constructs like events etc. that will execute beyond our control
            //if(sourcePair != null)
            //    throw new InvalidOperationException(string.Format("Previous incomplete binding from {0}.{1} exists.", sourcePair.Object.GetType().Name, sourcePair.Member));

            lock (syncroot)
            {
                sourcePair = new BindingPair(source, member);
            }
        }
    }
}

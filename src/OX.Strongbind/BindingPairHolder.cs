using System;

namespace OX.Strongbind
{
    public static class BindingPairHolder
    {
        [ThreadStatic]
        private static BindingPair sourcePair;
        [ThreadStatic]
        private static bool shouldConsume;

        internal static BindingPair ConsumeBindingPair()
        {
            return sourcePair;
        }

        public static void DeclareBindingPair(object source, string member)
        {
            if (!shouldConsume)
                return;

            // Can't validate like this due to constructs like events etc. that will execute beyond our control
            //if(sourcePair != null)
            //    throw new InvalidOperationException(string.Format("Previous incomplete binding from {0}.{1} exists.", sourcePair.Object.GetType().Name, sourcePair.Member));

            sourcePair = new BindingPair(source, member);
        }

        internal static void EnableBindingDeclaration()
        {
            shouldConsume = true;
        }

        internal static void DisableBindingDeclaration()
        {
            shouldConsume = false;
        }
    }
}

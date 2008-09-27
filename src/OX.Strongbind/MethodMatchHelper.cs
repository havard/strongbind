namespace OX.Strongbind
{
    using System.Reflection;

    internal static class MethodMatchHelper
    {
        public static bool IsGetter(MethodBase method)
        {
            return method.IsSpecialName && method.Name.StartsWith("get_");
        }

        public static string PropertyNameFromGetter(MethodBase method)
        {
            return method.Name.Substring(4);
        }
    }
}

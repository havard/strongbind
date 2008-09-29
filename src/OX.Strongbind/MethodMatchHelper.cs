namespace OX.Strongbind
{
    using System.Reflection;

    /// <summary>
    /// Helper methods for matching proxied method calls.
    /// </summary>
    internal static class MethodMatchHelper
    {
        /// <summary>
        /// Tells if a method is a get method for a property.
        /// </summary>
        /// <param name="method">The method to check.</param>
        /// <returns><value>true</value> if the method is a get method for a property, <value>false</value> otherwise.</returns>
        public static bool IsGetter(MethodBase method)
        {
            return method.IsSpecialName && method.Name.StartsWith("get_");
        }

        /// <summary>
        /// Gets the property name from a get method for a property.
        /// </summary>
        /// <param name="method">The property get method to get the property name from.</param>
        /// <returns>The name of the property.</returns>
        public static string PropertyNameFromGetter(MethodBase method)
        {
            return method.Name.Substring(4);
        }
    }
}

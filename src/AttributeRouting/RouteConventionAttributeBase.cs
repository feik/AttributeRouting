using System;
using System.Collections.Generic;
using System.Reflection;

namespace AttributeRouting
{
    /// <summary>
    /// Base class that implementors can use to define a custom controller-level route convention.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public abstract class RouteConventionAttributeBase : Attribute
    {
        /// <summary>
        /// Gets the RouteAttributes to be applied to the given action method.
        /// </summary>
        /// <param name="actionMethod"></param>
        /// <returns></returns>
        public abstract IEnumerable<IRouteAttribute> GetRouteAttributes(MethodInfo actionMethod);

        /// <summary>
        /// Gets the default route prefix to use if no RoutePrefix is applied on the controller.
        /// </summary>
        /// <param name="actionMethod"></param>
        /// <returns></returns>
        public virtual string GetDefaultRoutePrefix(MethodInfo actionMethod)
        {
            return "";
        }
    }
}
﻿using System.Diagnostics.CodeAnalysis;

namespace System.Web.Http.ModelBinding
{
    [AttributeUsage(ValidTargets, AllowMultiple = false, Inherited = false)]
    public abstract class CustomModelBinderAttribute : Attribute
    {
        internal const AttributeTargets ValidTargets = AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Struct;

        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "This method can potentially perform a non-trivial amount of work.")]
        public abstract IModelBinder GetBinder();
    }
}
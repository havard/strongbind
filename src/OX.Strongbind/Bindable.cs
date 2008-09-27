using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Windows.Forms;
using Castle.Core.Interceptor;
using Castle.DynamicProxy;
using OX.Strongbind.Remoting;
using OX.Strongbind.Dynamic;

namespace OX.Strongbind
{   
    public static class Bindable
    {
        private static AssemblyBuilder assemblyBuilder;
        private static ModuleBuilder moduleBuilder;

        static Bindable()
        {
            AssemblyName assemblyName = new AssemblyName();
            assemblyName.Name = "DynamicDataBindingTypes";

            assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.RunAndSave);
            moduleBuilder = assemblyBuilder.DefineDynamicModule("DynamicDataBindingTypes");
        }

        public static T Source<T>(T instance)
        {
            return CreateProxy(instance);
        }
        
        public static T Target<T>(T instance) where T : System.Windows.Forms.IBindableComponent, new()
        {
            instance.DataBindings.Clear();
            return CreateProxy(instance);
        }

        private static T CreateProxy<T>(T instance)
        {
            if (instance is MarshalByRefObject)
                return RemotingProxy.For(instance);
            else
                return DynamicProxy.For(instance);
        }

        #region Original proxy generator

        //private static T CreateProxy<T>(T instance)
        //{
        //    Type typeToBind = typeof(T);

        //    Type existingDynamicType = assemblyBuilder.GetType(typeToBind.Name + "Binder");

        //    if (existingDynamicType != null)
        //    {
        //        T t = (T)Activator.CreateInstance(existingDynamicType, instance);
        //        return t;
        //    }

        //    if(!typeToBind.IsPublic)
        //        throw new ArgumentException(string.Format("Cannot use {0} as a binding source since it is not a public type.", typeToBind.Name));
        //    if (typeToBind.IsSealed)
        //        throw new ArgumentException(string.Format("Cannot use {0} as a binding source since it is a sealed class.", typeToBind.Name));
        //    if (typeToBind.ContainsGenericParameters)
        //        throw new ArgumentException(string.Format("Cannot use {0} as a binding source since it contains generic parameters.", typeToBind.Name));

        //    TypeAttributes typeFlags = TypeAttributes.Public | TypeAttributes.Class | TypeAttributes.BeforeFieldInit | TypeAttributes.AutoClass;
        //    TypeBuilder typeBuilder;
        //    if (typeToBind.IsInterface)
        //        typeBuilder = moduleBuilder.DefineType(typeToBind.Name + "Binder", typeFlags, null, new Type[] { typeToBind });
        //    else
        //        typeBuilder = moduleBuilder.DefineType(typeToBind.Name + "Binder", typeFlags, typeToBind);

        //    FieldBuilder bindableObjectFieldBuilder = typeBuilder.DefineField("OriginalBindingObject", typeToBind, FieldAttributes.Private);
        //    ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, new Type[] { typeToBind });

        //    ConstructorInfo parentConstructor = null;
        //    if (!typeToBind.IsInterface)
        //    {
        //        parentConstructor = typeToBind.GetConstructor(Type.EmptyTypes);
        //        if (parentConstructor == null)
        //            throw new ArgumentException("Cannot use {0} as a binding source since it does not have a parameterless constructor.", typeToBind.Name);
        //    }

        //    ILGenerator ilConstructor = constructorBuilder.GetILGenerator();

        //    if (parentConstructor != null)
        //    {
        //        ilConstructor.Emit(OpCodes.Ldarg_0);
        //        ilConstructor.Emit(OpCodes.Call, parentConstructor);
        //    }

        //    ilConstructor.Emit(OpCodes.Ldarg_0);
        //    ilConstructor.Emit(OpCodes.Ldarg_1);
        //    ilConstructor.Emit(OpCodes.Stfld, bindableObjectFieldBuilder);

        //    foreach (PropertyInfo prop in typeToBind.GetProperties())
        //    {
        //        PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(prop.Name, PropertyAttributes.None, prop.PropertyType, null);

        //        FieldBuilder valueFieldBuilder = typeBuilder.DefineField(prop.Name + "Field", prop.PropertyType, FieldAttributes.Private);
        //        FieldBuilder nameFieldBuilder = typeBuilder.DefineField(prop.Name + "Name", typeof(string), FieldAttributes.Private);
        //        nameFieldBuilder.SetConstant(prop.Name);

        //        MethodAttributes getterFlags = MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig;
        //        MethodAttributes setterFlags = MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig;

        //        MethodInfo getMethod = prop.GetGetMethod();
        //        MethodInfo setMethod = prop.GetSetMethod();

        //        string getterName = getMethod == null ? "get_" + prop.Name : getMethod.Name;
        //        string setterName = setMethod == null ? "set_" + prop.Name : setMethod.Name;
        //        bool abstractGet = getMethod != null && getMethod.IsAbstract;
        //        bool virtualGet = getMethod != null && (getMethod.IsVirtual && !getMethod.IsFinal);
        //        bool abstractSet = setMethod != null && setMethod.IsAbstract;
        //        bool virtualSet = setMethod != null && (setMethod.IsVirtual && !setMethod.IsFinal);
        //        if (abstractGet)
        //            getterFlags |= MethodAttributes.Virtual;
        //        else if (virtualGet)
        //            getterFlags |= MethodAttributes.Virtual;

        //        if (abstractSet)
        //            setterFlags |= MethodAttributes.Virtual;
        //        else if (virtualSet)
        //            setterFlags |= MethodAttributes.Virtual;

        //        ilConstructor.Emit(OpCodes.Ldarg_0);
        //        ilConstructor.Emit(OpCodes.Ldstr, prop.Name);
        //        ilConstructor.Emit(OpCodes.Stfld, nameFieldBuilder);

        //        MethodBuilder getMethodBuilder = typeBuilder.DefineMethod(getterName, getterFlags, prop.PropertyType, Type.EmptyTypes);

        //        if (prop.CanRead)
        //        {
        //            ILGenerator ilGetter = getMethodBuilder.GetILGenerator();

        //            // Load the reference to the object to bind
        //            ilGetter.Emit(OpCodes.Ldarg_0);
        //            ilGetter.Emit(OpCodes.Ldfld, bindableObjectFieldBuilder);

        //            // Load the name of the property
        //            ilGetter.Emit(OpCodes.Ldarg_0);
        //            ilGetter.Emit(OpCodes.Ldfld, nameFieldBuilder);

        //            // Push the values onto the binding stack
        //            ilGetter.EmitCall(OpCodes.Call, typeof(BindingPairHolder).GetMethod("DeclareBindingPair", BindingFlags.Public | BindingFlags.Static), null);

        //            // Load a value to return from the getter
        //            ilGetter.Emit(OpCodes.Ldarg_0);
        //            if (abstractGet)
        //                ilGetter.Emit(OpCodes.Ldfld, valueFieldBuilder);
        //            else
        //                ilGetter.EmitCall(OpCodes.Call, getMethod, null);

        //            // Return
        //            ilGetter.Emit(OpCodes.Ret);

        //            propertyBuilder.SetGetMethod(getMethodBuilder);
        //        }

        //        if (prop.CanWrite)
        //        {
        //            MethodBuilder setMethodBuilder = typeBuilder.DefineMethod(setterName, setterFlags, null, new Type[] { prop.PropertyType });

        //            ILGenerator ilSetter = setMethodBuilder.GetILGenerator();

        //            // Load this and the value onto the stack
        //            ilSetter.Emit(OpCodes.Ldarg_0);
        //            ilSetter.Emit(OpCodes.Ldarg_1);

        //            // Store field locally or call parent setter
        //            if (abstractSet)
        //                ilSetter.Emit(OpCodes.Stfld, valueFieldBuilder);
        //            else
        //                ilSetter.EmitCall(OpCodes.Call, setMethod, null);

        //            // Return
        //            ilSetter.Emit(OpCodes.Ret);

        //            propertyBuilder.SetSetMethod(setMethodBuilder);
        //        }
        //    }

        //    ilConstructor.Emit(OpCodes.Ret);

        //    T bindable = (T)Activator.CreateInstance(typeBuilder.CreateType(), instance);

        //    return bindable;
        //}

        #endregion
    }
}

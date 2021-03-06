// Copyright 2004-2007 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.DynamicProxy
{
	using System;
	using System.Diagnostics;
	using System.Reflection;
	using System.Runtime.Serialization;
	using Castle.Core.Interceptor;

	[Serializable]
	public abstract class AbstractInvocation : IInvocation, ISerializable
	{
		private readonly object proxy;
		private readonly object target;
		private readonly IInterceptor[] interceptors;
		private readonly Type targetType;
		private readonly MethodInfo targetMethod;
		private readonly MethodInfo interfMethod;
		private object returnValue;
		private object[] arguments;
		private int execIndex = -1;
		private Type[] genericMethodArguments = null;

		protected AbstractInvocation(
			object target, object proxy, IInterceptor[] interceptors,
			Type targetType, MethodInfo targetMethod, object[] arguments)
		{
			this.proxy = proxy;
			this.target = target;
			this.interceptors = interceptors;
			this.targetType = targetType;
			this.targetMethod = targetMethod;
			this.arguments = arguments;
		}

		protected AbstractInvocation(
			object target, object proxy, IInterceptor[] interceptors,
			Type targetType, MethodInfo targetMethod, MethodInfo interfMethod,
			object[] arguments)
			: this(target, proxy, interceptors, targetType, targetMethod, arguments)
		{
			this.interfMethod = interfMethod;
		}

		public void SetGenericMethodArguments(Type[] arguments)
		{
			genericMethodArguments = arguments;
		}

		public Type[] GenericArguments
		{
			get { return genericMethodArguments; }
		}

		public object Proxy
		{
			get { return proxy; }
		}

		public object InvocationTarget
		{
			get { return target; }
		}

		public Type TargetType
		{
			get { return targetType; }
		}

		public MethodInfo Method
		{
			get
			{
				if (interfMethod == null)
				{
					return targetMethod;
				}
				else
				{
					return interfMethod;
				}
			}
		}

		public MethodInfo GetConcreteMethod()
		{
			return EnsureClosedMethod(Method);
		}

		public MethodInfo MethodInvocationTarget
		{
			get { return targetMethod; }
		}

		public MethodInfo GetConcreteMethodInvocationTarget()
		{
			return EnsureClosedMethod(MethodInvocationTarget);
		}

		public object ReturnValue
		{
			get { return returnValue; }
			set { returnValue = value; }
		}

		public object[] Arguments
		{
			get { return arguments; }
		}

		public void SetArgumentValue(int index, object value)
		{
			arguments[index] = value;
		}

		public object GetArgumentValue(int index)
		{
			return arguments[index];
		}

		public void Proceed()
		{
			execIndex++;

			if (execIndex == interceptors.Length)
			{
				InvokeMethodOnTarget();
			}
			else if (execIndex > interceptors.Length)
			{
				throw new InvalidOperationException(
					@"Proceed() cannot delegate to another interceptor. This usually signify a bug in the calling code");
			}
			else
			{
				interceptors[execIndex].Intercept(this);
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(typeof(RemotableInvocation));
			info.AddValue("invocation", new RemotableInvocation(this));
		}

		protected abstract void InvokeMethodOnTarget();

		private MethodInfo EnsureClosedMethod(MethodInfo method)
		{
			if (method.ContainsGenericParameters)
			{
				Debug.Assert(genericMethodArguments != null);
				return method.GetGenericMethodDefinition().MakeGenericMethod(genericMethodArguments);
			}
			else
			{
				return method;
			}
		}
	}
}
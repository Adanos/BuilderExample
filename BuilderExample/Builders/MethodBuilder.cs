using System.Collections.Generic;

namespace BuilderExample.Builders
{
	sealed class MethodBuilder: IBuildable<Method>
	{
		public string name { get; private set; }
		public AccessModifier accessModifier { get; private set; }
		public Dictionary<string, string> parameters { get; private set; }

		public MethodBuilder(string name, AccessModifier accessModifier)
		{
			this.name = name;
			this.accessModifier = accessModifier;
			parameters = new Dictionary<string, string>();
		}

		public MethodBuilder addParameter(string name, string type)
		{
			parameters.Add(name, type);
			return this;
		}

		public MethodBuilder removeParameter(string name)
		{
			parameters.Remove(name);
			return this;
		}

		public Method build()
		{
			return new Method(this);
		}
	}
}

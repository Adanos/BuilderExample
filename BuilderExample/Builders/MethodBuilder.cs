﻿using System.Collections.Generic;

namespace BuilderExample.Builders
{
	sealed class MethodBuilder
	{
		public string name { get; private set; }
		public Dictionary<string, string> parameters { get; private set; }

		public MethodBuilder(string name)
		{
			this.name = name;
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
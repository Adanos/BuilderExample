using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample.Builders
{
	sealed class FieldBuilder
	{
		public string name { get; private set; }
		public string value { get; private set; }
		public string type { get; private set; }
		public AccessModifier accessModifier { get; private set; }

		public FieldBuilder(string name, string type, AccessModifier accessModifier)
		{
			this.name = name;
			this.type = type;
			this.accessModifier = accessModifier;
		}

		public FieldBuilder setValue(string value)
		{
			this.value = value;
			return this;
		}
	}
}

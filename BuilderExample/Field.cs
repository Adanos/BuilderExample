using BuilderExample.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	class Field
	{
		private readonly string name;
		private readonly string value;
		private readonly string type;
		private readonly AccessModifier accessModifier;

		public Field(FieldBuilder builder)
		{
			this.name = builder.name;
			this.type = builder.type;
			this.accessModifier = builder.accessModifier;
			this.value = builder.value;
		}

		/*internal sealed class Builder
		{
			public string name { get; private set; }
			public string value { get; private set; }
			public string type { get; private set; }
			public AccessModifier accessModifier { get; private set; }

			public builder(string name, string type, AccessModifier accessModifier)
			{
				this.name = name;
				this.type = type;
				this.accessModifier = accessModifier;
			}

			public builder setValue(string value)
			{
				this.value = value;
				return this;
			}

			public Field build()
			{
				return new Field(this);
			}
		}*/
	}
}

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
	}
}

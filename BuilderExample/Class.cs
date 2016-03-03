using System.Collections.Generic;

namespace BuilderExample
{
	class Class
	{
		private readonly string name;
		private readonly AccessModifier accessModifier;
		private readonly ISet<Field> fields;
		private readonly ISet<Property> properties;
		private readonly ISet<Method> methods;

		public Class(Builders.ClassBuilder builder)
		{
			name = builder.name;
			accessModifier = builder.accessModifier;
			fields = builder.fields;
			properties = builder.properties;
			methods = builder.methods;
		}
	}
}

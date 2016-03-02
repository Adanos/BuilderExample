
namespace BuilderExample
{
	class Property
	{
		private readonly string name;
		private readonly string value;
		private readonly string type;
		private readonly AccessModifier accessModifier;

		public Property(Builders.PropertyBuilder builder)
		{
			name = builder.name;
			type = builder.type;
			accessModifier = builder.accessModifier;
			value = builder.value;
		}
	}
}

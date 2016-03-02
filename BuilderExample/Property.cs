
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
			this.name = builder.name;
			this.type = builder.type;
			this.accessModifier = builder.accessModifier;
			this.value = builder.value;
		}
	}
}

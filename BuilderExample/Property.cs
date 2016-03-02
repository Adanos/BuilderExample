
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

		public override int GetHashCode()
		{
			int value = 17;
			value = 31 * value + name.GetHashCode();
			return value;
		}

		public override bool Equals(object obj)
		{
			Property property = obj as Property;

			if (property == null) return false;
			return name.Equals(property.name);
		}
	}
}

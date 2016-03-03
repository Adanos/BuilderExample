
namespace BuilderExample.Builders
{
	sealed class PropertyBuilder: IBuildable<Property>
	{
		public string name { get; private set; }
		public string value { get; private set; }
		public string type { get; private set; }
		public AccessModifier accessModifier { get; private set; }

		public PropertyBuilder(string name, string type, AccessModifier accessModifier)
		{
			this.name = name;
			this.type = type;
			this.accessModifier = accessModifier;
		}

		public PropertyBuilder setValue(string value)
		{
			this.value = value;
			return this;
		}

		public Property build()
		{
			return new Property(this);
		}
	}
}

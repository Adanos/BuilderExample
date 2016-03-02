
namespace BuilderExample
{
	class Field
	{
		private readonly string name;
		private readonly string value;
		private readonly string type;
		private readonly AccessModifier accessModifier;

		public Field(Builders.FieldBuilder builder)
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
			Field field = obj as Field;

			if (field == null) return false;
			return name.Equals(field.name);
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

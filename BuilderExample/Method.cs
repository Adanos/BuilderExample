using System.Collections.Generic;
using System.Linq;

namespace BuilderExample
{
	class Method
	{
		private readonly string name;
		private readonly string body;
		private readonly AccessModifier accessModifier;
		private readonly Dictionary<string, string> parameters;

		public Method(Builders.MethodBuilder builder)
		{
			name = builder.name;
			body = builder.body;
			accessModifier = builder.accessModifier;
			parameters = builder.parameters;
		}

		public override int GetHashCode()
		{
			int value = 17;
			int multiplier = 31;
			int multiplierDict = 7;
			int dictHashCode = 0;
			value = multiplier * value + name.GetHashCode();
			
			foreach (var element in parameters)
				dictHashCode = element.Key.GetHashCode() * multiplierDict + element.Value.GetHashCode();

			value = multiplier * value + dictHashCode;
			return value;
		}

		public override bool Equals(object obj)
		{
			Method method = obj as Method;

			if (method == null) return false;
			if (parameters.Count != method.parameters.Count) return false;
			if (!parameters.SequenceEqual(method.parameters)) return false;

			return name.Equals(method.name);
		}
	}
}

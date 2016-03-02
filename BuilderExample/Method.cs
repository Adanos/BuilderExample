using System.Collections.Generic;

namespace BuilderExample
{
	class Method
	{
		private readonly string name;
		private readonly Dictionary<string, string> parameters;

		public Method(Builders.MethodBuilder builder)
		{
			name = builder.name;
			parameters = builder.parameters;
		}
	}
}

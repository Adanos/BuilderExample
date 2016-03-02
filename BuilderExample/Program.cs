using BuilderExample.Builders;

namespace BuilderExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Field field = new FieldBuilder("nazwa", "typ", AccessModifier.Internal).setValue("2").build();
			Method method = new MethodBuilder("mojaMetoda").removeParameter("test").addParameter("nowa", "int").build();
		}
	}
}

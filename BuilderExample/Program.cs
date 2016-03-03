using BuilderExample.Builders;
using System;

namespace BuilderExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Field field = new FieldBuilder("nazwa", "typ", AccessModifier.Internal).setValue("2").build();
			Field field2 = new FieldBuilder("nazwa3", "typ", AccessModifier.Internal).setValue("3").build();
			Method method = new MethodBuilder("mojaMetoda", AccessModifier.Private).removeParameter("test").addParameter("nowa", "float").build();
			Method method2 = new MethodBuilder("mojaMetoda", AccessModifier.Protected).removeParameter("test").addParameter("nowa", "float").build();
			Class myClass = new ClassBuilder("klasa", AccessModifier.Public).addField(field).addField(field2)
				.addMethod(method).addMethod(method2).build();

			Console.WriteLine("mojaMetoda".GetHashCode());
			Console.WriteLine("mojaMetoda".GetHashCode());
			Console.WriteLine(method.Equals(method2));
		}
	}
}

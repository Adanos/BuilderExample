using BuilderExample.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Field field = new FieldBuilder("nazwa", "typ", AccessModifier.Internal).setValue("2").build();
		}
	}
}

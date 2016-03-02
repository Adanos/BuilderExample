using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
	class Field
	{
		private string key;
		private string value;

		public Field(string key, string value)
		{
			this.key = key;
			this.value = value;
		}
	}
}

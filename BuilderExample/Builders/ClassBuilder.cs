using System.Collections.Generic;

namespace BuilderExample.Builders
{
	sealed class ClassBuilder: IBuildable<Class>
	{
		public string name { get; private set; }
		public ISet<Field> fields { get; private set; }
		public ISet<Property> properties { get; private set; }
		public ISet<Method> methods { get; private set; }

		public ClassBuilder(string name)
		{
			this.name = name;
			fields = new HashSet<Field>();
			properties = new HashSet<Property>();
			methods = new HashSet<Method>();
		}

		public ClassBuilder addField(Field field)
		{
			fields.Add(field);
			return this;
		}

		public ClassBuilder addProperty(Property property)
		{
			properties.Add(property);
			return this;
		}

		public ClassBuilder addMethod(Method method)
		{
			methods.Add(method);
			return this;
		}

		public ClassBuilder removeField(Field field)
		{
			fields.Remove(field);
			return this;
		}

		public ClassBuilder removeProperty(Property property)
		{
			properties.Remove(property);
			return this;
		}

		public ClassBuilder removeMethod(Method method)
		{
			methods.Remove(method);
			return this;
		}

		public Class build()
		{
			return new Class(this);
		}
	}
}

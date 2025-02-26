﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Employee : IEmployee
	{

		public string eid;
		public string name;

		public Employee(string eid, string name)
		{
			if (eid.Length != 3 || !eid.All(x => Char.IsLetter(x))) 
			{
				throw new BadIDException();
			};

			this.eid = eid;
			this.name = name;
			
		}

		int IComparable<IEmployee>.CompareTo(IEmployee other)
		{
			throw new NotImplementedException();
		}

		bool IEquatable<IEmployee>.Equals(IEmployee other)
		{
			throw new NotImplementedException();
		}

		string IEmployee.GetEID()
		{
			return eid; 
		}

		string IPerson.GetName()
		{
			return name;
		}

		void IPrintable.Print(IPrinter printer)
		{
			printer.PrintLine("[" + eid +"] " + name);
		}
	}
}

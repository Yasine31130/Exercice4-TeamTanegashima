﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class BadIDException : Exception
	{
		string errorId;

		public BadIDException(string? message) : base(message) 
		{ }

	}
}

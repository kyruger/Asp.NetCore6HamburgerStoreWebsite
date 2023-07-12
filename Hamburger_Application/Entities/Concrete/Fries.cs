﻿using Hamburger_Application.Entities.Abstract;
using Hamburger_Application.Entities.Enum;
using Size = Hamburger_Application.Entities.Enum.Size;

namespace Hamburger_Application.Entities.Concrete
{
	public class Fries : BaseEntity
	{
		public Size Size { get; set; }
		public int? OrderId { get; set; }
		public Order? Order { get; set; }
		public int? MenuId { get; set; }
		public Menu? Menu { get; set; }
	}
}

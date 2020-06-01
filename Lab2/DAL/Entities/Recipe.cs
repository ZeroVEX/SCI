﻿using DAL.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	public class Recipe : IEntity
	{
		[Key]
		public int ID { get; set; }
		public int IngredientID { get; set; }
		public int ProductID { get; set; }
		public double Quantity { get; set; }
		public Product Product { get; set; }
		public Ingredient Ingredient { get; set; }
		public Recipe(int PID, int IID, double Quant)
		{
			this.ProductID = PID;
			this.IngredientID = IID;
			this.Quantity = Quant;
		}
		public Recipe()
		{

		}
	}
}

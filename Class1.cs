using System;

public abstract class Product
{
	string Name { get; set; }
	double Quntity { get
		{ this += value; } 
			set; }
	object Image { get; set; }
	string Address { get; set; }
	string Articul { get; set; }
	public Class1( string name, string addres, string artiqul,object image, double quantity = 0)
	{
		this.Name = name;
		this.Address = addres;
		this.Articul = artiqul;
		this.Image = image;
		this.Quntity = quantity;
	}
}

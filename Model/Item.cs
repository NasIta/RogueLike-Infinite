using System;
using System.Drawing;
using System.Windows.Forms;

using RogueLike.Model.Interfaces;

namespace RogueLike.Model
{
	[Serializable] 
	public class Item: IUnique
	{
		public int Id {get; set;}
		public string Name {get; set;}
	}
}

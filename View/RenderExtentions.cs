using System;
using System.ComponentModel;
using System.Drawing;

using RogueLike.Model;
using RogueLike.Model.Interfaces;
using RogueLike.Model.Environments;

namespace RogueLike.View
{
	public static class RenderExtentions
	{
		const int modifier = 20;
		
		private static Bitmap _bmp {get; set;}
		private static Graphics _graph {get; set;}
		
		public static void Render(this Scene scene)
		{	
			if (_bmp == null || _bmp.Size != MainForm.instance.pictureBox.Size) 
			{
				_bmp = new Bitmap(scene.Size.X * modifier + modifier * 2, scene.Size.Y * modifier + modifier * 2);
				_graph = Graphics.FromImage(_bmp);
			}
			
			_graph.Clear(Color.DarkRed);
			
			foreach (var gameObject in scene.Childrens) 
			{
				(gameObject as GameObject).Render();
			}
			
			MainForm.instance.pictureBox.Image = _bmp;
		}
		
		private static void Render(this GameObject gameObject)
		{		
			if (gameObject as IRenderizable != null)
			{
				var rect = new Rectangle()
				{
					X = gameObject.Position.X * modifier,
					Y = gameObject.Position.Y * modifier,
					Width = modifier,
					Height = modifier
				};
				
				if (gameObject is Wall) 
				{	
					_graph.FillRectangle(new SolidBrush(Color.Firebrick), rect);
					_graph.DrawLine(new Pen(Color.Chocolate), rect.X, rect.Y + modifier / 2, rect.X + modifier - 1, rect.Y + modifier / 2);
				}
				else if (gameObject is Player) 
				{
					_graph.FillEllipse(new SolidBrush(Color.White), rect);
				}
				else if (gameObject is Chest) 
				{
					_graph.FillRectangle(new SolidBrush(Color.Chocolate), rect);
					_graph.FillRectangle(new SolidBrush(Color.Brown), rect.X, rect.Y + modifier / 3 * 2, modifier, modifier - modifier / 3 * 2);
					_graph.FillRectangle(new SolidBrush(Color.Gold), rect.X + modifier / 2 - 1, rect.Y + modifier / 2 , 2, 4);
					_graph.DrawLine(new Pen(Color.FromArgb(150, 0, 0, 0), modifier / 10), rect.X + 1, rect.Y + 1, rect.X + modifier - 1, rect.Y + 1);
				}
				
				if (Player.instance.SelectedObject == gameObject) 
				{
					_graph.DrawRectangle(new Pen(Color.Yellow, modifier / 10), rect);
					ScreenUpdater.OnSelected(gameObject);
				}
				else if(Player.instance.SelectedObject == null)
				{
					ScreenUpdater.OnUnselected();
				}
			}
		}
	}
}

using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using RogueLike.Model.Interfaces;
using RogueLike.Model.Environments;

namespace RogueLike.Model
{
	[Serializable]
	public class Player: Mob
	{
		public static Player instance {get; set;}
		public List<Item> Inventory {get; set;}
		
		public GameObject SelectedObject {get; set;}
		
		public int ManaPoints {get; set;}
		public int MaxManaPoints {get; set;}
		public int Hunger {get; set;}
		public int MaxHunger {get; set;}
		public int Level {get; set;}
		public int MaxLevel {get; set;}
		public int Expierence {get; set;}
		public int MaxInventoryCount {get; set;}
		
		public Player()
		{
			MaxHealthPoints = 100;
			HealthPoints = MaxHealthPoints;
			
			MaxHunger = 100;
			Hunger = MaxHunger;
			
			Speed = 1;
			Strength = 10;
			
			Level = 1;
			MaxLevel = 10;
			
			MaxInventoryCount = 15;
			Inventory = new List<Item>();
		}
		
		public static void Die()
		{
			
		}
		
		public static void ApplyDamage(int damage)
		{
			instance.HealthPoints -= damage;
			ScreenUpdater.OnHealthChanged();
			
			if (instance.HealthPoints <= 0) 
			{
				Die();
			}
		}
		
		public static int GetMaxExp()
		{
			return 100 + (int)Math.Pow((instance.Level - 1) * instance.Level, 1.15);
		}
		
		public static void ApplyExpierence(int expierence)
		{
			instance.Expierence += expierence;
			
			if (instance.Expierence >= GetMaxExp()) 
			{
				if (instance.Level < instance.MaxLevel) 
				{
					instance.Expierence %= GetMaxExp();
					instance.Level++;
				}
				else
				{
					instance.Expierence = GetMaxExp() - 1;
				}
			}
			
			ScreenUpdater.OnLevelExpChanged();
		}
		
		public static void SpendHunger()
		{
			if (instance.Hunger > 0) 
			{
				instance.Hunger--;
				ScreenUpdater.OnHungerChanged();
			}
			else
			{
				ApplyDamage(1);
			}
		}
		
		public static void Move(int dx, int dy)
		{
			var frontObject = instance.Position.LookAt(dx, dy);
			
			if (frontObject is Door) 
			{
				Door.SelectedDoor = (frontObject as Door).Direction;
				Scene.LoadOrCreateAt(dx, -dy);
				
				SetToDoor();
			}
			
			if (!(frontObject is ISolid))
			{
				Player.instance.Position = Player.instance.Position.Add(dx, dy);
				
				CheckSelectableItems();
				
				SpendHunger();
			}
		}
		
		public static void SetToDoor()
		{
			var spawnPlace = ((IPosed)Game.instance.ActiveScene.Childrens
				.Where(u => u is Door)
				.First(u => (u as Door).Direction == (Door.SelectedDoor + 2) % 4)).Position;
			instance.Position = spawnPlace;
		}

		private static void CheckSelectableItems()
		{
			instance.SelectedObject = (GameObject)Game.instance.ActiveScene.Childrens
				.FirstOrDefault(
					u => 
						(u as GameObject).Position.Distance(instance.Position) < 1.5 
						&& u is IUsable 
						&& !(u as IUsable).Used
				);
		}
	}
}

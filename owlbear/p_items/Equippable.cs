using System;
namespace Items
{
	public interface Equippable
	{
		bool equipped { get; set; }

		void equip();
		void unequip();
	}
}


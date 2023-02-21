using System;
namespace Items.Properties
{
	public interface Equippable
	{
		bool equipped { get; set; }

        /// <summary>
        /// <para>MODIFIES: this</para>
        /// <para>EFFECTS : sets equipped status to true (item is equipped)
		/// </para>
        /// </summary>
        void equip();

        /// <summary>
        /// <para>MODIFIES: this</para>
        /// <para>EFFECTS : sets equipped status to false (item is unequipped)
        /// </para>
        /// </summary>
        void unequip();
	}
}


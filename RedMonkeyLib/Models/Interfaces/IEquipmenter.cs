namespace RedMonkeyLib.Models.Interfaces
{
    public interface IEquipmenter
    {
        IWeapon Weapon { get; }
        IArmor Armor { get; }
        void EquipWeapon(IWeapon weapon);
        void EquipArmor(IArmor armor);
    }
}
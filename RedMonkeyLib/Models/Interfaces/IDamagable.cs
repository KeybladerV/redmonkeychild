namespace RedMonkeyLib.Models.Interfaces
{
    public interface IDamagable
    {
        int HP { get; }
        int MaxHP { get; }
        bool IsAlive { get; }
        void TakeDamage(int damage);
        void HealDamage(int damage);
        void MaxHeal();
        void Resurrect();
    }
}
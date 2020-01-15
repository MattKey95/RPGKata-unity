public interface IHealth
{
    int CurrentHealth { get; set; }
    bool IsDead { get; set; }
    void TakeDamage(int amount);
    void Heal(int amount);
}
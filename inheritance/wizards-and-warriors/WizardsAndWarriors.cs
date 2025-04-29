abstract class Character
{
    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => "Character is a " + GetType().Name;
}

class Warrior : Character
{
    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}

class Wizard : Character
{
    bool spellPrepared = false;
    public override int DamagePoints(Character target) => spellPrepared ? 12 : 3;
    public override bool Vulnerable() => !spellPrepared;

    public void PrepareSpell() => spellPrepared = true;
}

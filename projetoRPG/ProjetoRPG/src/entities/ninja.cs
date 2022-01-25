namespace ProjetoRPG.src.entities
{
    public class ninja : Hero
    {
        public ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public ninja()
        {

        }

        public override string Attack()
        {
            return this.Name + " lançou magia";
        }

        public string Attack(int bonus)
        {
            if (bonus>6){
                return this.Name + " lançou shuriken superefetiva com bonus " + bonus;
            }else{
                return this.Name + " lançou shuriken com força fraca, bonus de " + bonus;
            }
        }
    }
}
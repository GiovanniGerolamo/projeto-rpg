namespace ProjetoRPG.src.entities
{
    public class blackwizard : Hero
    {
        public blackwizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public blackwizard()
        {

        }

        public override string Attack()
        {
            return this.Name + " lançou magia";
        }

        public string Attack(int bonus)
        {
            if (bonus>6){
                return this.Name + " lançou magia superefetiva com bonus " + bonus;
            }else{
                return this.Name + " lançou magia com força fraca, bonus de " + bonus;
            }
        }
    }
}
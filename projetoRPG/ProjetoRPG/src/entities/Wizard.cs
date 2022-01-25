namespace ProjetoRPG.src.entities
{
    public class Wizard : Hero
    {
       public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Wizard()
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
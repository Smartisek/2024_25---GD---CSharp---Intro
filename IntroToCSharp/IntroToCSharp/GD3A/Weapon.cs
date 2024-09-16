using IntroToCSharp.GD3A.Utilities;

namespace IntroToCSharp.GD3A
{
    internal class Weapon
    {
        #region Instance Variables

        public bool IsEquipped;
        public string name;
        public float damage;
        public int ammoCount;

        #endregion Instance Variables

        #region Constructors

        public Weapon()  //default constructor
        {
            this.ammoCount = 10;
            this.damage = 100;
            this.name = "Default Weapon";
            this.IsEquipped = false;
        }

        public Weapon(string name, float damage,
            int ammoCount, bool IsEquipped) //full constructor
        {
            this.name = name;
            this.damage = damage;
            this.ammoCount = ammoCount;
            this.IsEquipped = IsEquipped;
        }

        #endregion Constructors

        //TODO - NMCG - Add ToString, Equals, Properties

       public bool Equals(Weapon other)
        {
            return MathUtility.AreEqualWithin(this.damage, other.damage, MathUtility.FLOAT_TOLERANCE);
            //return this.name == other.name;     
            // MathUtility mathUtility = new MathUtility();
            // return mathUtility.AreEqualWithin(this.damage, other.damage, 0.0001f);
        }

        public override string ToString()
        {
            // string interpolation example 
            return $"Weapon: {name},{damage},{ammoCount},{IsEquipped}";
        }



        //RFR - NMCG - Make this run within 60-80 FPS
    }
}
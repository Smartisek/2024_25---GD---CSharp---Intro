
using IntroToCSharp.Common.Exercise1;
using IntroToCSharp.Common.Exercise2;

namespace IntroToCSharp.Common.Exercises.Design.Exercise_1___Object_mods
{
    internal interface IDoDamage
    {
        void Damage(Predicate<GameObject> pred, GameObjecct obj);
    }

    public class DamageHealth : IDoDamage
    {
        public void Damage(Predicate<GameObject> pred, GameObjecct obj)
        {
            if (pred(obj))
            {
                Player? p = obj as Player;
                p.health -= 10;
            }
        }
    }

    public class DamageSpeed : IDoDamage
    {
        public void Damage(Predicate<Exercise1.GameObject> pred, GameObjecct obj)
        {
            if (pred(obg))
            {
                Player? p = obj as Player;
                p.moveSpeed *= 0.5f;
            }
        }
    }

    //internal interface IFilterObject
    //{
    //    bool Filter(GameObject obj);
    //}

    //public class FilterPlayer : IFilterObject
    //{
    //    public bool Filter(GameObject obj)
    //    {
    //        var p = obj as Player;
    //        return p != null;
    //    }
    //}
    //public class FilterPlayerByHealth : IFilterObject
}

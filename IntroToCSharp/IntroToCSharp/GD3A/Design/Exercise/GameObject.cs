

namespace IntroToCSharp.GD3A.Design.Exercise
{
    public class GameObject
    {
        public string ID;
        public bool isActive;
        float x, y, z;
        

    

        public GameObject(string iD, bool isActive, float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            ID = iD;
            this.isActive = isActive;
        }
        public GameObject() : this("Default", false, 0, 0, 0) { }
    }
}

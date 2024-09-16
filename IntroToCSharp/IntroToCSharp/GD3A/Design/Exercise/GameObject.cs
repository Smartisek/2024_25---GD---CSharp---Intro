

namespace IntroToCSharp.GD3A.Design.Exercise
{
    public class GameObject
    {
        float x, y, z;
        public string ID;
        public bool isActive;

        public GameObject(float x, float y, float z, string iD, bool isActive)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            ID = iD;
            this.isActive = isActive;
        }
    }
}

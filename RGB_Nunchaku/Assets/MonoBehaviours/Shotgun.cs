using UnityEngine;

namespace ModThatIsNotMod.MonoBehaviours
{
    /// <summary>
    /// Put on the same gameobject as a Gun component.
    /// Setting shots to 1 can be used to make a gun inaccurate.
    /// </summary>
    internal class Shotgun : MonoBehaviour
    {
        public int shots = 8;
        public float maxSpreadAngle = 2f;
    }
}

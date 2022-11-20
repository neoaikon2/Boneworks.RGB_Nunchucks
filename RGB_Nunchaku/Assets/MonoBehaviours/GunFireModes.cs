using StressLevelZero.Props.Weapons;
using System.Collections;
using UnityEngine;

namespace ModThatIsNotMod.MonoBehaviours
{
    /// <summary>
    /// Put this component on the same gameobject as a gun component.
    /// </summary>
    internal class GunFireModes : MonoBehaviour
    {
        public FireMode[] allowedFireModes;

        public int burstShots = 3;
        public float burstTimeout = 0.2f;


        public enum FireMode
        {
            FullAuto,
            SemiAuto,
            Burst
        }
    }
}

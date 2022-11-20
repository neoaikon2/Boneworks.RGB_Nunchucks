using UnityEngine;

namespace ModThatIsNotMod.MonoBehaviours
{
    /// <summary>
    /// Put this on the same gameobject as a gun component.
    /// </summary>
    public class SimpleGunModifiers : MonoBehaviour
    {
        public MuzzleFlashType muzzleFlashType = MuzzleFlashType.Default;
        public Vector3 ejectedCartridgeScale = Vector3.one;

        public int ammoPerShot = 1;

        public bool disableSlideLock = false;

        public bool requiresCharging = false;
        public float chargingTime = 1;

        public enum MuzzleFlashType
        {
            Default,
            Silenced,
            None
        }
    }
}
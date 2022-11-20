using UnityEngine;

namespace ModThatIsNotMod.MonoBehaviours
{
    /// <summary>
    /// Changes the behaviour of some mag eject options.
    /// </summary>
    public class MagEjectSettings : MonoBehaviour
    {
        public AutoEjectMode autoEjectMode = AutoEjectMode.Default;
        public bool disableMagEjectButton = false;

        public enum AutoEjectMode
        {
            Default,
            Never,
            Always
        }
    }
}

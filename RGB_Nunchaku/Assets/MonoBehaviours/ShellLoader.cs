using UnityEngine;

namespace ModThatIsNotMod.MonoBehaviours
{
    /// <summary>
    /// Put on the same gameobject as a gun component to load individual shells.
    /// </summary>
    public class ShellLoader : MonoBehaviour
    {
        public int ammoPerShell = 1;
        public int maxShells = 6;
    }
}

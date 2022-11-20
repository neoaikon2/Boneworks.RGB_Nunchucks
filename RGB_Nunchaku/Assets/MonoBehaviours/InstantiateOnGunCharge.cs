using UnityEngine;

namespace ModThatIsNotMod.MonoBehaviours
{
    /// <summary>
    /// Instantiates all child gameobjects when a gun above this component in the hierarchy starts charging with SimpleGunModifiers.
    /// </summary>
    public class InstantiateOnGunCharge : MonoBehaviour
    {
        // Whether the instantiated objects should follow the gun around or stay where they were created
        // If you have a particle effect and leave this as true, setting the simulation space to world will usually look much better
        public bool objectsFollowGun = true;
    }
}

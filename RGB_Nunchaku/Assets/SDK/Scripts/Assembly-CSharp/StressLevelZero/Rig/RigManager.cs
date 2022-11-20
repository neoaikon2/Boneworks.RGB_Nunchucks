using UnityEngine;
using StressLevelZero.VRMK;
using StressLevelZero.Player;

namespace StressLevelZero.Rig
{
	public class RigManager : MonoBehaviour
	{
		public SteamControllerRig steamControllerRig;
		public OculusControllerRig oculusControllerRig;
		public SkeletonRig realtimeSkeletonRig;
		public PhysicsRig physicsRig;
		public SkeletonRig gameWorldSkeletonRig;
		public UIRig uiRig;
		public BodyVitals bodyVitals;
		public Player_Health playerHealth;
		public PlayerInventory playerInventory;
	}
}

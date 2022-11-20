using UnityEngine;
using StressLevelZero.Interaction;

namespace StressLevelZero.Props.Weapons
{
	public class GravityStaff : MonoBehaviour
	{
		public Color defaultColor;
		public Color activeColor;
		public Transform target;
		public MeshRenderer[] meshRenderer;
		public InteractableHost host;
		public GravityManipulatorJob gravityManipulator;
		public GravityStaffReciever reciever;
	}
}

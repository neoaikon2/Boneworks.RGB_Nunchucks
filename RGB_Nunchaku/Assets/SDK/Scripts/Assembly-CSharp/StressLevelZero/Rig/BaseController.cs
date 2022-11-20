using UnityEngine;
using StressLevelZero;
using StressLevelZero.Player;

namespace StressLevelZero.Rig
{
	public class BaseController : MonoBehaviour
	{
		public Handedness handedness;
		public Transform hand;
		public Quaternion wristOffset;
		public ControllerRig manager;
		public ControllerInfo.Type controllerType;
	}
}

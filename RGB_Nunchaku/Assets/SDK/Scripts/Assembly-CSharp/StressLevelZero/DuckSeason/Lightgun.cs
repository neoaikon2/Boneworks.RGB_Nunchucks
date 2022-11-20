using UnityEngine;
using StressLevelZero.Interaction;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class Lightgun : MonoBehaviour
	{
		public Grip triggerGrip;
		public TelevisionInputReciever televisionInputReciever;
		public TelevisionChannelManager televisionChannelManager;
		public VRPhysicsRaycaster vrRaycaster;
		public GraphicRaycaster raycaster;
		public TelevisionInputModule tvInputModule;
		public InteractableInputModule interactableInputModule;
		public Transform triggerTransform;
		public Transform triggerStartTransform;
		public Transform triggerEndTransform;
	}
}

using UnityEngine;
using StressLevelZero;
using System.Collections.Generic;

namespace StressLevelZero.Player
{
	public class HandPoseTarget : MonoBehaviour
	{
		public Handedness handedness;
		public Handedness sourceHandedness;
		public Transform handTransform;
		public string handPoseTarget;
		[SerializeField]
		public List<ControllerInfo> controllerInfos;
	}
}

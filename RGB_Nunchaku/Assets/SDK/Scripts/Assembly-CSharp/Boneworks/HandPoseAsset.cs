using StressLevelZero;
using UnityEngine;

namespace Boneworks
{
	public class HandPoseAsset : SaveableObject
	{
		public string tag;
		public HandPoseJoint[] joints;
		[SerializeField]
		public IndexLink[] links;
	}
}

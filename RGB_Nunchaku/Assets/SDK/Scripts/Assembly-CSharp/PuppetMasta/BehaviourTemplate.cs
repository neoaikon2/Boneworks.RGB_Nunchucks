using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourTemplate : BehaviourBase
	{
		public SubBehaviourCOM centerOfMass;
		public LayerMask groundLayers;
		public BehaviourBase.PuppetEvent onLoseBalance;
		public float loseBalanceAngle;
	}
}

using UnityEngine;

namespace PuppetMasta
{
	public class BehaviourCrablet : BehaviourBaseNav
	{
		public SubBehaviourIk ik;
		public float jumpCooldown;
		public bool enableJumpAttack;
		public float facemountRngMult;
		public MeshRenderer visor;
		public SlotPosition slotPosition;
	}
}

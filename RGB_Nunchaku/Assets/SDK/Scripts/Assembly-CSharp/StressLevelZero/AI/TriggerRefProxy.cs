using UnityEngine;
using StressLevelZero.Interaction;

namespace StressLevelZero.AI
{
	public class TriggerRefProxy : MonoBehaviour
	{
		public enum TriggerType
		{
			Player = 0,
			Proxy = 1,
			Npc = 2,
		}

		public enum NpcType
		{
			FordHair = 1,
			FordShortHair = 2,
			EarlyExit = 4,
			NullBody = 8,
			Fordlet = 16,
			Crablet = 32,
			OmniProjector = 64,
			OmniWrecker = 128,
			OmniTurret = 256,
			Turret = 512,
			NullRat = 1024,
			Voidman = 2048,
		}

		public TriggerType triggerType;
		public NpcType npcType;
		public GameObject root;
		public Rigidbody targetHead;
		public Rigidbody lfHandRb;
		public Rigidbody rtHandRb;
		public Hand lfHand;
		public Hand rtHand;
		public Transform chestTran;
		public Transform feetTran;
	}
}

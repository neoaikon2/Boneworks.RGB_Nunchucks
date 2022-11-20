using StressLevelZero.Interaction;
using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class GameCartReciever : InteractionReciever
	{
		public Television television;
		public Transform startInsertTarget;
		public Transform endInsertTarget;
		public InteractableHost host;
	}
}

using UnityEngine;

namespace Chronos
{
	public class Timekeeper : Singleton<Timekeeper>
	{
		[SerializeField]
		private bool _debug;
		[SerializeField]
		private int _maxParticleLoops;
	}
}

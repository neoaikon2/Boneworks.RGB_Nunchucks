using UnityEngine;
using StressLevelZero.SFX;

namespace StressLevelZero.Pool
{
	public class CaseEject : MonoBehaviour
	{
		public ShellSFX shellSfx;
		public float startSpeed;
		public float startAxisSpeed;
		public GameObject bullet;
		[SerializeField]
		private CasePool casePool;
	}
}

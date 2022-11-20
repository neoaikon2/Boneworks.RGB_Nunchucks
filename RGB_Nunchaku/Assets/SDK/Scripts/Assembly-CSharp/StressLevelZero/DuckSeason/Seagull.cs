using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class Seagull : MonoBehaviour
	{
		public float speed;
		public Animator anim;
		public Vector2 startPos;
		public float minSpeed;
		public float maxSpeed;
		public float lifeTime;
		public float startTime;
		public float resetTime;
		public WhalingControl wControl;
	}
}

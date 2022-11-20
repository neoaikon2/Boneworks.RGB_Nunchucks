using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class SandWormManager : MonoBehaviour
	{
		public HoverJunkersChannel myChannel;
		public Transform[] wormSegments;
		public Image[] wormSegmentImages;
		public AnimationCurve curve;
		public RockThrowManager[] throwers;
		public float offsetTime;
		public float health;
		public bool isDead;
		public ExplosionSpriteManager[] explosions;
		public AudioClip explodeClip;
		public AudioClip sandWormClip;
		public AudioClip rockRiseClip;
	}
}

using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class SinatraProjectile : MonoBehaviour
	{
		public float lifeTime;
		public float startTime;
		public float resetTime;
		public Vector2 startPos;
		public bool enemyGun;
		public float speed;
		public Sprite origSprite;
		public GameObject hitImage;
		public Sprite explodeSpriteSingle;
		public Sprite explodeSpriteDouble;
		public SinatraControl sControl;
		public bool flyRight;
	}
}

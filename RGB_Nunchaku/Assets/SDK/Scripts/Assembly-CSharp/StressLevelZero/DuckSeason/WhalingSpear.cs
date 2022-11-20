using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class WhalingSpear : MonoBehaviour
	{
		public Vector2 startPos;
		public float startTime;
		public float lifeTime;
		public float resetTime;
		public Image image;
		public Sprite origSprite;
		public Sprite bloodSprite;
		public Image bloodImage;
		public bool moving;
		public float speed;
		public Transform cursor;
		public bool aiming;
		public WhalingControl whaleControl;
	}
}

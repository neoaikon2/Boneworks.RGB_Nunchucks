using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class SinatraHealth : MonoBehaviour
	{
		public SinatraControl sinatraControl;
		public int health;
		public Slider slider;
		public bool enemy;
		public bool dead;
		public bool boss;
		public Image image;
		public Sprite ogSprite;
		public Sprite hitSprite;
		public GameObject playerHitImage;
		public Animator anim;
		public GameObject musicHealth;
		public GameObject hitImage;
		public SinatraEnemyControl SEControl;
		public BoxCollider2D bossCollider;
		public GameObject[] monies;
		public Image KOImage;
	}
}

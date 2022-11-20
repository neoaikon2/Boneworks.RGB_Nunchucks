using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class WhaleHealth : MonoBehaviour
	{
		public int health;
		public int size;
		public GameObject bloodObject;
		public WhalingControl wControl;
		public Image blowHole;
		public Transform gameScreen;
		public Animator anim;
		public Image image;
		public Sprite deadSprite;
		public Color bloodColor;
		public Image bloodImage;
	}
}

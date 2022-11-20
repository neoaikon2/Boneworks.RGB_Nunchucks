using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class PizzaPerson : MonoBehaviour
	{
		public PizzaBoyControl pizzaBoyController;
		public Sprite ogSprite;
		public Sprite killedSprite;
		public Sprite fallenSprite;
		public GameObject bloodObject;
		public Image image;
		public float speed;
		public Vector2 startPos;
	}
}

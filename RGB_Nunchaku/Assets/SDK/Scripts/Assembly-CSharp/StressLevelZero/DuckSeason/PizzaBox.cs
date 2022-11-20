using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class PizzaBox : MonoBehaviour
	{
		public PizzaBoyControl pizzaBoyController;
		public GameObject pizzaBoy;
		public GameObject topMostParent;
		public Sprite ogSprite;
		public Sprite hitSprite;
		public float speed;
		public bool rtThrow;
		public bool moving;
	}
}

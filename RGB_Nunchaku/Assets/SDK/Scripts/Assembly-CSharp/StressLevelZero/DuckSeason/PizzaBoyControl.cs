using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class PizzaBoyControl : TelevisionChannel
	{
		public GameObject titleScreen;
		public GameObject streetScroller;
		public GameObject gameOverScreen;
		public GameObject gameOverFired;
		public GameObject gameWinScreen;
		public Transform pizzaBoy;
		public Transform targ;
		public PizzaBox[] pizzaBoxes;
		public GameObject[] pizzaPersons;
		public GameObject[] policeCars;
		public Text scoreText;
		public AudioClip clip_splat;
		public AudioClip clip_siren;
		public AudioClip clip_throw;
		public AudioClip clip_pizzaWhoosh;
		public AudioClip clip_hit;
		public AudioClip loopclip;
		public float speed;
		public bool gameIsPlaying;
		public LightgunChannel lightgunChannel;
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class GameTypeSelectChannel : TelevisionChannel
	{
		public GameMenuChannel gameMenuChannel;
		public GameObject[] TurnOffUI;
		public Button classicButton;
		public Button challengeButton;
		public Button timeTrialButton;
		public Button fatDuckButton;
		public Button ducksanityButton;
		public Button shuffleButton;
		public Text classicShadowText;
		public Text challengeShadowText;
		public Text timeTrialShadowText;
		public Text fatDuckShadowText;
		public Text ducksanityShadowText;
		public Text shuffleShadowText;
		public Text classicText;
		public Text challengeText;
		public Text timeTrialText;
		public Text fatDuckText;
		public Text ducksanityText;
		public Text shuffleText;
		public AudioClip selectClip;
	}
}

using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class DifficultySelectChannel : TelevisionChannel
	{
		public GameMenuChannel gameMenuChannel;
		public GameObject[] TurnOffUI;
		public Button easyButton;
		public Button mediumButton;
		public Button hardButton;
		public Text easyShadowText;
		public Text mediumShadowText;
		public Text hardShadowText;
		public Text easyText;
		public Text mediumText;
		public Text hardText;
		public AudioClip selectClip;
	}
}

using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class TelevisionChannelManager : MonoBehaviour
	{
		public enum Type
		{
			OFF = 0,
			GAMEINTRO = 1,
			VIDEO = 2,
			VIDEOLOOP = 3,
			VIDEOCAM = 4,
			GAMEMENU = 5,
			GAMEOPTIONS = 6,
			GAMEOPTIONSTITLE = 7,
			CONFIRMMODAL = 8,
			GAMECREDITS = 9,
			INFOMERCIAL = 10,
			DUCKDROPOFF = 11,
			FINALFIESTA = 12,
			HOVERJUNKERS = 13,
			BATTLEBROS = 14,
			SINATRA = 15,
			GHOULS = 16,
			TRIPLETIGER = 17,
			WHALING = 18,
			PIZZABOY = 19,
			DIFFICULTYSELECT = 20,
			LIGHTGUN = 21,
			DOGDANCE = 22,
			DESSERTBOSS = 23,
			GAMETYPESELECT = 24,
		}

		public AudioSource tvAudioSource;
		public TelevisionChannel cGameBackground;
		public TelevisionChannel cGameOptions;
		public TelevisionChannel cGameOptionsTitle;
		public TelevisionChannel cConfirmModal;
		public TelevisionChannel cGameCredits;
		public TelevisionChannel cGameMenu;
		public TelevisionChannel cGameIntro;
		public TelevisionChannel cVideos;
		public TelevisionChannel cLightgun;
		public TelevisionChannel cInfomercial;
		public TelevisionChannel cOff;
		public TelevisionChannel cVideoCam;
		public TelevisionChannel cDuckDropOff;
		public TelevisionChannel cFinalFiesta;
		public TelevisionChannel cHoverJunkers;
		public TelevisionChannel cBattleBros;
		public TelevisionChannel cSinatra;
		public TelevisionChannel cGhouls;
		public TelevisionChannel cTripleTiger;
		public TelevisionChannel cWhaling;
		public TelevisionChannel cPizzaBoy;
		public TelevisionChannel cDifficultySelect;
		public TelevisionChannel cDogDance;
		public TelevisionChannel cDogDanceOverlay;
		public TelevisionChannel cDessertBoss;
		public TelevisionChannel cGameTypeSelect;
	}
}

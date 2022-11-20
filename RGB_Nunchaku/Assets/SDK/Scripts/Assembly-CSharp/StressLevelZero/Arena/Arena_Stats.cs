using UnityEngine;

namespace StressLevelZero.Arena
{
	public class Arena_Stats : MonoBehaviour
	{
		public bool visDebug;
		[SerializeField]
		//private Data_Manager bwDataManager;
		public Arena_DataManager arena_DataManager;
		public Arena_DataPlayer arenaDataPlayer;
		public Control_UI_Arena controlUI;
		public Arena_Stats_UI_Display statsDisplay;
	}
}

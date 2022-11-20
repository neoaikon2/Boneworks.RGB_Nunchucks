using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class ConfirmModalChannel : TelevisionChannel
	{
		public TelevisionChannelManager.Type returnChannel;
		public Text modalText;
		public Text modalTextShadow;
		public bool isOkay;
	}
}

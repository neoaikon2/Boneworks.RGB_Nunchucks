using UnityEngine;
using TMPro;

public class GameControl_Museum : GameControl
{
	//public Data_Manager dataManager;
	public DoorControl door_Archive;
	public GameObject[] archiveObjects;
	public GameObject textDisplay_UnderConstruction;
	public GameObject textDisplay_AnomalousObjects;
	public int clickedButtons_count;
	public int clickedButtons_max;
	public TextMeshProUGUI txt_ButtonsClicked;
	public TextMeshProUGUI txt_ButtonsToClick;
}

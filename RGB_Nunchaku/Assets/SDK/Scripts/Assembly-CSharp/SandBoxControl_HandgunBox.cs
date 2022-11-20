using TMPro;
using StressLevelZero.Zones;
using StressLevelZero.Data;
using UnityEngine;

public class SandBoxControl_HandgunBox : GameControl
{
	public TextMeshProUGUI txt_Clock;
	public TextMeshProUGUI txt_Meridiem;
	public ZoneEncounter Encounter;
	public TextMeshProUGUI[] txt_Timer;
	public TextMeshProUGUI[] txt_Count;
	public TextMeshProUGUI[] txt_Timer_BEST;
	public TextMeshProUGUI[] txt_Timer_PREV;
	public TTTime ttTime;
	public GameObject victoryBanner;
	public SpawnableObject spawnable_tuscanyBoxModule;
	[SerializeField]
	private SpawnableObject tuscanyModuleObject;
	public GameObject obj_jumpToTimeTrial;
}

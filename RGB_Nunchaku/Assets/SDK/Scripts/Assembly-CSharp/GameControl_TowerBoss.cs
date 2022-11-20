using StressLevelZero.Zones;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.Playables;

public class GameControl_TowerBoss : GameControl
{
	//public Data_Manager dataManager;
	public ZoneSpawner[] throwSpawners;
	public ZoneSpawner[] noThrowSpawners;
	public ZoneSpawner[] crabSpawners;
	public UnityEvent OnStart;
	public UnityEvent OnFirstStageComplete;
	public UnityEvent OnSecondStageComplete;
	public UnityEvent OnThirdStageComplete;
	public UnityEvent OnFourthStageComplete;
	public UnityEvent OnEndComplete;
	public UnityEvent OnTeleportComplete;
	public AudioClip warpSound;
	public GameObject[] elevatorSteams;
	[SerializeField]
	private Renderer[] ScreenRenderers;
	[SerializeField]
	private PlayableDirector EndingDirector;
	[SerializeField]
	private Transform EndTeleportPoint;
}

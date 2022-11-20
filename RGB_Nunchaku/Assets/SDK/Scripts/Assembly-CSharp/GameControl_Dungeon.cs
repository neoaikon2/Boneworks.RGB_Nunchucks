using PuppetMasta;
using UnityEngine;
using StressLevelZero.Zones;

public class GameControl_Dungeon : GameControl
{
	public BehaviourPowerLegs GuardFord;
	public Transform mirrorTranPlayer;
	public Transform mirrorTranGuard;
	public ZoneSpawner[] barSpawners;
	public ZoneSpawner keySpawner;
	public SubBehaviourFaceanim.FaceEvent KeyFordEngaged;
	public SubBehaviourFaceanim.FaceEvent GuardMilestone1;
	public SubBehaviourFaceanim.FaceEvent GuardMilestone2;
	public SubBehaviourFaceanim.FaceEvent GuardMilestone3;
	public SubBehaviourFaceanim.FaceEvent GuardMilestone4;
	public SubBehaviourFaceanim.FaceEvent GuardMilestone5;
	public SubBehaviourFaceanim.FaceEvent GuardMilestone6;
	public SubBehaviourFaceanim.FaceEvent GuardMilestone7;
	public SubBehaviourFaceanim.FaceEvent GuardEscape;
}

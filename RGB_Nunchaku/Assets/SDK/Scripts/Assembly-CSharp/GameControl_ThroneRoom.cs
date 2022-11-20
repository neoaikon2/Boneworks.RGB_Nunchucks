using PuppetMasta;
using StressLevelZero.Interaction;
using StressLevelZero.Zones;
using StressLevelZero.SFX;
using UnityEngine.Video;
using StressLevelZero.Pool;

public class GameControl_ThroneRoom : GameControl
{
	public BehaviourPowerLegs GateKingFord;
	public BehaviourPowerLegs KingFord;
	public ForcePullGrip crownForcePull;
	public SubBehaviourFaceanim.FaceEvent KingEnterCourtyard;
	public SubBehaviourFaceanim.FaceEvent KingEnterGreatHall;
	public SubBehaviourFaceanim.FaceEvent DonTheCrown;
	public SubBehaviourFaceanim.FaceEvent HeDidntHaveChance;
	public SubBehaviourFaceanim.FaceEvent ItWasWritten;
	public SubBehaviourFaceanim.FaceEvent NewKing;
	public SubBehaviourFaceanim.FaceEvent LeadUsIntoTheVoid;
	public DoorControl[] BacklabDoors;
	public ZoneSpawner[] KingsCourt;
	public TriggeredAudio crownVictoryMusic;
	public BehaviourVoidWatcher[] voidWatchers;
	public VideoPlayer video1;
	public VideoPlayer video2;
	public VideoPlayer video3;
	public ZoneSound musicKiller;
	public SimpleParticleSpawner[] confetti;
	public TriggeredAudio[] speakersTriumph;
}

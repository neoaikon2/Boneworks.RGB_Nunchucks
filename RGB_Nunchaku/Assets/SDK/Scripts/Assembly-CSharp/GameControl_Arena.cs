using PuppetMasta;
using UnityEngine;

public class GameControl_Arena : GameControl
{
	public BehaviourPowerLegs KingFord;
	public SubBehaviourFaceanim.FaceEvent KingEnterArena;
	public SubBehaviourFaceanim.FaceEvent KingCompleteArena;
	public SubBehaviourFaceanim.FaceEvent KingPositive1;
	public SubBehaviourFaceanim.FaceEvent KingPositive2;
	public SubBehaviourFaceanim.FaceEvent KingPositive3;
	public SubBehaviourFaceanim.FaceEvent KingPositive4;
	public SubBehaviourFaceanim.FaceEvent KingPositive5;
	public SubBehaviourFaceanim.FaceEvent KingNegative1;
	public SubBehaviourFaceanim.FaceEvent KingNegative2;
	public SubBehaviourFaceanim.FaceEvent KingNegative3;
	public SubBehaviourFaceanim.FaceEvent KingNegative4;
	public SubBehaviourFaceanim.FaceEvent KingNegative5;
	public bool isPlayingCrowd;
	public AudioClip crowdCheerLoop;
	public AudioClip[] crowdCheerClips;
	public AudioClip[] crowdNegClips;
	[SerializeField]
	private CrowdAnim[] crowdAnims;
}

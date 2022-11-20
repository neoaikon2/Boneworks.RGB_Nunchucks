using UnityEngine;
using StressLevelZero.Interaction;
using UnityEngine.Audio;
using StressLevelZero.VFX;

namespace StressLevelZero.Props.Weapons
{
	public class DevManipulatorGun : MonoBehaviour
	{
		public ConfigurableJoint slingBallJoint;
		public Grip triggerGrip;
		public Grip ballGrip;
		public InteractableHost host;
		[SerializeField]
		private AudioClip _blastPistonOut;
		[SerializeField]
		private AudioClip _blastPistonIn;
		[SerializeField]
		private AudioMixerGroup _mixerGroup;
		public Transform slingSpringGroup;
		public GameObject ballArt;
		public GameObject ballArtLines;
		public Transform firePoint;
		public GravityManipulatorJob gravityManipulator;
		public QuadLine quadline;
		public GameObject blastVFXObject;
		public Transform fanBladesTransform;
		public Transform gaugeArrow;
		public PrismaticSFX ballPrismatic;
	}
}

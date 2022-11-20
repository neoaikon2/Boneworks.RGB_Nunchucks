using UnityEngine;
using UnityEngine.Audio;
using StressLevelZero.Interaction;
using StressLevelZero.Props.Weapons;

namespace StressLevelZero.Props
{
	public class CoreBomb : MonoBehaviour
	{
		public Color defaultColor;
		public Color hotColor;
		public AudioMixerGroup outputMixer;
		public AudioClip strongHitClip;
		public AudioClip unstableLoopClip;
		public float duration;
		public float cooldown;
		public MeshRenderer meshRenderer;
		public Grip grip;
		public Rigidbody rb;
		public GravityManipulatorJob gravityManipulator;
	}
}

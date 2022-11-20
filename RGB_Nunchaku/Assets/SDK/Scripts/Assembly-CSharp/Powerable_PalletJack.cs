using UnityEngine;
using StressLevelZero.Interaction;
using UnityEngine.Audio;

public class Powerable_PalletJack : Powerable
{
	[SerializeField]
	private ConfigurableJoint _pivotjnt;
	[SerializeField]
	private ConfigurableJoint[] _wheelJnts;
	[SerializeField]
	private Grip _handleGrip;
	[SerializeField]
	private AudioClip _soundUp;
	[SerializeField]
	private AudioClip _soundDown;
	[SerializeField]
	private AudioMixerGroup _mixerGroup;
}

using UnityEngine;
using StressLevelZero.SFX;

public class Powerable_ParticleManager : Powerable
{
	public float map_low;
	public float map_high;
	[SerializeField]
	public float Thickness;
	[SerializeField]
	public float OutputSpeed;
	[SerializeField]
	private float MinParticleCount;
	public AmbientSFX ambientSound;
	[SerializeField]
	private ParticleSystem sourcePSystem;
}

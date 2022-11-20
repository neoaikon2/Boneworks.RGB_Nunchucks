using UnityEngine;

public class ZombieDamageReciever : MonoBehaviour
{
	public enum BodyPart
	{
		HEAD = 1,
		BODY = 2,
		LEFTARM = 4,
		LEFTHAND = 8,
		LEFTLEG = 16,
		LEFTFOOT = 32,
		RIGHTARM = 64,
		RIGHTHAND = 128,
		RIGHTLEG = 256,
		RIGHTFOOT = 512,
	}

	public BodyPart bodyPart;
	public ZombieAI zombie;
}

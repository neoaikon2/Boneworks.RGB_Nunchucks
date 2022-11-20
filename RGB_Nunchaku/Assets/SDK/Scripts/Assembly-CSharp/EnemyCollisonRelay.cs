using UnityEngine;

public class EnemyCollisonRelay : MonoBehaviour
{
	public enum BodyPart
	{
		Head = 1,
		Chest = 2,
		Pelvis = 4,
		LeftArm = 8,
		LeftLeg = 16,
		RightArm = 32,
		RightLeg = 64,
	}

	public BodyPart bodyPart;
	public Enemy_Health e_health;
}

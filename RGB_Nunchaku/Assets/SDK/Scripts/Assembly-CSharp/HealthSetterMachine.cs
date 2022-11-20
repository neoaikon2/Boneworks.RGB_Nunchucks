using UnityEngine;
using TMPro;

public class HealthSetterMachine : MonoBehaviour
{
	public Player_Health player_Health;
	public float allowed_max_health;
	public float allowed_min_health;
	public float default_health;
	public bool instantDeath;
	public TextMeshPro text_Immortal;
	public TextMeshPro text_Death;
	public TextMeshPro text_Health;
}

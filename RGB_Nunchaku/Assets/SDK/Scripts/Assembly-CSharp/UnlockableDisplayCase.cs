using UnityEngine;
using TMPro;
using StressLevelZero.Data;

public class UnlockableDisplayCase : MonoBehaviour
{
	public TextMeshProUGUI txt_melee;
	public TextMeshProUGUI txt_ranged;
	public TextMeshProUGUI txt_fantasy;
	public TextMeshProUGUI txt_misc;
	public TextMeshProUGUI txt_physics;
	public TextMeshProUGUI txt_enemies;
	public GameObject[] image_melee;
	public GameObject[] image_ranged;
	public GameObject[] image_fantasy;
	public GameObject[] image_misc;
	public GameObject[] image_physics;
	public GameObject[] image_enemies;
	public SpawnableObject[] spawn_melee;
	public SpawnableObject[] spawn_ranged;
	public SpawnableObject[] spawn_fantasy;
	public SpawnableObject[] spawn_misc;
	public SpawnableObject[] spawn_physics;
	public SpawnableObject[] spawn_enemies;
}

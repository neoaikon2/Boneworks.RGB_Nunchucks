using UnityEngine;
using TMPro;

public class HallwayManager : MonoBehaviour
{
	[SerializeField]
	private float timeElapsed;
	[SerializeField]
	private int enemiesKilled;
	[SerializeField]
	private Light[] lightArray;
	[SerializeField]
	private Color darkLightTint;
	[SerializeField]
	private GameObject voidEffect;
	[SerializeField]
	private AudioClip startGameClip;
	[SerializeField]
	private TMP_Text timeText;
	[SerializeField]
	private TMP_Text killsText;
}

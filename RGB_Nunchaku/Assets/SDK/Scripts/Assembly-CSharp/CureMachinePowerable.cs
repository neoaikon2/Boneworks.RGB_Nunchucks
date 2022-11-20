using System.Collections.Generic;
using UnityEngine;
using PuppetMasta;
using StressLevelZero.Data;
using TMPro;
using StressLevelZero.SFX;
using StressLevelZero.Interaction;

public class CureMachinePowerable : Powerable
{
	[SerializeField]
	private List<CuredBrett> curedEnemyList;
	[SerializeField]
	private SubBehaviourFaceanim.FaceEvent[] curedFaceEvents;
	[SerializeField]
	private SubBehaviourFaceanim.FaceEvent[] gameOverFaceEvents;
	[SerializeField]
	private int currBatteries;
	[SerializeField]
	private int totalBatteries;
	public int remainingBatteries;
	public float percentageComplete;
	[SerializeField]
	private GameObject[] batteryObjs;
	[SerializeField]
	private List<Transform> batterySpawns;
	[SerializeField]
	private List<Transform> easySpawns;
	[SerializeField]
	private List<Transform> medSpawns;
	[SerializeField]
	private List<Transform> hardSpawns;
	[SerializeField]
	private GameObject batteryLightObj;
	[SerializeField]
	private SpawnableObject friendlyFordSpawnableObject;
	[SerializeField]
	private SpawnableObject nullRatSpawnableObject;
	[SerializeField]
	private GameObject butterflyPrefab;
	[SerializeField]
	private Transform needleTip;
	[SerializeField]
	private List<Vector3> linePoints;
	[SerializeField]
	private Vector3 point1;
	[SerializeField]
	private Vector3 point2;
	[SerializeField]
	private Vector3 point3;
	[SerializeField]
	private Vector3 point4;
	[SerializeField]
	private GameObject batteryTextParent;
	[SerializeField]
	private TMP_Text batteryText;
	[SerializeField]
	private HeadSFX headSFX;
	[SerializeField]
	private AudioClip winClip;
	[SerializeField]
	private AudioClip confettiClip;
	[SerializeField]
	private AudioClip machineClip;
	[SerializeField]
	private AudioClip cureClip;
	[SerializeField]
	private Control_GlobalTime globalTimeControl;
	[SerializeField]
	private Grip[] _grips;
	[SerializeField]
	private GameObject glowOrbObject;
	[SerializeField]
	private GameObject moveCylinderObj;
	[SerializeField]
	private GameObject[] glassObjs;
	[SerializeField]
	private ElectricInteractionVolume[] batteryVols;
	[SerializeField]
	private LightControlPowerable leverLightControl;
	[SerializeField]
	private GameObject leverObj;
	public bool isCuring;
}

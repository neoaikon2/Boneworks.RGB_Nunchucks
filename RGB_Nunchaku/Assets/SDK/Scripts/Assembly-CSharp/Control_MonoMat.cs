using UnityEngine;
using TMPro;
using StressLevelZero.Interaction;
using StressLevelZero.Data;
using UnityEngine.Audio;

public class Control_MonoMat : Powerable
{
	[SerializeField]
	private Rigidbody[] _loots;
	[SerializeField]
	private Control_PowerLever _doorLever;
	[SerializeField]
	private Powerable _doorMotor;
	[SerializeField]
	private int _multiplier;
	[SerializeField]
	private int _itemPrice;
	[SerializeField]
	private int _smallBullets;
	[SerializeField]
	private int _mediumBullets;
	[SerializeField]
	private bool _opened;
	[SerializeField]
	private bool _unlocked;
	[SerializeField]
	private TextMeshProUGUI _bulletBalanceTextmesh;
	[SerializeField]
	private TextMeshProUGUI _refundTextmesh;
	[SerializeField]
	private AmmoReciever reciever;
	[SerializeField]
	private SpawnableObject lightRefundSpawn;
	[SerializeField]
	private SpawnableObject mediumRefundSpawn;
	[SerializeField]
	private AudioClip _openedClip;
	[SerializeField]
	private AudioClip _unlockedClip;
	[SerializeField]
	private AudioClip _lockedClip;
	[SerializeField]
	private AudioMixerGroup _mixergroup;
	public Transform giveChangeTransform;
}

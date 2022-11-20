using UnityEngine;

public class ItemStats : MonoBehaviour
{
	private enum ItemType
	{
		CONSUMABLE = 0,
		HANDGUN = 1,
		SUBMACHINE = 2,
		AR = 3,
		SNIPER = 4,
	}

	[SerializeField]
	private ItemType m_itemType;
	[SerializeField]
	private float m_minConsume;
	[SerializeField]
	private float m_minHandGun;
	[SerializeField]
	private float m_minSubGun;
	[SerializeField]
	private float m_minAR;
	[SerializeField]
	private float m_minSniper;
	[SerializeField]
	private float m_maxScale;
	[SerializeField]
	private float m_scaleSpeed;
	[SerializeField]
	private int x;
	[SerializeField]
	private int y;
	[SerializeField]
	private bool m_placed;
	public bool CantPlace;
	public bool PlayedSound;
	[SerializeField]
	private string m_itemName;
	[SerializeField]
	private Item m_item;
}

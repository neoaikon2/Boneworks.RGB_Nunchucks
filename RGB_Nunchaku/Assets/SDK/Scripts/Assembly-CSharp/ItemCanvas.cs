using UnityEngine;

public class ItemCanvas : MonoBehaviour
{
	public Inventory m_Inventory;
	[SerializeField]
	private GameObject m_inventorySlot;
	[SerializeField]
	private Transform m_parentTransform;
	[SerializeField]
	private LayerMask m_inventoryLayer;
	[SerializeField]
	private AudioClip m_audioClip;
}

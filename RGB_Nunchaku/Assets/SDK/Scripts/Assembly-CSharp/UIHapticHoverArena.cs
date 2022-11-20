using UnityEngine;
using StressLevelZero.UI;
using StressLevelZero.Arena;
using UnityEngine.UI;

public class UIHapticHoverArena : MonoBehaviour
{
	public Control_UI_InGameData uiControl;
	public int clickDown;
	public Control_UI_Arena arenaUIControl;
	public Arena_Challenge challenge;
	[SerializeField]
	private Image spriteImage;
	public Sprite lockedSprite;
}

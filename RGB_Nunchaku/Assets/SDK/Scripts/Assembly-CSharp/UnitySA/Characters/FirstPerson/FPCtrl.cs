using UnityEngine;
using UnitySA.Utility;

namespace UnitySA.Characters.FirstPerson
{
	public class FPCtrl : MonoBehaviour
	{
		[SerializeField]
		private bool m_IsWalking;
		[SerializeField]
		private float m_WalkSpeed;
		[SerializeField]
		private float m_RunSpeed;
		[SerializeField]
		private float m_RunstepLenghten;
		[SerializeField]
		private float m_JumpSpeed;
		[SerializeField]
		private float m_StickToGroundForce;
		[SerializeField]
		private float m_GravityMultiplier;
		[SerializeField]
		private MLook m_MouseLook;
		[SerializeField]
		private bool m_UseFovKick;
		[SerializeField]
		private FOVZoom m_FovKick;
		[SerializeField]
		private bool m_UseHeadBob;
		[SerializeField]
		private CurveCtrlBob m_HeadBob;
		[SerializeField]
		private LerpCtrlBob m_JumpBob;
		[SerializeField]
		private float m_StepInterval;
	}
}

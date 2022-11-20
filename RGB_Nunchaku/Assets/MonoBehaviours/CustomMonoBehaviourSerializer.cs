using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Whenever you need a custom monobehaviour on a gameobject, use this.
/// </summary>
[RequireComponent(typeof(LocalizedText))]
public class CustomMonoBehaviourSerializer : MonoBehaviour
{
    public MonoBehaviour classToSerialize;
    public LocalizedText localizedText;
}
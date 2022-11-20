using StressLevelZero.Data;
using StressLevelZero.Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Newtonsoft.Json;
using System.Reflection;
using UnityEngine.SceneManagement;

[CustomEditor(typeof(CustomItems))]
public class CustomItemsInspector : Editor
{
    public override void OnInspectorGUI()
    {
        #region Script Header
        GUI.enabled = false;
        EditorGUILayout.ObjectField("Script", MonoScript.FromMonoBehaviour((CustomItems)target), typeof(CustomItems), false);
        GUI.enabled = true;
        #endregion

        SerializedProperty settingsProp = serializedObject.FindProperty("settings");

        if (GUILayout.Button("Populate Items"))
        {
            Transform targetTransform = (target as CustomItems).transform;
            List<CustomItems.ItemSettings.Item> items = new List<CustomItems.ItemSettings.Item>();
            for (int i = 0; i < targetTransform.childCount; i++)
            {
                CustomItems.ItemSettings.Item item = new CustomItems.ItemSettings.Item()
                {
                    name = targetTransform.GetChild(i).name,
                    category = CategoryFilters.PROPS,
                    poolMode = PoolMode.REUSEOLDEST,
                    pooledAmount = 10,
                    hideInMenu = false
                };
                items.Add(item);
            }

            SerializedProperty itemsListProp = settingsProp.FindPropertyRelative("items");
            itemsListProp.arraySize = items.Count;
            for (int i = 0; i < items.Count; i++)
            {
                SetItemPropertyValues(itemsListProp.GetArrayElementAtIndex(i), items[i]);
            }
        }

        if (GUILayout.Button("Apply Settings"))
        {
            // https://forum.unity.com/threads/get-a-general-object-value-from-serializedproperty.327098/

            Object targetObject = settingsProp.serializedObject.targetObject;
            System.Type targetObjectClassType = targetObject.GetType();
            FieldInfo field = targetObjectClassType.GetField(settingsProp.propertyPath);
            if (field != null)
            {
                CustomItems.ItemSettings settings = field.GetValue(targetObject) as CustomItems.ItemSettings;
                string json = JsonConvert.SerializeObject(settings);
                GameObject targetGO = (target as CustomItems).gameObject;
                targetGO.GetComponent<LocalizedText>().key = json;
                EditorUtility.SetDirty(targetGO);
                PrefabUtility.RecordPrefabInstancePropertyModifications(targetGO.GetComponent<LocalizedText>());
            }
            else
            {
                Debug.LogError("Couldn't deserialize ItemSettings object.");
            }
        }

        EditorGUILayout.PropertyField(settingsProp, true);
        serializedObject.ApplyModifiedProperties();
    }

    private void SetItemPropertyValues(SerializedProperty prop, CustomItems.ItemSettings.Item item)
    {
        prop.FindPropertyRelative("name").stringValue = item.name;
        prop.FindPropertyRelative("category").enumValueIndex = (int)item.category + 1; // Add 1 because the enum starts at -1. THE SLZ METHOD.
        prop.FindPropertyRelative("poolMode").enumValueIndex = (int)item.poolMode;
        prop.FindPropertyRelative("pooledAmount").intValue = item.pooledAmount;
        prop.FindPropertyRelative("hideInMenu").boolValue = item.hideInMenu;
    }
}

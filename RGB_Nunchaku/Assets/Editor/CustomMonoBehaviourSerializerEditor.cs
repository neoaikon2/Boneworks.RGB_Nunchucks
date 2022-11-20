using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Newtonsoft.Json;
using System;
using System.Reflection;

[CustomEditor(typeof(CustomMonoBehaviourSerializer))]
public class CustomMonoBehaviourSerializerEditor : Editor
{
    private static readonly string splitter = "-::-";

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("Serialize Class"))
        {
            CustomMonoBehaviourSerializer cmbs = target as CustomMonoBehaviourSerializer;
            GameObject targetGO = cmbs.gameObject;
            if (cmbs.localizedText == null)
            {
                LocalizedText[] localizedTexts = targetGO.GetComponents<LocalizedText>();
                CustomMonoBehaviourSerializer[] customMonoBehaviourSerializers = targetGO.GetComponents<CustomMonoBehaviourSerializer>();
                foreach (LocalizedText t in localizedTexts)
                {
                    bool isUsed = false;
                    foreach (CustomMonoBehaviourSerializer c in customMonoBehaviourSerializers)
                    {
                        if (c.localizedText != null && c.localizedText.GetInstanceID() == t.GetInstanceID())
                            isUsed = true;
                    }

                    if (!isUsed)
                    {
                        cmbs.localizedText = t;
                        break;
                    }
                }

                if (cmbs.localizedText == null)
                    cmbs.localizedText = targetGO.AddComponent<LocalizedText>();
            }


            Type type = cmbs.classToSerialize.GetType();

            Dictionary<string, object> values = new Dictionary<string, object>();
            foreach (FieldInfo field in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
            {
                values.Add(field.Name, field.GetValue(cmbs.classToSerialize));
            }

            string json = JsonConvert.SerializeObject(values, new JsonSerializerSettings() { MaxDepth = 1, ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
            string fullText = $"CUSTOM_MONOBEHAVIOUR{splitter}{type.FullName}{splitter}{json}";

            if (cmbs.localizedText == null)
                Debug.LogError("CustomMonoBehaviourSerializer must have a LocalizedText assigned to it.");
            else
                cmbs.localizedText.key = fullText;
            //targetGO.GetComponent<LocalizedText>().key = fullText;

            EditorUtility.SetDirty(targetGO);
            PrefabUtility.RecordPrefabInstancePropertyModifications(targetGO.GetComponent<LocalizedText>());
        }
    }
}

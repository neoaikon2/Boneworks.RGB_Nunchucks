using UnityEngine;
using UnityEditor;
using StressLevelZero.Data;
using System;
using System.Collections.Generic;
using System.IO;

public class CustomItemsEditor : EditorWindow
{
    Vector2 scrollPos;
    GUIStyle wrapTextStyle = new GUIStyle();

    private string settingsItemName = "ItemSettings";
    private string categoryRootName = "Category";
    private string poolAmountRootName = "PoolAmount";
    private string hideInMenuName = "HideInMenu";

    public ItemSettings[] itemSettings;


    [MenuItem("CustomItems/Item Settings")]
    public static void ShowWindow()
    {
        GetWindow<CustomItemsEditor>("Item Settings");
    }

    [MenuItem("CustomItems/Create CustomItems Object")]
    public static void CreateCustomItemsObject()
    {
        GameObject customItems = new GameObject("CustomItems");
        Selection.activeGameObject = customItems;
    }

    [MenuItem("CustomItems/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        string assetBundleDirectory = "Assets/AssetBundles";
        Directory.CreateDirectory(assetBundleDirectory);
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
    }

    private void OnGUI()
    {
        //Set up window so a scrollbar is created when needed
        EditorGUILayout.BeginVertical();
        scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

        wrapTextStyle.wordWrap = true;
        wrapTextStyle.fontSize = 14;
        wrapTextStyle.fontStyle = FontStyle.Bold;
        wrapTextStyle.normal.textColor = new Color(45 / 255f, 155 / 255f, 161 / 255f, 1f);
        wrapTextStyle.padding = new RectOffset(5, 5, 2, 0);

        EditorGUILayout.LabelField("Settings are gotten from and applied to the selected CustomItems object.", wrapTextStyle);

        EditorGUILayout.Space();

        if (GUILayout.Button("Get Default Settings"))
        {
            GameObject selectedObj = Selection.activeGameObject;
            if (NotValidCustomItems(selectedObj))
                Debug.Log("Select a CustomItems object in the hierarchy");
            else
                itemSettings = GetDefaultSettings(selectedObj);
        }

        if (GUILayout.Button("Get Existing Settings"))
        {
            GameObject selectedObj = Selection.activeGameObject;
            if (NotValidCustomItems(selectedObj))
                Debug.Log("Select a CustomItems object in the hierarchy");
            else
                itemSettings = GetExistingSettings(selectedObj);
        }

        if(GUILayout.Button("Get Existing and Default Settings"))
        {
            GameObject selectedObj = Selection.activeGameObject;
            if (NotValidCustomItems(selectedObj))
                Debug.Log("Select a CustomItems object in the hierarchy");
            else
                itemSettings = GetBothSettings(selectedObj);
        }

        if (GUILayout.Button("Apply Settings"))
        {
            GameObject selectedObj = Selection.activeGameObject;
            if (NotValidCustomItems(selectedObj))
                Debug.Log("Select a CustomItems object in the hierarchy");
            else
                ApplyCurrentSettings(selectedObj);
        }

        EditorGUILayout.Space();

        //Get the item settings array
        ScriptableObject scriptableObj = this;
        SerializedObject serializedObj = new SerializedObject(scriptableObj);
        SerializedProperty serializedProp = serializedObj.FindProperty("itemSettings");

        //Display the array
        EditorGUILayout.PropertyField(serializedProp, true);
        serializedObj.ApplyModifiedProperties();


        //Add some padding at the bottom of the window
        EditorGUILayout.Space();

        //Stop the scrollbar
        EditorGUILayout.EndScrollView();
        EditorGUILayout.EndVertical();

    }

    private void ApplyCurrentSettings(GameObject customItems)
    {
        if(itemSettings.Length == 0)
        {
            Debug.Log("No settings to apply");
            return;
        }

        Transform settingsObj = customItems.transform.Find(settingsItemName);
        if(settingsObj == null)
        {
            settingsObj = new GameObject(settingsItemName).transform;
            settingsObj.parent = customItems.transform;
        }

        //Clear the settings
        for (int i = settingsObj.childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(settingsObj.GetChild(i).gameObject, false);
        }

        for (int i = 0; i < itemSettings.Length; i++)
        {
            //Create the root settings object for this item
            Transform itemSettingsRoot = new GameObject(itemSettings[i].nameInHierarchy).transform;

            //Maybe create HideInMenu object
            if (itemSettings[i].hideInMenu)
            {
                Transform hideInMenu = new GameObject(hideInMenuName).transform;
                hideInMenu.parent = itemSettingsRoot;
            }

            //Create all the other objects
            Transform categorySettingsRoot = new GameObject(categoryRootName).transform;
            Transform categorySettingsChild = new GameObject(Convert.ToInt32(itemSettings[i].category).ToString()).transform;

            Transform poolAmountSettingsRoot = new GameObject(poolAmountRootName).transform;
            Transform poolAmountSettingsChild = new GameObject(itemSettings[i].poolAmount.ToString()).transform;

            //Assign parents
            itemSettingsRoot.parent = settingsObj;

            categorySettingsRoot.parent = itemSettingsRoot;
            poolAmountSettingsRoot.parent = itemSettingsRoot;

            categorySettingsChild.parent = categorySettingsRoot;
            poolAmountSettingsChild.parent = poolAmountSettingsRoot;
        }

        //Apply the changes if in prefab mode
        EditorUtility.SetDirty(customItems);
    }

    private ItemSettings[] GetBothSettings(GameObject customItems)
    {
        ItemSettings[] existingSettings = GetExistingSettings(customItems);
        ItemSettings[] newSettings = GetDefaultSettings(customItems);

        for (int i = 0; i < newSettings.Length; i++)
        {
            for (int j = 0; j < existingSettings.Length; j++)
            {
                if (newSettings[i].nameInHierarchy == existingSettings[j].nameInHierarchy)
                    newSettings[i] = existingSettings[j];
            }
        }

        return newSettings;
    }

    private ItemSettings[] GetDefaultSettings(GameObject customItems)
    {
        //Get all the custom item objects
        List<Transform> items = new List<Transform>();
        for (int i = 0; i < customItems.transform.childCount; i++)
        {
            Transform child = customItems.transform.GetChild(i);
            if (child.name != settingsItemName)
                items.Add(child);
        }

        //Set up default settings for them
        ItemSettings[] newSettings = new ItemSettings[items.Count];
        for (int i = 0; i < newSettings.Length; i++)
        {
            newSettings[i].nameInHierarchy = items[i].name;
            newSettings[i].hideInMenu = false;
            newSettings[i].category = CategoryFilters.PROPS;
            newSettings[i].poolAmount = 10;
        }

        return newSettings;
    }

    private ItemSettings[] GetExistingSettings(GameObject customItems)
    {
        //Find the ItemSettings object and initialize the settings array with the child count
        Transform settingsObj = customItems.transform.Find(settingsItemName);
        if (settingsObj == null)
        {
            Debug.Log("No existing settings found.");
            return new ItemSettings[0];
        }

        int itemSettingsCount = settingsObj.childCount;
        if(itemSettingsCount == 0)
        {
            Debug.Log("No existing settings found.");
            return new ItemSettings[0];
        }

        ItemSettings[] newSettings = new ItemSettings[itemSettingsCount];

        //Read the settings from each object
        for (int i = 0; i < itemSettingsCount; i++)
        {
            Transform currentObj = settingsObj.GetChild(i);
            newSettings[i].nameInHierarchy = currentObj.name;
            newSettings[i].hideInMenu = currentObj.Find(hideInMenuName) != null;
            newSettings[i].category = (CategoryFilters)Convert.ToInt32(currentObj.Find(categoryRootName).GetChild(0).name);
            newSettings[i].poolAmount = Convert.ToInt32(currentObj.Find(poolAmountRootName).GetChild(0).name);
        }

        return newSettings;
    }

    private static bool NotValidCustomItems(GameObject selectedObj)
    {
        return selectedObj == null || selectedObj.name != "CustomItems" || !selectedObj.scene.IsValid();
    }

    [Serializable]
    public struct ItemSettings
    {
        public string nameInHierarchy;
        public bool hideInMenu;
        public CategoryFilters category;

        [Range(2, 1000)]
        public int poolAmount;

    }
}

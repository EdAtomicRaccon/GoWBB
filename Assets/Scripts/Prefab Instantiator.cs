using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PrefabInstantiator : EditorWindow {

    private Texture platefrome1616icon;
    private bool instantiateAtZero = false;

    [MenuItem("Prefabs/Instantiate")]
    static void Init()
    {
        PrefabInstantiator prefabInstantiator = (PrefabInstantiator)EditorWindow.GetWindow(typeof(PrefabInstantiator));
        prefabInstantiator.Show();
        
    }

    void OnGUI() {
        platefrome1616icon = Resources.Load("icon") as Texture;

        instantiateAtZero = GUILayout.Toggle(instantiateAtZero, "Instantiate at zero");

        if (GUILayout.Button(platefrome1616icon)) {
            InstantiatePlaltform1616();
        }
    }

    void InstantiatePlaltform1616() {
        GameObject plateforme1616 = (GameObject)Resources.Load("Plateforme1616");
        Instantiate(plateforme1616, Vector3.zero, Quaternion.identity);
    }
}

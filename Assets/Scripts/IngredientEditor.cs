using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class IngredientEditor : EditorWindow {

    [MenuItem("Ingredient/CreateIngredient")]
	static void Init() {
        IngredientEditor ingredientEditor = (IngredientEditor)EditorWindow.GetWindow(typeof(IngredientEditor));
        ingredientEditor.Show();
	}

    private string ingredientName;
    private float craftingTime;
    private int tier;
    private int scorePoints;

    void OnGUI() {
        GUILayout.Label("New ingredient settings");
        GUILayout.Label("Ingredient name");
        ingredientName = EditorGUILayout.TextField(ingredientName);
        GUILayout.Label("Crafting time");
        craftingTime = EditorGUILayout.FloatField(craftingTime);
        GUILayout.Label("Tier");
        tier = EditorGUILayout.IntField(tier);
        GUILayout.Label("Scrore points");
        scorePoints = EditorGUILayout.IntField(scorePoints);

        if (GUILayout.Button("Save ingredient")) {
            SaveIngredientAsSO();
        }
    }

    private void SaveIngredientAsSO() {
        IngredientSO ingredientSO = (IngredientSO)CreateInstance(typeof(IngredientSO));
        ingredientSO.ingredientName = ingredientName;
        ingredientSO.craftingTime = craftingTime;
        ingredientSO.tier = tier;
        ingredientSO.scorePoints = scorePoints;

        AssetDatabase.CreateAsset(ingredientSO, "Assets/" + ingredientName + ".asset");
    }

}

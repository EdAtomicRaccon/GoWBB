using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

    

	public void Attack(string enemyName, float damage){
        Debug.Log(" just attacked " + enemyName + " with : " + damage + " damage");
    }

    bool isTrue = false;
    float toto = 0f;
    public void Attack(string enemy1Name, string enemy2Name, float damage) {
        if (isTrue)
        {
            toto = 3f;
        }
        else
            toto = 0f;

        toto = ((isTrue) ? 3f : 0f)<1.5f ? 0f:3f;
    }

    private Coroutine timerCoroutine;

    void Start() {
         timerCoroutine = StartCoroutine(Timer(10f));
        Invoke("Event1", 40f);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.P)) {
            StopCoroutine(timerCoroutine);
        }
    }

    IEnumerator TestCoroutine(int numberOfLoops, float[] floatArray) {

        for (int i = 0; i < floatArray.Length; i++)
        {
            floatArray[i] = 0;
            yield return null;
        }

    }


    IEnumerator Timer(float roundTime)
    {
        float counter = 0f;

        while (counter < roundTime) {
            counter += Time.deltaTime;
            Debug.Log(counter);
            yield return null;
        }

        Debug.Log("Timer finished");
    }

    private void TestMethod(int numberOfLoops, float[] floatArray) {
        for (int i = 0; i < floatArray.Length; i++)
        {
            floatArray[i] = 0;
        }
    }

    public void GetDamage(string enemyName, float damage) {
        Debug.Log(enemyName + " just attacked " + " with : " + damage + " damage");
    }
}

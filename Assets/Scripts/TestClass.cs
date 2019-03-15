using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestClass : MonoBehaviour {

    private Vector3 myVector3;
    private Quaternion myQuaternion;

    private Quaternion[] myQuaternionArray;
    private List<Quaternion> myQuaternionList;
    public Dictionary<string, Quaternion> myQuaternionDictionnary;

    [SerializeField] private int my_int;

    private int MyFunction(Vector3Int myVector3) {
        int sum = 0;
        sum = myVector3.x + myVector3.y + myVector3.z;

        return sum;
    }

    private Vector3 Vector3Sum(Vector3 firstVector3, Vector3 secondVector3) {       
        return firstVector3 + secondVector3;
    }


	// Use this for initialization
	void Start () {
        //List<float> testList = new List<float> { 4f, 3.4f, 7.2f, 1f};
        float[] testArray = new float[] { 4f, 3.4f, 7.2f, 1f};
        float[] testArray2 = new float[] { 4f, 3.4f, 7.2f, 1f, 5f, 6.1f, 8.9f};
        Debug.Log("result : " + Median(testArray2));
	}

    string ArrayToString(float[] _myArray) {
        string result = "";

        for (int i = 0; i < _myArray.Length; i++) {
            result += _myArray[i].ToString() + " ";
        }
        return result.Trim();
    }


    float Median(float[] values)
    {
        float result = 0f;

        float[] sortedArray = SortArray(values);

        if (values.Length % 2 == 1) {
            result = sortedArray[(values.Length - 1) / 2];
        }else{
            result = (sortedArray[values.Length / 2] + sortedArray[values.Length / 2 - 1]) / 2f;
        }

        return result;
    }

    float[] SortArray(float[] myArray) {
        float[] sortedArray = new float[myArray.Length];

        List<float> myListToSort = new List<float>();
        for (int i = 0; i < myArray.Length; i++) {
            myListToSort.Add(myArray[i]);
        }

        int increment = 0;
        while (myListToSort.Count >0) {
            float[] minAndMax = GetMinAndMax(myListToSort);

            sortedArray[increment] = minAndMax[0];
            sortedArray[sortedArray.Length - 1 - increment] = minAndMax[1];

            myListToSort.Remove(minAndMax[0]);
            myListToSort.Remove(minAndMax[1]);
            increment++;
        }


        return sortedArray;
    }

    float[] GetMinAndMax(List<float> myList) {
        float[] minAndMax = new float[2];

        float min = Mathf.Infinity;
        float max = Mathf.NegativeInfinity;
        for (int i = 0; i < myList.Count; i++) {
            if (myList[i] < min) {
                min = myList[i];
            }
            if (myList[i] > max) {
                max = myList[i];
            }
        }

        minAndMax[0] = min;
        minAndMax[1] = max;

        return minAndMax;
    }


    string[] StringArrayInverter(string[] myArray) {
        string[] resultArray = new string[myArray.Length];

        for (int i = 0; i < myArray.Length; i++) {
            resultArray[i] = myArray[myArray.Length - 1 - i];
        }

        return resultArray;
    }


}

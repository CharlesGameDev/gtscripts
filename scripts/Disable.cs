/*
 * Created by CharlesDevVR
 * More scripts at https://charlesgamedev.github.io/gtscripts
 * (c) 2023
*/ 

using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Disable : MonoBehaviour
{
    public string targetTag = "HandTag";
    public bool selectRandomly;
    public GameObject[] objectsToDisable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            if (selectRandomly) {
                go = objectsToDisable[Random.Range(0, objectsToDisable.Length)];
                go.SetActive(false);
                return;
            }
            foreach (GameObject go in objectsToDisable)
                go.SetActive(false);
        }
    }
}

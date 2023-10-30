/*
 * Created by CharlesDevVR
 * More scripts at https://charlesgamedev.github.io/gtscripts
 * (c) 2023
*/ 

using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Enable : MonoBehaviour
{
    public string targetTag = "HandTag";
    public bool selectRandomly;
    public GameObject[] objectsToEnable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            if (selectRandomly) {
                go = objectsToEnable[Random.Range(0, objectsToEnable.Length)];
                go.SetActive(true);
                return;
            }
            foreach (GameObject go in objectsToEnable)
                go.SetActive(true);
        }
    }
}

/*
 * Created by CharlesDevVR
 * More scripts at https://charlesgamedev.github.io/gtscripts
 * (c) 2023
*/

using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Hitsound : MonoBehaviour
{
    public string targetTag = "HandTag";
    public float maxHeardDistance = 30;
    public float volume = 0.5f;
    [Header("Add all of your hitsounds here.\nWhen hit, it will play one at random.")]
    public AudioClip[] hitSounds;
    AudioSource src;

    private void Awake()
    {
        src = gameObject.AddComponent<AudioSource>();
        src.playOnAwake = false;
        src.volume = volume;
        src.minDistance = 0;
        src.maxDistance = maxHeardDistance;
        src.rolloffMode = AudioRolloffMode.Linear;
        src.spatialBlend = 1;
        src.dopplerLevel = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag(targetTag))
        {
            AudioClip clip = hitSounds[Random.Range(0, hitSounds.Length)];
            src.PlayOneShot(clip);
        }
    }
}

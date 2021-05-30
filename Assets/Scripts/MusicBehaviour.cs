using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBehaviour : MonoBehaviour
{
    public static AudioClip finish;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        finish = Resources.Load<AudioClip>("alkis");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "alkis":
                audioSrc.PlayOneShot(finish);
                break;
            default:
                break;
        }
    }

}

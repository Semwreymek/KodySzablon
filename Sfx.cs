using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{
    public static AudioClip loli, sonik, marjoJ, marjoCoins, glosTeemo;
    static AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();

        loli = Resources.Load<AudioClip>("OniChan");
        sonik = Resources.Load<AudioClip>("Sonic");
        marjoJ = Resources.Load<AudioClip>("Mario");
        marjoCoins = Resources.Load<AudioClip>("Coinsy");
        glosTeemo = Resources.Load<AudioClip>("Timor");



    }

    static public void PlaySound(string klip)
    {
        switch (klip)
        {
            case "Onichan":
                audioSrc.PlayOneShot(loli);
                break;

            case "Sonic":
                audioSrc.PlayOneShot(sonik);
                break;

            case "Mario":
                audioSrc.PlayOneShot(marjoJ);
                break;

            case "Coinsy":
                audioSrc.PlayOneShot(marjoCoins);
                break;

            case "Timor":
                audioSrc.PlayOneShot(glosTeemo);
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scena2Reload : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Score.scoreValue = 0;
            SceneManager.LoadScene("SampleScene");
        }
    }
}

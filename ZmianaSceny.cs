using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZmianaSceny : MonoBehaviour
{

    public void ReloadSc2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }


    public void ZmianaScenyy(string nazwa)
    {
        SceneManager.LoadScene(nazwa);
    }

    public void Wyjdz()
    {
        Application.Quit();
    }


}

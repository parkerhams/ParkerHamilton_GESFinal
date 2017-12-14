using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMover : MonoBehaviour {
    ScreenFader fadeScr;
    //public int SceneNumb;

    void Awake()
    {
        fadeScr = GameObject.FindObjectOfType<ScreenFader>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //fadeScr.EndScene(SceneNumb);
            SceneManager.LoadScene("CreditsScreen");
        }
    }
    public void BeginButtonClicked()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void CreditsButtonClicked()
    {
        SceneManager.LoadScene("CreditsScreen");
    }

    public void TitleButtonClicked()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}

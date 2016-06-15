using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour {

    public bool onOptionClicked;

    GameObject canvas;

    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("MainScene_Canvas");
        if (canvas != null)
        {
            onOptionClicked = false;
            canvas.SetActive(onOptionClicked);
        }
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void OnOptionClick()
    {
        onOptionClicked = !onOptionClicked;
        if (canvas != null)
            canvas.SetActive(onOptionClicked);
        Debug.Log(onOptionClicked);
    }

    public void OnBackPressed()
    {
        switch (SceneManager.GetActiveScene().name/*EditorSceneManager.GetActiveScene().name*/)
        {
            case "MainScene":
                Application.Quit();
                break;
            case "GameScene":
                //EditorSceneManager.LoadScene("MainScene");
                SceneManager.LoadScene("MainScene");
                break;
        }
        Debug.Log("OnBackPressed");
    }
}

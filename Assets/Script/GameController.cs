using UnityEngine;
using UnityEngine.UI;
//using UnityEditor.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour {

    public bool onOptionClicked;

    GameObject canvas;
    Button backBtn;

    // Use this for initialization
    void Start () {
        canvas = GameObject.FindWithTag("MainScene_Canvas");
        backBtn = GameObject.FindWithTag("Back_key").GetComponent<Button>();
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
        switch (Application.loadedLevelName/*EditorSceneManager.GetActiveScene().name*/)
        {
            case "MainScene":
                Application.c
                break;
            case "GameScene":
                //EditorSceneManager.LoadScene("MainScene");
                Application.LoadLevelAdditive(0);
                break;
        }
        Debug.Log("OnBackPressed");
    }
}

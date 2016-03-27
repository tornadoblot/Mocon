using UnityEngine;
//using UnityEditor.SceneManagement;
using System.Collections;

public class GoStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position)))
            {
                //EditorSceneManager.LoadScene("GameScene");
                Application.LoadLevel("GameScene");
            }
        }
    }
}

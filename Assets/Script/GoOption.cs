using UnityEngine;
using System.Collections;

public class GoOption : MonoBehaviour {

    public GameController gameController;

	// Use this for initialization
	void Start () {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            if (gameController.onOptionClicked == true)
                gameController.OnOptionClick();
            else if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position)))
            {
                gameController.OnOptionClick();
            }
        }
    }
}

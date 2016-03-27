using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveEarth : MonoBehaviour {

    public float speed;
    Text UItext;

	// Use this for initialization
	void Start () {
        UItext = GameObject.Find("Show Speed").GetComponent<Text>();
        if (UItext != null)
            UItext.text = speed + "";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase != TouchPhase.Ended)
        {
            if (Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).x >= 0)
                gameObject.transform.Rotate(Vector3.back * speed * Time.deltaTime);
            else if (Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).x < 0)
                gameObject.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    public void speedUp()
    {
        speed++;
        if (UItext != null)
            UItext.text = speed + "";
    }

    public void speedDown()
    {
        speed--;
        if (UItext != null)
            UItext.text = speed + "";
    }

}

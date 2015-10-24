using UnityEngine;
using System.Collections;

public class GameExit : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	    
	}

    void fixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            Debug.Log("mouse released");
        }
    }

    public void OnClick()
    {
        //Application.Quit();
        
    }
}

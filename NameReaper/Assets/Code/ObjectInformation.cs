using UnityEngine;
using System.Collections;
using System;

public class ObjectInformation : MonoBehaviour {

    public string name = "";
    public float hitpoints = 99999;

    public bool hasWater = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(name);
            setRestState(typeof(Minnow_RestState));
        }
    }

    public void setRestState(Type toSet)
    {
        if (GetComponent<RestState>() != null)
        {
            Destroy(GetComponent<RestState>());
            gameObject.AddComponent(toSet);
        }
    }
}

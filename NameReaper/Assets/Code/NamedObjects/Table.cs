using UnityEngine;
using System.Collections;

public class Table : MonoBehaviour {

    RestState stateRest;

	// Use this for initialization
	void Start ()
    {
        gameObject.AddComponent <Table_RestState>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<RestState>().rest();
	}
}

public class Table_RestState : RestState
{
    override public void rest()
    {
    }
}

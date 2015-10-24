using UnityEngine;
using System.Collections;

public class Table : ObjectInformation
{

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

    public override RestState getRestState()
    {
        return GetComponent<Table_RestState>();
    }
}

public class Table_RestState : RestState
{
    override public void rest()
    {
    }
}

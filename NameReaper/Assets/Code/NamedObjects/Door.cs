using UnityEngine;
using System.Collections;

public class Door : ObjectInformation
{

    public bool isLocked = false;

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Door_RestState>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }

    public override RestState getRestState()
    {
        return GetComponent<Door_RestState>();
    }
}

public class Door_RestState : RestState
{
    override public void rest()
    {
    }
}

using UnityEngine;
using System.Collections;

public class Floor : ObjectInformation
{
    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Floor_RestState>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }

    public override RestState getRestState()
    {
        return GetComponent<Floor_RestState>();
    }
}

public class Floor_RestState : RestState
{
    override public void rest()
    {
    }
}

using UnityEngine;
using System.Collections;

public class Sofa: ObjectInformation
{

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Sofa_RestState>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }

    public override RestState getRestState()
    {
        return GetComponent<Sofa_RestState>();
    }
}

public class Sofa_RestState : RestState
{
    override public void rest()
    {
    }
}
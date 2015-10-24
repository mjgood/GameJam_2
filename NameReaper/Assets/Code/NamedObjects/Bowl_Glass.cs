using UnityEngine;
using System.Collections;

public class Bowl_Glass : MonoBehaviour {

    RestState stateRest;

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Bowl_Glass_RestState>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }
}

public class Bowl_Glass_RestState : RestState
{
    override public void rest()
    {
    }
}

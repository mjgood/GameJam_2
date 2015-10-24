using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour
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
}

public class Floor_RestState : RestState
{
    override public void rest()
    {
    }
}

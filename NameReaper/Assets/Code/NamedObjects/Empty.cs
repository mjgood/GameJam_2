using UnityEngine;
using System.Collections;

public class Empty : ObjectInformation
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

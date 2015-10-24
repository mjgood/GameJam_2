using UnityEngine;
using System.Collections;

public class Lamp : ObjectInformation
{

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Lamp_RestState>();
        gameObject.AddComponent<Lamp_InteractionState>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }

    public override RestState getRestState()
    {
        return GetComponent<Lamp_RestState>();
    }
}

public class Lamp_RestState : RestState
{
    override public void rest()
    {
    }
}

// TO DO LAMP GOES ON AND OFF
public class Lamp_InteractionState : InteractionState
{
    public override void interact(GameObject interactWith = null)
    {
        base.interact(interactWith);
    }
}
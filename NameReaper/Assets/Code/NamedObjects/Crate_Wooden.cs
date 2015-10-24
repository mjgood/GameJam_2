using UnityEngine;
using System.Collections;

public class Crate_Wooden : ObjectInformation
{

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Crate_Wooden_RestState>();
        gameObject.AddComponent<Crate_Wooden_RestState>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }

    public override RestState getRestState()
    {
        return GetComponent<Crate_Wooden_RestState>();
    }
}

public class Crate_Wooden_RestState : RestState
{
    override public void rest()
    {
    }
}

// TO DO OPEN CRATE -- MAKE LIST OF CONTAINED ITEMS
public class Crate_Wooden_InteractionState : InteractionState
{
    public override void interact(GameObject interactWith = null)
    {
        base.interact(interactWith);
    }
}

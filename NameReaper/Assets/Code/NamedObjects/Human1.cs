using UnityEngine;
using System.Collections;

public class Human1 : ObjectInformation
{

    void Start()
    {
        gameObject.AddComponent<Human_RestState>();
        gameObject.AddComponent<Human_MoveState>();
        gameObject.AddComponent<Human_InteractionState>();
        gameObject.AddComponent<Human_CombatState>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }

    public override RestState getRestState()
    {
        return GetComponent<Human_RestState>();
    }
    public override MoveState getMoveState()
    {
        return GetComponent<Human_MoveState>();
    }
    public override InteractionState getInteractionState()
    {
        return GetComponent<Human_InteractionState>();
    }
    public override CombatState getCombatState()
    {
        return GetComponent<Human_CombatState>();
    }
}

public class Human_RestState : RestState
{
    override public void rest()
    {
    }
}

public class Human_MoveState : MoveState
{
    override public void move()
    {

    }
}

public class Human_InteractionState : InteractionState
{
    public override void interact(GameObject interactWith = null)
    {
        base.interact(interactWith);
    }
}

public class Human_CombatState : CombatState
{
    public override void fight()
    {
        base.fight();
    }
}
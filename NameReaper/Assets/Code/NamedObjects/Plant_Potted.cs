using UnityEngine;
using System.Collections;

public class Plant_Potted : ObjectInformation
{

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Plant_Potted_RestState>();
        gameObject.AddComponent<Plant_Potted_CombatState>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }

    public override RestState getRestState()
    {
        return GetComponent<Plant_Potted_RestState>();
    }
    public override CombatState getCombatState()
    {
        return GetComponent<Plant_Potted_CombatState>();
    }
}

public class Plant_Potted_RestState : RestState
{
    override public void rest()
    {
    }
}

// what could be more innocent than a friendly-looking potted plant?
public class Plant_Potted_CombatState : CombatState
{
    public override void fight()
    {
        base.fight();
    }
}
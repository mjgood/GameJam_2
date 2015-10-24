using UnityEngine;
using System.Collections;

//sates
// - Move State
// - Rest State
// - Combat State
// - Interaction State

public class MoveState : MonoBehaviour
{
    public virtual void move()
    {
    }
}

public class RestState : MonoBehaviour
{
    public virtual void rest()
    {
    }
}

public class CombatState : MonoBehaviour
{
    public virtual void fight()
    {
    }
}

public class InteractionState : MonoBehaviour
{
    public virtual void interact(GameObject interactWith = null)
    {
    }
}

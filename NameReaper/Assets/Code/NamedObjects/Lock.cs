using UnityEngine;
using System.Collections;
using System;

public class Lock : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        gameObject.AddComponent<Lock_RestState>();
        gameObject.AddComponent<Lock_InteractionState>();

        try
        {
            Door parentObject = transform.parent.GetComponent<Door>();
            parentObject.isLocked = true;
        }
        catch (Exception e) { }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }

    void OnDestroy()
    {
        try
        {
            Door parentObject = transform.parent.GetComponent<Door>();
            parentObject.isLocked = false;
        }
        catch (Exception e) { }
    }
}

public class Lock_RestState : RestState
{
    override public void rest()
    {
    }
}

public class Lock_InteractionState : InteractionState
{
    override public void interact(GameObject interactWith = null)
    {
        if (interactWith != null)
        {
            try
            {
                if (interactWith.GetComponent<ObjectInformation>().name == "key")
                {
                    Destroy(gameObject);
                }
            }
            catch (Exception e)
            {
                Debug.Log("error working with " + interactWith.name + " in the lock interact");
            }
        }
    }
}


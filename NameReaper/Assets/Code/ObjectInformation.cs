using UnityEngine;
using System.Collections;
using System;

public class ObjectInformation : MonoBehaviour {

    public string name = "";
    public float hitpoints = 99999;

    public bool hasWater = false;

    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnMouseOver()
    {
        GameObject.FindGameObjectWithTag("UIinfoMouseOver").GetComponent<InfoPanelText>().SetTextFromObject(this);
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.FindGameObjectWithTag("UIpanel").GetComponent<ListPanel>().SetNameSelected(this);
        }
    }

    //get states
    public virtual RestState getRestState()
    {
        RestState toReturn = null;
        return toReturn;
    }
    public virtual MoveState getMoveState()
    {
        MoveState toReturn = null;
        return toReturn;
    }
    public virtual CombatState getCombatState()
    {
        CombatState toReturn = null;
        return toReturn;
    }
    public virtual InteractionState getInteractionState()
    {
        InteractionState toReturn = null;
        return toReturn;
    }

    //set states
    public void setRestState(Type toSet)
    {
        if (GetComponent<RestState>() != null)
        {
            Destroy(GetComponent<RestState>());
            gameObject.AddComponent(toSet);
        }
    }
    public void setMoveState(Type toSet)
    {
        if (GetComponent<MoveState>() != null)
        {
            Destroy(GetComponent<MoveState>());
            gameObject.AddComponent(toSet);
        }
    }
    public void setCombatState(Type toSet)
    {
        if (GetComponent<CombatState>() != null)
        {
            Destroy(GetComponent<CombatState>());
            gameObject.AddComponent(toSet);
        }
    }
    public void setInteractionState(Type toSet)
    {
        if (GetComponent<InteractionState>() != null)
        {
            Destroy(GetComponent<InteractionState>());
            gameObject.AddComponent(toSet);
        }
    }
}

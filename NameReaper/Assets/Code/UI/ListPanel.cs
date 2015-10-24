using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class ListPanel : MonoBehaviour {

    public Text currentlySelectedText;
    public ObjectInformation nameSet = null;
    public List<ObjectInformation> namesAvailable = new List<ObjectInformation>();
    public GameObject textObjectPrefab;

    // Use this for initialization
    void Start ()
    {
        //create empty slots for the player to use
        for (int ctr = 0; ctr < 2; ctr++)
        {
            ObjectInformation empty = gameObject.AddComponent<Empty>();
            empty.name = "<empty>";
            namesAvailable.Add(empty);

            GameObject newText = Instantiate(textObjectPrefab);
            newText.transform.SetParent(this.transform);
            newText.transform.localScale = new Vector3(1, 1, 1);
            newText.GetComponent<Text>().text = empty.name;
            newText.GetComponent<RectTransform>().localPosition = new Vector3(-8.34465f, 102 - (ctr * 20), -1);
            newText.GetComponent<TextDrag>().myTypeText = "NameInventory";
            newText.GetComponent<TextDrag>().itemNumber = ctr;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetNameSelected(ObjectInformation nS)
    {
        Debug.Log(nS.name);
        this.nameSet = nS;
        currentlySelectedText.text = nS.name;
    }

    //set element in menu to be currently selected item
    public void SwapElement(int swapElementNumber)
    {
        if (namesAvailable[swapElementNumber].name.Equals("<empty>"))
        {
            namesAvailable.Insert(swapElementNumber, nameSet);
            namesAvailable.RemoveAt(swapElementNumber + 1);
        }
        else
        {
            //MAKE THE ELEMENTS ACTUALLY SWAP BY INTRODUCING A THIRD ELEMENT TOMORROW
            /*Type cloneRest = namesAvailable[swapElementNumber].getRestState().GetType();
            Type cloneMove = namesAvailable[swapElementNumber].getMoveState().GetType();
            Type cloneInteraction = namesAvailable[swapElementNumber].getInteractionState().GetType();
            Type cloneCombat = namesAvailable[swapElementNumber].getCombatState().GetType();
            string cloneName = namesAvailable[swapElementNumber].name;*/

            //combat state
            Debug.Log(swapElementNumber);
            if (nameSet.getCombatState() != null)
            { namesAvailable[swapElementNumber].setCombatState(nameSet.getCombatState().GetType()); }
            else
            { namesAvailable[swapElementNumber].setCombatState(typeof(CombatState)); }

            //interacion state
            if (nameSet.getInteractionState() != null)
            { namesAvailable[swapElementNumber].setInteractionState(nameSet.getInteractionState().GetType()); }
            else
            { namesAvailable[swapElementNumber].setInteractionState(typeof(InteractionState)); }

            //move state
            if (nameSet.getMoveState() != null)
            { namesAvailable[swapElementNumber].setMoveState(nameSet.getMoveState().GetType()); }
            else
            { namesAvailable[swapElementNumber].setMoveState(typeof(MoveState)); }

            //rest state
            if (nameSet.getRestState() != null)
            { namesAvailable[swapElementNumber].setRestState(nameSet.getRestState().GetType()); }
            else
            { namesAvailable[swapElementNumber].setRestState(typeof(RestState)); }

            namesAvailable[swapElementNumber].name = nameSet.name;

            namesAvailable.Insert(swapElementNumber, nameSet);
            namesAvailable.RemoveAt(swapElementNumber + 1);

            /*nameSet.setCombatState(cloneCombat);
            nameSet.setMoveState(cloneMove);
            nameSet.setInteractionState(cloneInteraction);
            nameSet.setRestState(cloneRest);*/
        }
    }
}

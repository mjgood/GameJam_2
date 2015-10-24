using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

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

    public void SetNameSelected(ObjectInformation nameSet)
    {
        Debug.Log(nameSet.name);
        currentlySelectedText.text = nameSet.name;
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
        }
        
    }
}

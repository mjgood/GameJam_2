using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextDrag : MonoBehaviour, IPointerDownHandler {

    public string myTypeText = "CurrentSelection";
    public int itemNumber = -1;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPointerDown(PointerEventData eventData)
    {
        if (myTypeText.Equals("NameInventory"))
        {
            GetComponent<Text>().text = GameObject.FindGameObjectWithTag("UIpanel").GetComponent<ListPanel>().currentlySelectedText.text;
            GameObject.FindGameObjectWithTag("UIpanel").GetComponent<ListPanel>().SwapElement(itemNumber);
        }
    }
}

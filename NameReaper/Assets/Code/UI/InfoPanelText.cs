using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoPanelText : MonoBehaviour {

    public Text nameText;
    public Text restText;
    public Text moveText;
    public Text interactionText;
    public Text combatText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetTextFromObject(ObjectInformation objectFrom)
    {
        nameText.text = "Name: " + objectFrom.name;

        //rest
        if (objectFrom.getRestState() != null)
        {
            restText.color = Color.black;
            if (objectFrom.getRestState().GetType() == typeof(RestState))
            {
                restText.text = "Rest: No";
            }
            else
            {
                restText.text = "Rest: Yes";
            }
        }
        else
        {
            restText.text = "Rest:";
            restText.color = Color.gray;
        }

        //move
        if (objectFrom.getMoveState() != null)
        {
            moveText.color = Color.black;
            if (objectFrom.getMoveState().GetType() == typeof(MoveState))
            {
                moveText.text = "Move: No";
            }
            else
            {
                moveText.text = "Move: Yes";
            }
        }
        else
        {
            moveText.text = "Move:";
            moveText.color = Color.gray;
        }

        //interact
        if (objectFrom.getInteractionState() != null)
        {
            interactionText.color = Color.black;
            if (objectFrom.getInteractionState().GetType() == typeof(InteractionState))
            {
                interactionText.text = "Interaction: No";
            }
            else
            {
                interactionText.text = "Interaction: Yes";
            }
        }
        else
        {
            interactionText.text = "Interaction:";
            interactionText.color = Color.gray;
        }

        //combat
        if (objectFrom.getCombatState() != null)
        {
            combatText.color = Color.black;
            if (objectFrom.getCombatState().GetType() == typeof(CombatState))
            {
                combatText.text = "Combat: No";
            }
            else
            {
                combatText.text = "Combat: Yes";
            }
        }
        else
        {
            combatText.text = "Combat:";
            combatText.color = Color.gray;
        }
    }
}

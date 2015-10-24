using UnityEngine;
using System.Collections;

public class UIButtons : MonoBehaviour {
    GameObject MMParent, SParent;
	// Use this for initialization
	void Start () {
        MMParent = GameObject.Find("MainMenuParent");
        SParent = GameObject.Find("SettingsParent");
        SParent.transform.Translate(5000f, 5000f, -10f);
    }
	
    public void playBTN()
    {
        Debug.Log("play!");
    }
    public void settingsBTN()
    {
        Debug.Log("settings");
        SParent.transform.Translate(MMParent.transform.position.x-SParent.transform.position.x, MMParent.transform.position.y - SParent.transform.position.y, -10f);
        MMParent.transform.Translate(5000f,5000f,-10f);
    }
    public void exitBTN()
    {
        Debug.Log("exit");
    }
    public void sound_FX()
    {
        Debug.Log("toggle sound effects");
    }
    public void music()
    {
        Debug.Log("toggle music");
    }
    public void back()
    {
        Debug.Log("return to menu");
        MMParent.transform.Translate(SParent.transform.position.x-MMParent.transform.position.x, SParent.transform.position.y-MMParent.transform.position.y, -10f);
        SParent.transform.Translate(5000f, 5000f, -10f);
    }
}

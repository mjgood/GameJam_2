using UnityEngine;
using System.Collections;
using UnityEditor;
using System;



[ExecuteInEditMode]
public class Location : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float zDepth;
    public string myName = "";
    public float multiplier;
    public float xPlus;
    public float yPlus;

    public Vector3 prevPosition;
    public bool doSnap = false;
    public float snapValue;
    
    public void OnGUI()
    {
        /*doSnap = EditorGUILayout.Toggle("Autosnap", doSnap);
        snapValue = EditorGUILayout.FloatField("Snap Value", snapValue);*/
    }

    public void Update()
    {
        if (Selection.transforms.Length > 0 && !EditorApplication.isPlaying)
        if (doSnap && Selection.transforms[0].position != prevPosition)
            snap();
    }

    public void snap()
    {
        try
        {
            for (int i = 0; i < Selection.transforms.Length; i++)
            {
                Vector3 t = Selection.transforms[i].transform.position;
                t = new Vector3(round(t.x), round(t.y), round(t.z));
                Selection.transforms[i].transform.position = t;
            }
            prevPosition = Selection.transforms[0].position;
        }
        catch (Exception e)
        {
            // Nothing to move.
            Debug.LogError("Nothing to move.  " + e);
        }
    }
    public float round(float input)
    {
        float snappedValue;
        snappedValue = snapValue * Mathf.Round((input / snapValue));
        return (snappedValue);
    }
}

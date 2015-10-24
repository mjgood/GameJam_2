using UnityEngine;
using System.Collections;
using System;

public class Minnow : ObjectInformation
{

    void Start()
    {
        gameObject.AddComponent<Minnow_RestState>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<RestState>().rest();
    }

    public override RestState getRestState()
    {
        return GetComponent<Minnow_RestState>();
    }
    public override MoveState getMoveState()
    {
        return GetComponent<Minnow_MoveState>();
    }
}

public class Minnow_RestState : RestState
{
    override public void rest()
    {
        // ***** FIX ME FIX ME FIX ME FIX ME FIX ME FIX ME FIX ME!!!!!!!!!! *****
        //Debug.Log(transform.localPosition);
        try
        {
            if (transform.localPosition.x < -0.1f)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0.1f, 0);
            }
            if (transform.localPosition.x > 0.1f)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-0.1f, 0);
            }
        }
        catch (Exception e) { }

        try
        {
            if (!transform.parent.GetComponent<ObjectInformation>().hasWater)
            {
                Destroy(gameObject);
            }
        }
        catch (Exception e)
        { Debug.Log("no parent for minnow with object information"); }
    }
}

// ***** TO DO MAKE MINNOW MOVE
public class Minnow_MoveState : MoveState
{
    override public void move()
    {

    }
}
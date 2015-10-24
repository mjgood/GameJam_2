using UnityEngine;
using System.Collections;

public class CameraCode : MonoBehaviour {

    public Transform playerFollow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float xSet = transform.position.x;
        float ySet = transform.position.y;

        if (transform.position.x < playerFollow.position.x - 1)
        { xSet = playerFollow.position.x - 1; }
        if (transform.position.x > playerFollow.position.x + 1)
        { xSet = playerFollow.position.x + 1; }
        if (transform.position.y < playerFollow.position.y - 1)
        { ySet = playerFollow.position.y - 1; }
        if (transform.position.y > playerFollow.position.y + 1)
        { ySet = playerFollow.position.y + 1; }

        transform.position = new Vector3(xSet, ySet, transform.position.z);
    }
}

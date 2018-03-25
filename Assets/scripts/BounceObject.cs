using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceObject : MonoBehaviour {

    
    public Vector3 MoveVector = Vector3.right;
    public float MoveRange = 3f;
    public float MoveSpeed = 20f;

    private BounceObject bounceObject;

    Vector3 startPosition;

    void Start () {
        bounceObject = this;
        startPosition = bounceObject.transform.position;

    }

	
	// Update is called once per frame
	void Update () {
        bounceObject.transform.position = startPosition + MoveVector * (MoveRange * Mathf.Sin(Time.timeSinceLevelLoad * MoveSpeed));
    }
}

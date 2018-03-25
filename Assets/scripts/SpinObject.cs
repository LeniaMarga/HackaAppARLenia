using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour {

        public float speed = 10f;

    private SpinObject spinObject;

    private void Start()
    {
        spinObject = this;
   }

    // Update is called once per frame
    void Update ()
   {
        transform.Rotate(Vector3.right, speed * Time.deltaTime);
	}
}

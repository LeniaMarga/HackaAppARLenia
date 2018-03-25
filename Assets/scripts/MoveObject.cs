using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {


    public Vector3 MoveVector = Vector3.right;
    public float MoveRange = 10f;
    public float MoveSpeed = 30f;

 

    Vector3 startPosition;

    public float speed = 140f;

    private MoveObject moveObject;



    public float duration; 
    float elapsedTime = 0f;

    // Use this for initialization
    void Start () {
        moveObject = this;
        startPosition = moveObject.transform.position;

     
    }

    // Update is called once per frame
    void Update () {
       
            StartCoroutine(SpinObjectRoutine());
            
    }


    private IEnumerator SpinObjectRoutine()
    {
        yield return new WaitForSeconds(3);
        if (elapsedTime < duration)
        {
            transform.Rotate(Vector3.down, speed * Time.deltaTime);
            elapsedTime += Time.deltaTime;
        }
        else
        {
            StartCoroutine(BounceObjectRoutine());
        }

    }

    private IEnumerator BounceObjectRoutine()
    {
        yield return new WaitForSeconds(1);
        moveObject.transform.position = startPosition + MoveVector * (MoveRange * Mathf.Sin(Time.timeSinceLevelLoad * MoveSpeed));
    }
}

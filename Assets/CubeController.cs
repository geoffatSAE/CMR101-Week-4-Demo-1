using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    public int myPublicInt;
    public float myFloat;
    public bool isABool;
    public string isAString;


    Renderer r;


    // Start is called before the first frame update
    void Start()
    {
        myPublicInt = 16;
        Debug.Log("My public int is " + myPublicInt);

        //assign this objects renderer to the r reference.
        r = GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {
        myPublicInt = myPublicInt + 1;

        //Debug.Log("Looping through the myNothingInt values, it is " + myPublicInt);
    }

    public void TurnRed()
    {
        r.material.color = Color.red;

    }

    public void MakeBig()
    {

        transform.localScale = new UnityEngine.Vector3(transform.localScale.x + 1, transform.localScale.y + 1, transform.localScale.z + 1);

        //HUD.text = transform.localScale.ToString(); //update the HUD text after making a change.

    }
}

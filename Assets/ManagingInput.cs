using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagingInput : MonoBehaviour
{
    public CubeController cc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
            cc.TurnRed();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            print("b has bbbbeeen pressed");
            cc.MakeBig();
        }


    }
}

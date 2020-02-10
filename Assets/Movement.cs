using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    int actual_pos = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && actual_pos != 1)
        {
            if (actual_pos == 2)
            {
                actual_pos = 1;
                transform.position = pos1.transform.position;
                
            }
            else
            {
                actual_pos = 2;
                transform.position = pos2.transform.position;
            }
        }
        if (Input.GetKeyDown(KeyCode.D) && actual_pos != 3)
        {
            if (actual_pos == 2)
            {
                actual_pos = 3;
                transform.position = pos3.transform.position;
            }
            else
            {
                actual_pos = 2;
                transform.position = pos2.transform.position;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandom : MonoBehaviour
{
    int choose;
    public bool boy;
    public bool girl;
    public GameObject cam;

    void Start()
    {
        choose = Random.Range(0, 2);

        if (choose == 0)
        {
            boy = true;
            cam.transform.Translate(34, 0, 0);
        }

        else if (choose == 1)
        {
            girl = true;
            cam.transform.Translate(0, 0, 0);
        }
    }

    void Update()
    {
        
    }
}

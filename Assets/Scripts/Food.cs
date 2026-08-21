using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up,Space.World);

    }
}

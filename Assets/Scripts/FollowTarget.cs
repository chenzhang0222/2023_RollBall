using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    //public Transform trans;
    public GameObject Player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("FollowTarget");
        //Debug.Log(trans.position);
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
        
    }
}

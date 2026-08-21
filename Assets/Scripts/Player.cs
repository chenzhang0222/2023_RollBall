using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{   
    public Rigidbody rb;
    public int score = 0;
    public TextMeshProUGUI textComponent;
    public GameObject winTextGo;
  
    void Start()//游戏开始时运行一次
    {
        Debug.Log("start运行了");
        
    }

   
    void Update()//游戏运行时每一帧执一次
    {
        float v = Input.GetAxisRaw("Vertical");//读取ws
        float h = Input.GetAxisRaw("Horizontal");//读取ad
        Vector3 vir = new Vector3(h,0,v);
        rb.AddForce(vir*3);
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter" + collision.gameObject.name);

        if (collision.gameObject.tag == "Food")
        {
            
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay"+collision.gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Food")
        {   
            score++;
            textComponent.text = score.ToString();
            Destroy(other.gameObject);
            if (score == 9)
            {
                winTextGo.SetActive(true);
            }
        }
    }
}

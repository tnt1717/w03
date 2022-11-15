using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody rb;
    public float atk =100;
    private float timer;
    
    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        
    }

    void Update()
    {
        timer += Time.deltaTime;

        //Debug.Log(timer);

        if (timer >= 3)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            GameManager.score += 20;

            
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 300f;
    public bool isJump = false;

    Rigidbody2D rigidbody2D; //ligidbody는 물리적인 효과가 적용된다는 뜻


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {   
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        } 
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space) && isJump == false){
            isJump = true;
            rigidbody2D.AddForce(Vector2.up * jumpSpeed);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJump = false;

        if (collision.gameObject.name == "block")
        {
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals("SpeedUp")) {
            speed += 3f;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.name.Equals("JumpUp"))
        {
            jumpSpeed += 150f;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.name.Equals("Portal"))
        {
            SceneManager.LoadScene(1);
        }
    }
   
}

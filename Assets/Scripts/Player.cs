using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public float speed;
    public Vector3 jump;
    public float jumpForce;
    Rigidbody rb;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            print("fly");

        }

        if(transform.position.y <= -8 || transform.position.y >= 8)
        {
            SceneManager.LoadScene("LoseScene");
        }
            
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("obstacle"))
        {
            SceneManager.LoadScene("LoseScene");

        }
    }

}

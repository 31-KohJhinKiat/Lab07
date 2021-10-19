using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    public int speed;

    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisAnimation.Play();
            transform.position += transform.up * speed * Time.deltaTime;
            print("fly");

        }

        if(transform.position.y <= -7 || transform.position.y >= 7)
        {
            SceneManager.LoadScene("LoseScene");
        }
            
    }
}

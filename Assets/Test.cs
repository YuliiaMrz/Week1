using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    float jumpForce;

    public GameStats gameStats;

    void Start()
    {
        print("helloworld");
        GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        jumpForce = gameStats.jumpForce;

    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);


        }


    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("AddScore"))
        {

            gameStats.AddScore(1);
        }
    }
}
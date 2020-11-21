using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject collisionDetector;
    CollisionDetector colDetScript;
    string ballCollider;
    Rigidbody2D rb2D;

    void Start()
    {
        colDetScript = collisionDetector.GetComponent<CollisionDetector>();
        rb2D=gameObject.GetComponent<Rigidbody2D>() ;
        rb2D.AddForce(Vector2.right * 100f);

    }

    private void Update()
    {
        ballCollider = colDetScript.BallCollision(gameObject);
        print(ballCollider);

        if (ballCollider == "rightCenter")
            rb2D.AddForce(Vector2.right * 10f);
        if (ballCollider == "rightPaddleUp")
            rb2D.AddForce(Vector2.up);
        if (ballCollider == "rightPaddleDown")
            rb2D.AddForce(Vector2.down);

        if (ballCollider == "leftCenter")
            rb2D.AddForce(Vector2.right * 10f);
        if (ballCollider == "leftPaddleUp")
            rb2D.AddForce(Vector2.up);
        if (ballCollider == "leftPaddleDown")
            rb2D.AddForce(Vector2.down);

        if (ballCollider == "roof")
            rb2D.AddForce(Vector2.down * 10f);
        if (ballCollider == "floor")
            rb2D.AddForce(Vector2.up*10f);
        

    }
}

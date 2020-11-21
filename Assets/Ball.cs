using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject collisionDetector;
    CollisionDetector colDetScript;
    string ballCollider;

    void Start()
    {
        colDetScript = collisionDetector.GetComponent<CollisionDetector>();
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right*100f) ;

    }

    private void Update()
    {
        ballCollider=colDetScript.BallCollision(gameObject);
        print(ballCollider);

        if (ballCollider == "none")
        {

        }
    }
}

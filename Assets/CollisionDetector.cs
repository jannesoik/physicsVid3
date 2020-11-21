using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject[] collidingObjects;
    public List<GameObject> collidingObjectsList;
    public GameObject floor;
    public GameObject roof;
    public GameObject ball;
    public GameObject wallLeft;
    public GameObject wallRight;
    public GameObject paddleRight;
    public GameObject paddleLeft;

    private void Awake()
    {
        collidingObjects = GameObject.FindGameObjectsWithTag("CollidingObject");
        foreach (var item in collidingObjects)
        {
            collidingObjectsList.Add(item);
        }
    }
    

    public bool RoofFloorCollision(GameObject player)
    {
        // Check if player is colliding with roof/floor by comparing y-axis'

        float playerUp= player.GetComponent<Renderer>().bounds.max.y;
        float playerDown= player.GetComponent<Renderer>().bounds.min.y;

        float floorUp = floor.GetComponent<Renderer>().bounds.max.y;
        float roofDown = roof.GetComponent<Renderer>().bounds.min.y;

        if ( playerUp >= roofDown) // roof collision
        {
            player.transform.Translate(new Vector2(0.0f, -0.01f)); // move player downwards
            return true;
        }
        if (playerDown <= floorUp) // floor collision
        {
            player.transform.Translate(new Vector2(0.0f, 0.01f)); // move player upwards
            return true;
        }
        
            return false;
        
    }

    public string BallCollision(GameObject ball)
    {
        //print(ball.GetComponent<Renderer>().bounds);

        float ballRight = ball.GetComponent<Renderer>().bounds.max.x;
        float ballLeft = ball.GetComponent<Renderer>().bounds.min.x;
        float ballUp = ball.GetComponent<Renderer>().bounds.max.y;
        float ballDown = ball.GetComponent<Renderer>().bounds.min.y;

        // Check if ball hits walls
        if (ballRight >= wallRight.GetComponent<Renderer>().bounds.min.x - 0.1f /* left side of right wall */ )
        {
            return "rightWall";
        }
        if (ballLeft <= wallLeft.GetComponent<Renderer>().bounds.max.x + 0.1f /* right side of left wall */ )
        {
            return "leftWall";
        }

        // Check if ball hits paddles
        if (ballRight >= paddleRight.GetComponent<Renderer>().bounds.min.x - 0.1f /* left side of right paddle */ )
        {
            return "rightPaddle";
        }
        if (ballLeft <= paddleLeft.GetComponent<Renderer>().bounds.max.x + 0.1f /* right side of left paddle */ )
        {
            return "leftPaddle";
        }

        return "none";
    }

    #region old
    //void Start()
    //{

    //}

    //void Update()
    //{

    //}

    //void ProcessCollisions()
    //{
    //    // 1. Remove objects
    //    RemoveObjects();

    //    // 2. Find highest axis variance
    //    float axis = FindHighestVarAxis();

    //    // 3. Sort objs by min on highest variance axis
    //    // 4. Test collisions in range
    //}

    //void RemoveObjects()
    //{

    //}

    //float FindHighestVarAxis()
    //{
    //    return 0.1f;
    //} 
    #endregion
}

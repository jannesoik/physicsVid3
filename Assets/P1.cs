using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1 : MonoBehaviour
{
    public GameObject collisionDetector;
    CollisionDetector colDetScript;

    void Start()
    {
        colDetScript = collisionDetector.GetComponent<CollisionDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && colDetScript.RoofFloorCollision(gameObject)==false)
        {
                transform.Translate(new Vector2(0.0f, 0.01f));
        }
        if (Input.GetKey(KeyCode.DownArrow) && colDetScript.RoofFloorCollision(gameObject) == false)
        {
                transform.Translate(new Vector2(0.0f, -0.01f));
        }

    }

    
}

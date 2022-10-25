using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderImage : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody Drone;
    public Vector3 startPosition = new Vector3(0, 0, 1);
    public Vector3 targetPosition = new Vector3(0, 1.5f, 1);
    public int speed = 5;
    public bool startUp = false;
    
    private float distanceToStop = 0.5f;
    private Vector3 desiredVelocity;
    private float lastEuclideanDist;

    void Start()
    {
        Drone.position = startPosition;

        desiredVelocity = (targetPosition - startPosition).normalized * speed;
        lastEuclideanDist = Mathf.Infinity;
    }

    // Update is called once per frame
    void Update()
    {
        // empty update function
    }

    void FixedUpdate() 
    {
        if (startUp == true)
        {
            float EuclideanDist = (targetPosition - Drone.position).sqrMagnitude;

            if (EuclideanDist > distanceToStop)
            {
                var direction = targetPosition - Drone.position;
                Drone.AddRelativeForce(direction.normalized * speed, ForceMode.Force);
            }
        }
    }
}

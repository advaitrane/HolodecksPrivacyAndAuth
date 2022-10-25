using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlHolodeck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject drone1;
    public GameObject drone2;
    public GameObject drone3;
    public Vector3 startUpPosition = new Vector3(0, 0, 0);

    private float distanceError = 0.3f;
    private bool startUp = false;

    // private GameObject[] holodeck = {drone1, drone2, drone3};

    void Start()
    {
        // empty start function
    }

    // Update is called once per frame
    void Update()
    {
        float startUpDist = (transform.position - startUpPosition).sqrMagnitude;
        if ((startUpDist < distanceError) && !startUp)
        {
            drone1.GetComponent<RenderImage>().startUp = true;
            drone2.GetComponent<RenderImage>().startUp = true;
            drone3.GetComponent<RenderImage>().startUp = true;

            // for (int i = 0; i < 3; i++)
            // {
            //     holodeck[i].GetComponent<RenderImage>().startUp = true;
            // }
        }
    }
}

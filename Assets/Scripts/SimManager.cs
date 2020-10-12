using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class SimManager : MonoBehaviour
{
    public GameObject straightRoadPreFab;
    public GameObject rightRoadPreFab;
    public GameObject leftRoadPreFab;
    public Queue<GameObject> roads = new Queue<GameObject>();
    public float updatePeriod;
    public int maxRoadSegments = 0;
    private float timeElapsed = 0;
    static System.Random rnd = new System.Random();
    private Vector3 currentPos;
    private bool lastWasSlantRight = false;
    private bool lastWasSlantLeft = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject firstObj = GameObject.Find("StraightRoadWithLight");

        currentPos = firstObj.transform.position;
        roads.Enqueue(firstObj);

    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;
        timeElapsed += dt;
        //Debug.Log($"timeElapsed:{timeElapsed}, updatePeriod:{updatePeriod}");
        if (timeElapsed > updatePeriod)
        {
            timeElapsed = 0;
            var dice = rnd.Next(1, 4);
            GameObject newGO = new GameObject();
            //Vector3 rotation = new Vector3(0, 90, 0);
            //Debug.Log("Selected " + dice + lastWasSlantLeft + lastWasSlantRight);
            if (lastWasSlantLeft || lastWasSlantRight) dice = 1;
            
            switch (dice)
            {
                case 1:
                    newGO = GameObject.Instantiate(straightRoadPreFab);
                    
                    if (lastWasSlantRight)
                    {
                        currentPos = new Vector3(currentPos.x + 4, 0, currentPos.z + 20 - 8);
                        lastWasSlantRight = false;
                    }
                    else if (lastWasSlantLeft)
                    {
                        currentPos = new Vector3(currentPos.x - 4, 0, currentPos.z + 20 - 8);
                        lastWasSlantLeft = false;
                    }
                    else
                    {
                        currentPos = new Vector3(currentPos.x, 0, currentPos.z + 20);
                    }
                    //newGO.transform.Rotate(0, 0, 0);
                    newGO.transform.position = currentPos;
                    //Debug.Log($"Adding a straight road at pos:{newGO.transform.position}");
                    roads.Enqueue(newGO);
                    break;
                case 2:
                    //right road
                    newGO = GameObject.Instantiate(rightRoadPreFab);
                    currentPos = new Vector3(currentPos.x + 4, 0, currentPos.z + 10);
                    //newGO.transform.Rotate(0, 0, 0);
                    newGO.transform.position = currentPos;
                    //Debug.Log($"Adding a right road at pos:{newGO.transform.position}");
                    roads.Enqueue(newGO);
                    lastWasSlantRight = true;
                    break;
                case 3:
                    newGO = GameObject.Instantiate(leftRoadPreFab);
                    currentPos = new Vector3(currentPos.x - 4, 0, currentPos.z + 10);
                    //newGO.transform.Rotate(0, 0, 0);
                    newGO.transform.position = currentPos;
                    //Debug.Log($"Adding a left road at pos:{newGO.transform.position}");
                    roads.Enqueue(newGO);

                    lastWasSlantLeft = true;
                    break;


            }
            

            #region remove roads
            //Debug.Log($"roads:{roads.Count}/maxRoads:{maxRoadSegments}");
            if (roads.Count > maxRoadSegments)
            {
                GameObject killed = roads.Dequeue();
                Destroy(killed);

            }

            #endregion


        }
    }
}

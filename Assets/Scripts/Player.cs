using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    public GameObject camera;
    private float x;
    private float y;
    Rigidbody rb;
    public float speed;
    public float camOffset;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(this.transform.position.x, camOffset, this.transform.position.z-20);
        camera.transform.LookAt(this.transform);
    }

    private void OnMove(InputValue movementVal)
    {
        Vector2 mVec = movementVal.Get<Vector2>();
        x = mVec.x;
        y = mVec.y;

    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(x, 0, y) * speed;
        rb.AddForce(movement);
    }

}

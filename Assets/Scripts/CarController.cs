using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentBrakeForce;
    private float steeringAngle;

    private bool isBraking;
    [SerializeField] private float brakeForce;
    [SerializeField] private float motorForce;
    [SerializeField] private float maxSteeringAngle;

    [SerializeField] private WheelCollider frontLeftCollider;
    [SerializeField] private WheelCollider frontRightCollider;
    [SerializeField] private WheelCollider rearLeftCollider;
    [SerializeField] private WheelCollider rearRightCollider;

    [SerializeField] private Transform frontLeftTransform;
    [SerializeField] private Transform frontRightTransform;
    [SerializeField] private Transform rearLeftTransform;
    [SerializeField] private Transform rearRightTransform;

    private CarInput carInput;


    public GameObject camera;
    public float camOffset;

    private void Awake()
    {
        carInput = new CarInput();
    }

    private void OnEnable()
    {
        carInput.Enable();
    }

    private void OnDisable()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnMove(InputValue movementVal)
    //{
    //    Debug.Log("Car on move called");
    //    float steerInput =
    //    //    horizontalInput = Input.GetAxis(HORIZONTAL);
    //    //    verticalInput = Input.GetAxis(VERTICAL);
    //    //isBraking = movementVal.isPressed();
    //}

    private void FixedUpdate()
    {
        //GetInput();
        horizontalInput = carInput.Driving.Steering.ReadValue<float>();
        verticalInput = carInput.Driving.Accel.ReadValue<float>();
        isBraking = carInput.Driving.Braking.triggered;
        Debug.Log("braking: " + isBraking);
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    private void LateUpdate()
    {
        camera.transform.position = new Vector3(this.transform.position.x, camOffset, this.transform.position.z - 20);
        camera.transform.LookAt(this.transform);
    }


    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftCollider, frontLeftTransform);
        UpdateSingleWheel(frontRightCollider, frontRightTransform);
        UpdateSingleWheel(rearLeftCollider, rearLeftTransform);
        UpdateSingleWheel(rearRightCollider, rearRightTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }

    private void HandleSteering()
    {
        steeringAngle = maxSteeringAngle * horizontalInput;
        frontLeftCollider.steerAngle = steeringAngle;
        frontRightCollider.steerAngle = steeringAngle;
    }

    private void HandleMotor()
    {
        frontLeftCollider.motorTorque = verticalInput * motorForce;
        frontRightCollider.motorTorque = verticalInput * motorForce;
        rearLeftCollider.motorTorque = verticalInput * motorForce;
        rearRightCollider.motorTorque = verticalInput * motorForce;

        brakeForce = isBraking ? brakeForce : 0f;
        if (isBraking)
        {
            ApplyBraking();
        }
    }

    private void ApplyBraking()
    {
        frontLeftCollider.brakeTorque = currentBrakeForce;
        frontRightCollider.brakeTorque = currentBrakeForce;
        rearLeftCollider.brakeTorque = currentBrakeForce;
        rearLeftCollider.brakeTorque = currentBrakeForce;
    }

    //private void GetInput()
    //{
    //    horizontalInput = Input.GetAxis(HORIZONTAL);
    //    verticalInput = Input.GetAxis(VERTICAL);
    //    isBraking = Input.GetKey(KeyCode.Space);
    //}


}

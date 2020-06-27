using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20f;
    public float turnSpeed = 45f;

    [SerializeField]
    private int playerIndex = 0;

    private float horizontalInput;
    private float verticalInput;

    public GameObject myCamera;
    private FollowPlayer myFollowPlayer;

    void Start()
    {
        myFollowPlayer = myCamera.GetComponent<FollowPlayer>();
    }

    void Update()
    {

        this.transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        this.transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }

    public void UpdateSteer(float value)
    {
        horizontalInput = value;
    }
    public void UpdateAccelerate(float value)
    {
        verticalInput = value;
        
    }
    public void UpdateCamera()
    {
        myFollowPlayer.ChangeCameraView();

    }
    public int GetPlayerIndex()
    {
        return playerIndex;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    public bool isPlayer2;

    private Vector3 _offset = new Vector3(0, 5, -10); 
    private Vector3 foward_offset = new Vector3(0, 5, 10);
    private Vector3 backward_offset = new Vector3(0, 5, -10);


    void Start()
    {
        if (isPlayer2)
            _offset = foward_offset;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + _offset;
        this.transform.LookAt(player.transform);
    }

    public void ChangeCameraView()
    {
        if (_offset == foward_offset)
            _offset = backward_offset;
        else
            _offset = foward_offset;

      
    }




}

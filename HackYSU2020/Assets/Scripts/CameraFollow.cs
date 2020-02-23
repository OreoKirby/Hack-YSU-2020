using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private GameObject player;
    private float _playerX;
    private float startPlayerX;
    private float startPlayerY;
    private float startCameraY;
    private float startCameraX;
    private float startCameraZ;
    private float _playerY;
    private float _playerZ;
    private float startPlayerZ;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        var position = player.transform.position;
        startPlayerX = position.x;
        startPlayerZ = position.z;
        startPlayerY = position.y;
        startCameraX = gameObject.transform.position.x;
        startCameraY = gameObject.transform.position.y;
        startCameraZ = gameObject.transform.position.z;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var position = player.transform.position;
        _playerX = position.x;
        _playerY = position.y;
        _playerZ = position.z;
        
        this.gameObject.transform.position = new Vector3(startCameraX + (_playerX - startPlayerX), startCameraY + (_playerY - startPlayerY), startCameraZ + (_playerZ - startPlayerZ));
        //transform.LookAt(player.transform);
    }
}

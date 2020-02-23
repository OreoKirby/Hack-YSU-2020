using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private GameObject player;
    private float _playerX;
    private float _playerY;
    private float _playerZ;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var position = player.transform.position;
        _playerX = position.x;
        _playerY = position.y;
        _playerZ = position.z;
        
        this.gameObject.transform.position = new Vector3(_playerX, this.transform.position.z, _playerZ);
    }
}

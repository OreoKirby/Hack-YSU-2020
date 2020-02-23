using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControls : MonoBehaviour
{
    private Joycon j;

    public Vector3 gyro;
    public Vector3 accel;
    public Quaternion orientation;
    public Quaternion fix;



    // Start is called before the first frame update
    void Start()
    {
        gyro = new Vector3(0, 0, 0);
        accel = new Vector3(0, 0, 0);
        // get the public Joycon object attached to the JoyconManager in scene
        j = JoyconManager.Instance.j;
    }

    // Update is called once per frame
    void Update()
    {
        if (j != null && j.state > Joycon.state_.ATTACHED)
        {
            gyro = j.GetGyro();

            // Accel values:  x, y, z axis values (in Gs)
            accel = j.GetAccel();

            orientation = j.GetVector();

            gameObject.transform.rotation = orientation;

            fix = Quaternion.Euler(this.transform.rotation.eulerAngles.y - 90, this.transform.rotation.eulerAngles.x, -this.transform.rotation.eulerAngles.z + 90);
            gameObject.transform.rotation = fix;
        }
    }
}

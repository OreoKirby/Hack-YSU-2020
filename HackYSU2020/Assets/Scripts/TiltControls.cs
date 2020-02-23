using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControls : MonoBehaviour
{
    private Joycon j;

    public Vector3 gyro;
    public Vector3 accel;
    public float xMax, yMax, zMax;
    public Quaternion orientation;
    private Quaternion fix;
    public float maxAngle;

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

            if (this.transform.rotation.eulerAngles.y - 90 < maxAngle && this.transform.rotation.eulerAngles.y - 90 > -maxAngle)
            {
                xMax = this.transform.rotation.eulerAngles.y - 90;
            }

            if (-this.transform.rotation.eulerAngles.z + 90 < maxAngle && -this.transform.rotation.eulerAngles.z + 90 > -maxAngle)
            {
                zMax = -this.transform.rotation.eulerAngles.z + 90;
            }

            if (this.transform.rotation.eulerAngles.x < maxAngle && -this.transform.rotation.eulerAngles.x > maxAngle)
            {
                yMax = this.transform.rotation.eulerAngles.x;
            }

            fix = Quaternion.Euler(xMax, yMax, zMax);
            gameObject.transform.rotation = fix;

        }
    }
}

using UnityEngine;
using System.Collections;
using System.Linq.Expressions;

public class DartGeneratorScript : MonoBehaviour
{
    public GameObject Dart;
    public int fireSpeed = 60;

    void Start()
    {
        Input.simulateMouseWithTouches = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            this.ThrowDart();
        }
    }

    void ThrowDart()
    {
        Camera cam = Camera.main;

        Vector3 rot = cam.transform.rotation.eulerAngles;
        rot.x = rot.x + 90;
        rot.z = 0;

        GameObject dart = Instantiate(this.Dart, cam.transform.position, Quaternion.Euler(rot)) as GameObject;

        Rigidbody rb = dart.GetComponent<Rigidbody>();
        rb.AddForce(this.transform.forward * this.fireSpeed, ForceMode.Impulse);
    }
}
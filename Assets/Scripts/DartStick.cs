using UnityEngine;
using System.Collections;

public class DartStick : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Target")
        {
            this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            this.gameObject.transform.parent = collision.gameObject.transform;
        }
        
    }


}

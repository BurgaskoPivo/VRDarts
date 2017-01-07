using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{
    private float movementSpeed = 0.01f;

    public void Update()
    {
        if (LocationMovementCache.CanMove)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, LocationMovementCache.LocationToMoveTo, this.movementSpeed);
            this.transform.position = new Vector3(this.transform.position.x, 10, this.transform.position.z);
        }
    }
}

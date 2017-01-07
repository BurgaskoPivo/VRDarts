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
        }
    }
}

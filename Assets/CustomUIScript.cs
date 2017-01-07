using UnityEngine;

public class CustomUIScript : MonoBehaviour, IGvrGazeResponder
{

    public void OnGazeEnter()
    {
        LocationMovementCache.CanMove = true;
        LocationMovementCache.LocationToMoveTo = this.transform.position;
    }

    public void OnGazeExit()
    {
        LocationMovementCache.CanMove = false;
        LocationMovementCache.LocationToMoveTo = default(Vector3);
    }

    public void OnGazeTrigger()
    {
        Debug.Log("Logging");
    }
}

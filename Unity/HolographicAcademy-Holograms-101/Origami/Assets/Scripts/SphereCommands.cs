using UnityEngine;

public class SphereCommands : MonoBehaviour
{
    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        var pushDirection = Camera.main.transform.forward;
        var intensity = UnityEngine.Random.Range(1f, 5f);
        pushDirection.x *= intensity;
        pushDirection.y *= intensity;
        pushDirection.z *= intensity;
        this.GetComponent<Rigidbody>().AddForce(pushDirection, ForceMode.Impulse);
    }
}
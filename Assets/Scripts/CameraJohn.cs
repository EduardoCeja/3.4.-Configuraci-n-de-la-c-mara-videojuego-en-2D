using UnityEngine;

public class CameraJohn : MonoBehaviour
{
    public GameObject John;
    private void Update()
    {
        Vector3 position = transform.position;
        position.x = John.transform.position.x;
        transform.position = position;
    }

}

using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform respawnPoint;
    public float threshold;

    void FixedUpdate()
    {
        if (transform.position.y < threshold)
        {
            transform.position = respawnPoint.position;//new Vector3(0, 50, 0);
        }
    }
}
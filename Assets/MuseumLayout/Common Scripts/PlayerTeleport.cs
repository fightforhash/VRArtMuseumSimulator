using System.Collections;
using UnityEngine;

// Make sure to include the Oculus namespace if you're using the Oculus Integration package
using Oculus;

public class PlayerTeleport : MonoBehaviour
{
    MouseLook mouseLook;

    void Start()
    {
        mouseLook = gameObject.GetComponent<MouseLook>();
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One)) // X button on the right controller
        {
            StartCoroutine(TeleportTo(new Vector3(0f, 1.23f, -0.38f)));
        }
        if (OVRInput.GetDown(OVRInput.Button.Two)) // Y button on the right controller
        {
            StartCoroutine(TeleportTo(new Vector3(0f, -46.5f, 116f)));
        }
    }

    IEnumerator TeleportTo(Vector3 position)
    {
        yield return new WaitForSeconds(0.1f); // Delay the teleport by 0.1 seconds
        gameObject.transform.position = position;
    }
}

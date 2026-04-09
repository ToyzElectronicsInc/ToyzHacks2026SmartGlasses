using UnityEngine;

public class ClickToPickup : MonoBehaviour
{
    private bool isHeld = false;
    private float holdDistance = 3f;

    private void OnMouseDown()
    {
        isHeld = true;
    }

    private void OnMouseUp()
    {
        isHeld = false;
    }

    private void Update()
    {
        if (isHeld)
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = holdDistance;

            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            transform.position = worldPos;
        }
    }
}
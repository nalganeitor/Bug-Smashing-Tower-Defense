using UnityEngine;

public class CardController : MonoBehaviour
{
    [HideInInspector] public Vector3 currentMousePosition;
    Camera mainCamera;

    void Starts()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit[] hits = Physics.RaycastAll(ray);

        foreach (var hit in hits)
        {
            if (hit.collider.gameObject.layer != LayerMask.NameToLayer("Table")) continue;
            Debug.DrawLine(start: ray.origin, end: ray.origin + ray.direction * 100, Color.red);

            currentMousePosition = hit.point;

            break;
        }
    }
}

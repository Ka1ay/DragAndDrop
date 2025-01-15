using UnityEngine;

public class ScrollScene : MonoBehaviour
{
    public float scrollSpeed = 10f;
    public float minX = -10f;
    public float maxX = 10f;

    void Update()
    {
        float moveX = Input.GetAxis("Mouse X");

        Vector3 newPosition = transform.position + new Vector3(moveX, 0, 0) * scrollSpeed * Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        transform.position = newPosition;
    }
}



using UnityEngine;

public class TargetController : MonoBehaviour
{
    private bool hasFallen = false;

    void Update()
    {
        if (hasFallen) return;

        float angle = Vector3.Angle(Vector3.up, transform.up);

        if (angle >= 45f)
        {
            Debug.Log("的が倒れました");
            hasFallen = true;
        }
    }
}
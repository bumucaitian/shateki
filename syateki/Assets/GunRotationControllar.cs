using UnityEngine;

public class GunRotationController : MonoBehaviour
{
    [Header("回転速度（度/秒）")]
    [Tooltip("銃口の回転速度を設定（Inspectorで調整可能）")]
    public float rotationSpeed = 90f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // ← → キー: -1 ～ +1
        float vertical = Input.GetAxisRaw("Vertical");     // ↑ ↓ キー: -1 ～ +1

        // 回転角度を計算（時間に依存）
        float xRotation = -vertical * rotationSpeed * Time.deltaTime;
        float yRotation = horizontal * rotationSpeed * Time.deltaTime;

        // オイラー角で回転を加算
        transform.Rotate(xRotation, yRotation, 0f, Space.Self);
    }
}
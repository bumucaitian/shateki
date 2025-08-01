using UnityEngine;

public class GunController : MonoBehaviour
{
    [Header("弾の設定")]
    [Tooltip("発射する弾のプレハブ")]
    public GameObject bulletPrefab;

    [Tooltip("発射する位置")]
    public Transform firePoint;

    [Tooltip("弾の初速 (Z方向)")]
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogWarning("bulletPrefab または firePoint が設定されていません");
            return;
        }

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = firePoint.forward * bulletSpeed;
        }
        else
        {
            Debug.LogWarning("弾に Rigidbody コンポーネントがありません");
        }
    }
}
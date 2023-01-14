using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject projectilePrefab;
    public float projectileSpeed = 20f;

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * projectileSpeed, ForceMode.VelocityChange);
        }
    }
}

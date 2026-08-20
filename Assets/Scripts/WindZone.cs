using UnityEngine;

public class WindZone : MonoBehaviour
{
    public Vector3 windDirection = Vector3.right;
    public float windForce = 5f;
    public float radius = 3f;
    public ParticleSystem windParticles;
    public bool showGizmo = true;
    public bool hideGizmo = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (windParticles != null)
            windParticles.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider hit in hits)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null && !rb.isKinematic)
            {
                rb.AddForce(windDirection * windForce, ForceMode.Force);
            }
        }
    }
    void OnDrawGizmosSelectted()
    {
        if (!showGizmo) return;

        Gizmos.color = new Color(0.2f, 0.6f, 1f, 0.3f);
        Gizmos.DrawSphere(transform.position, radius);
        Gizmos.color = Color.cyan;
        Gizmos.DrawRay(transform.position, windDirection.normalized * radius);
    }
}

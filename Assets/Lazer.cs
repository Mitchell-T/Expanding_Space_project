using UnityEngine;

public class Lazer : MonoBehaviour
{
    [SerializeField]
    private float damage = 10f;
    [SerializeField]
    private float range = 100f;

    private bool c_damage = true;

    public float maxLazerLength = 20;
    private LineRenderer lineRenderer;

    public float width_speed = 0.01f;
    public float start_width = 0.1f;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(1, new Vector3(maxLazerLength, 0, 0));
        gameObject.SetActive(false);
        lineRenderer.startWidth = start_width;
        lineRenderer.endWidth = start_width;
    }
    private void Update()
    {
        print("Lekker Raycasten");

        Shoot();

        if (lineRenderer.startWidth <= 0.5f)
        {
            lineRenderer.startWidth += width_speed;
            lineRenderer.endWidth += width_speed;
        }
        
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.right, out hit, maxLazerLength))
        {
            if (hit.transform.tag != "ENEMYBULLET")
            {
                Debug.Log(hit.transform.name);
                //hit.point
                lineRenderer.SetPosition(1, new Vector3(hit.point.x - transform.position.x + 2, 0, 0));
            }
        }
        else
        {
            lineRenderer.SetPosition(1, new Vector3(maxLazerLength, 0, 0));
        }
    }
}

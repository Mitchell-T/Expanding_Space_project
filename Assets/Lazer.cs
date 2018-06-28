using System.Collections;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    [SerializeField]
    private float damage = 10f;
    [SerializeField]
    private float range = 100f;

    private bool isOnCooldown = false;

    private bool c_damage = true;

    public float maxLazerLength = 14.5f;
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
        //Debug.DrawLine(transform.position, new Vector3(16.5f, transform.position.y, -1)); // correct one with screen end
        Debug.DrawLine(transform.position, new Vector3(14.5f, transform.position.y, -1)); // borked one

        if (Physics.Raycast(transform.position, transform.right, out hit, maxLazerLength))
        {
            if (hit.transform.tag != "ENEMYBULLET")
            {

                if(hit.transform.tag == "ENEMY")
                {
                    Debug.Log(hit.transform.name);
                    HitDetect.Score += 100;

                    Destroy(hit.transform.gameObject);
                }
                
                //hit.point
                lineRenderer.SetPosition(1, new Vector3(hit.point.x - transform.position.x + 5, 0, 0));
            }
        }
        else
        {
            lineRenderer.SetPosition(1, new Vector3(maxLazerLength, 0, 0));
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("ENEMY"))
        {
            Debug.Log("enemy hit");
        }
    }
}

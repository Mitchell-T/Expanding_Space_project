using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCredits : MonoBehaviour
{

    [SerializeField]
    private float speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.up * Time.fixedDeltaTime * speed);
    }

    private void Awake()
    {

        RectTransform rTransform = GetComponent<RectTransform>();

        rTransform.anchoredPosition = new Vector2(0, -424);
        Debug.Break();
    }
}

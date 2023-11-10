using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f,0f,bulletSpeed*Time.deltaTime);
        if (transform.position.z < -10.5f || transform.position.z > 10.5f)
        {
            Destroy(gameObject);
        }
    }
}

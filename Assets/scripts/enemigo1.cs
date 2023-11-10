using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo1 : MonoBehaviour
{
    public Bala bullet;
    [SerializeField] private float enemySpeed = 5f;
    private float timer = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        transform.position += new Vector3((enemySpeed * Time.deltaTime) / 2, 0f, (enemySpeed * Time.deltaTime)/2);
        if (timer < 0)
        {
            Instantiate(bullet).transform.position=new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            timer = 2f;
        }
        if (transform.position.z < -10.5f)
        {
            Destroy(gameObject);
        }
    }
}

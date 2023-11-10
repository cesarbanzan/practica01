using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    public Bala bullet;
    [SerializeField] private float enemySpeed = 5f;
    private bool derecha=true;
    private float timer=4;
    private float timerRandom;
    // Start is called before the first frame update
    void Start()
    {
      
        timerRandom = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerRandom-= Time.deltaTime;
  
            if(derecha)
            {
                transform.position += new Vector3(enemySpeed * Time.deltaTime, 0f, 0f);
                if (timer < 0)
                {
                    derecha = false;
                    timer = 4f;
                }
            }else 
            {
                transform.position -= new Vector3(enemySpeed * Time.deltaTime, 0f, 0f);
            if (timer < 0)
            {
                derecha = true;
                timer = 4f;
            }
        }
            
        
        if (timerRandom <= 0)
        {
            Instantiate(bullet).transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            timerRandom = Random.Range(1, 3);
        }
    }
}

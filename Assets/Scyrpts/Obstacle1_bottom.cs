using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1_bottom : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float x;
    [SerializeField] private float y;

    // Start is called before the first frame update
    void Start()
    {
        float temp = Random.Range(7.0f, 13.0f);
        transform.localScale = new Vector3(1,temp,1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision){
        float temp = Random.Range(7.0f, 13.0f);
        transform.localScale = new Vector3(1,temp,1);
        gameObject.transform.position = new Vector3(x, y, 0.0f);
    }
}

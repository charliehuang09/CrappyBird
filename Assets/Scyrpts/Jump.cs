//charlie: coder
//moore: texture guy
//luke: music guy
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jump_height;
    private Rigidbody2D body;

    private void Awake(){
        //Grab refrences animaotor and rigidbody
        body = GetComponent <Rigidbody2D>();
    }

    private void Update(){
        if (Input.GetKey(KeyCode.Space)){
            Jump_();
        }
    }
    private void Jump_()
    {
        body.velocity = new Vector2(body.velocity.x, jump_height);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        UnityEditor.EditorApplication.isPlaying = false;
    }


}




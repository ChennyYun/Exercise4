using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullBehavior : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    float dashInterval = 2.0f;
    float prevDash = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Dash());
    }
     IEnumerator Dash(){
        if (Time.time > dashInterval + prevDash){
            _rigidbody2D.AddForce(new Vector2(-20, 0));
            yield return new WaitForSeconds(0.1f);
            _rigidbody2D.AddForce(new Vector2(20, 0));
            prevDash = Time.time;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
//a
    //Prefab for instantiating apples
    public GameObject applePrefab;

    //Speed at which the AppleTree moves
    public float speed = 1f;

    //Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    //Chance that the AppleTree will change directions
    public float changeDirChance = 0.1f;

    //Seconds between Apples instantiations
    public float appleDropDelay = 1f;

    // Start is called before the first frame update
    void Start()
    { 
    //Start dropping apples
    Invoke("DropApple", 2f);
    //b
        
    }

    void DropApple() {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    // Update is called once per frame
    void Update()
    { 
    //Basic Movement
    Vector3 pos = transform.position;
    //b
    pos.x += speed * Time.deltaTime;
    //c
    transform.position = pos;
    //d

    //Changing Direction
    if (pos.x < -leftAndRightEdge) {
        speed = Mathf.Abs(speed);
    } else if (pos.x > leftAndRightEdge) {
        speed = -Mathf.Abs(speed);
    //} else if (Random.value < changeDirChance) {
    //    speed *= -1;
    }
    //b

    }

    void FixedUpdate() {
        //Random direction changes are now time-based due to FixedUpdate()
        if (Random.value < changeDirChance) {
            speed *= -1;
        }
    }
}

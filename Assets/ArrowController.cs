using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        this.player=GameObject.Find("player");//불러오고
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-0.1f,0);
        if(transform.position.y<-5.0f){
            Destroy(gameObject);
        }
        Vector2 a=transform.position;
        Vector2 b=this.player.transform.position;
        Vector2 d=a-b;//점과 점 사이의 위치벡터
        float dir=d.magnitude;//거리값 구하기
        float r1=0.5f;
        float r2=1.0f;

        if(dir<r1+r2){
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();

            Destroy(gameObject);
        }
        
    }
}

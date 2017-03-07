using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMesh : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float p = 1.0f;
        Mesh m = new Mesh();
        m.vertices = new Vector3[]
        {
            new Vector3(-5.0f,-5.0f,0.0f),
            new Vector3(-5.0f,5.0f,0.0f),
            new Vector3(5.0f,5.0f,0.0f),

            new Vector3(5.0f,-5.0f,0.0f)
        };
        //버텍스 정보로 삼각형을 만든다.
        m.triangles = new int[] { 0,1,2,0,2,3};// 언제나 3의 배수여야 한다.
        m.uv = new Vector2[]// 텍스처의 UV를 펴주자
        {
            new Vector2(0.0f,0.0f),
            new Vector2(0.0f,p),
            new Vector2(p,p),
            new Vector2(p,0.0f)
        };
        //버텍스 컬러
        m.colors = new Color[]
        {
          Color.red,
          Color.black,
          Color.blue,
          Color.gray
        };  


        GetComponent<MeshFilter>().mesh = m;
       
    }
	
	// Update is called once per frame
	void Update ()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCustomSkinnedMesh : MonoBehaviour {

    //메쉬
    public Material mat;
    //본
    public Transform[] bones;


    // Use this for initialization
    void Start()
    {
        //make mesh
        Mesh m = new Mesh();

        //Make Vertices
        m.vertices = new Vector3[]
     {
           new Vector3(0.0f,0.0f,0.0f),
         new Vector3(-3.0f,3.0f,0.0f),
           new Vector3(3.0f,3.0f,0.0f),
            new Vector3(5.0f,3.0f,0.0f),
                  new Vector3(5.0f,0.0f,0.0f),//4

                   new Vector3(5.0f,2.0f,0.0f),
                    new Vector3(7.0f,2.0f,0.0f),
                     new Vector3(7.0f,0.0f,0.0f),
                      new Vector3(6.0f,-2.0f,0.0f),//8

                   new Vector3(-5.0f,3.0f,0.0f),
                  new Vector3(-5.0f,0.0f,0.0f),
                 new Vector3(-5.0f,2.0f,0.0f),
                    new Vector3(-7.0f,2.0f,0.0f),
                     new Vector3(-7.0f,0.0f,0.0f),
                      new Vector3(-6.0f,-2.0f,0.0f),//14

                      new Vector3(0.0f,3.0f,0.0f),
                      new Vector3(-3.0f,7.0f,0.0f),
                       new Vector3(3.0f,7.0f,0.0f),//17
                       new Vector3(0,7,0),
                       new Vector3(0,10,0),
                       new Vector3(-3,10,0),
                        new Vector3(3,10,0),
                         new Vector3(-1.5f,13,0),
                        new Vector3(1.5f,13,0),//23

                        new Vector3(-3,0,0),//24
                        new Vector3(-1,-2,0),
                        new Vector3(1,-2,0),
                        new Vector3(3,0,0),//27

                        new Vector3(-3,-6,0),
                        new Vector3(-1,-6,0),
                        new Vector3(1,-6,0),
                        new Vector3(3,-6,0),//31
                        new Vector3(-3,-8,0),
                        new Vector3(-1,-8,0),
                        new Vector3(-1,-12,0),
                        new Vector3(-3,-12,0),//35

                        new Vector3(1,-8,0),//36
                        new Vector3(3,-8,0),//37
                        new Vector3(1,-12,0),
                        new Vector3(3,-12,0)//39


     };
        //triangles
        m.triangles = new int[] {
            //몸통
            0, 1, 2,
            2,3,4,
            4,5,6,
            4,6,7,
            4,7,8,
           9,1,10,
           10,12,11,
           10,13,12,
           10,14,12,

           24,0,25,
           25,0,26,
           26,0,27,
           24,1,0,
           0,2,27,

           //머리
            15,16,17,
            16,19,17,
            16,20,19,
            16,19,18,
            18,19,17,
            17,19,21,
            20,22,19,
            19,23,21,

            //다리
            25,28,29,
            28,32,33,
            28,33,29,
            33,34,35,
            26,30,31,
            30,31,36,
            36,31,37,
            36,38,39



        };// 언제나 3의 배수여야 한다.


        //본의 위치를 잡음
        m.bindposes = new Matrix4x4[]
        {
            bones[0].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[1].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[2].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[3].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[4].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[5].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[6].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[7].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[8].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[9].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[10].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[11].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[12].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[13].worldToLocalMatrix*transform.localToWorldMatrix,
            

        };//위치를 잡아줌

        //버텍스와 웨이트를 칠함//////
        m.boneWeights = new BoneWeight[]
        {
             new BoneWeight() {boneIndex0=0,weight0=1f },//묶여있는 본 
             new BoneWeight() {boneIndex0=1,weight0=1f },
             new BoneWeight() {boneIndex0=2,weight0=1f },
             new BoneWeight() {boneIndex0=0,weight0=0f }, 
             new BoneWeight() {boneIndex0=0,weight0=0f },//4

             new BoneWeight() {boneIndex0=0,weight0=0f },
             new BoneWeight() {boneIndex0=0,weight0=0f },
             new BoneWeight() {boneIndex0=0,weight0=0f },
             new BoneWeight() {boneIndex0=0,weight0=0f },//8

             new BoneWeight() {boneIndex0=4,weight0=1f },
             new BoneWeight() {boneIndex0=4,weight0=1f },
             new BoneWeight(){boneIndex0=4,weight0=1f },
             new BoneWeight() {boneIndex0=4,weight0=1f },
             new BoneWeight() {boneIndex0=4,weight0=1f },
             new BoneWeight() {boneIndex0=4,weight0=1f },//14

             new BoneWeight() { boneIndex0=11,weight0=1f },
             new BoneWeight() {boneIndex0=11,weight0=1f },
             new BoneWeight() {boneIndex0=11,weight0=1f },
             new BoneWeight() {boneIndex0=11,weight0=1f },
             new BoneWeight() {boneIndex0=11,weight0=1f },
             new BoneWeight() {boneIndex0=11,weight0=1f },//20

             new BoneWeight() {boneIndex0=11,weight0=1f },
             new BoneWeight() {boneIndex0=11,weight0=1f },
             new BoneWeight() {boneIndex0=11,weight0=1f },
             new BoneWeight() { boneIndex0=5,weight0=0.5f,boneIndex1=1,weight1=0.5f },//
             new BoneWeight() {boneIndex0=5,weight0=1f },
             new BoneWeight() {boneIndex0=6,weight0=1f },//26

            new BoneWeight() { boneIndex0=6,weight0=1f,boneIndex1=2,weight1=0.5f },//
             new BoneWeight() {boneIndex0=8,weight0=1f },
             new BoneWeight() {boneIndex0=8,weight0=1f },
             new BoneWeight() { boneIndex0=7,weight0=1f },
             new BoneWeight() {boneIndex0=7,weight0=1f },
             new BoneWeight() {boneIndex0=8,weight0=1f },//32

             new BoneWeight() { boneIndex0=8,weight0=1f },
             new BoneWeight() {boneIndex0=10,weight0=1f },
             new BoneWeight() {boneIndex0=10,weight0=1f },
             new BoneWeight() { boneIndex0=7,weight0=1f },
             new BoneWeight() {boneIndex0=7,weight0=1f },
             new BoneWeight() {boneIndex0=9,weight0=1f },
             new BoneWeight() {boneIndex0=9,weight0=1f }//39
        };


        Color yRed=new Color(0.85f, 0.13f,0.0f);
        Color newC0 = new Color(0.45f, 0.13f, 0.6f);
        m.colors = new Color[]
        {

          Color.blue, //0
          Color.yellow,
          Color.yellow,
          Color.yellow,
          Color.yellow,
          yRed,
          yRed,
          yRed,
          yRed,
          Color.yellow,
          
          Color.yellow,//10
          Color.blue,
          Color.blue,
          Color.blue,
          Color.blue,
          Color.red,
          Color.grey,
          Color.grey,
          Color.red,
          Color.red,
          
          Color.green,//20
          Color.green,
          Color.green,
          Color.green,
          Color.blue,
          Color.black,
          Color.black,
          Color.black,
          Color.black,
          Color.black,

          Color.black,//30
          Color.black,
          Color.black,
          Color.black,
          newC0,
          newC0,
          Color.black,
          Color.black,
          newC0,
          newC0

        };

        //우리가 만든 매쉬가 들어감
        SkinnedMeshRenderer smr = GetComponent<SkinnedMeshRenderer>();
        smr.sharedMesh = m;
        smr.material = mat;
        smr.bones = bones;
        smr.rootBone = bones[0];
        smr.quality = SkinQuality.Bone1;

    }

    // Update is called once per frame
    void Update () {
		
	}
}

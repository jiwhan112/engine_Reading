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





     };
        //triangles
        m.triangles = new int[] {
            0, 1, 2,
            2,3,4,
            4,5,6,
            4,6,7,
            4,7,8,
           9,1,10,
           10,12,11,
           10,13,12,
           10,14,12

        };// 언제나 3의 배수여야 한다.


        //본의 위치를 잡음
        m.bindposes = new Matrix4x4[]
        {
            bones[0].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[1].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[2].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[3].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[4].worldToLocalMatrix*transform.localToWorldMatrix,
        };//위치를 잡아줌

        //버텍스와 웨이트를 칠함
        m.boneWeights = new BoneWeight[]
        {
             new BoneWeight() { boneIndex0=0,weight0=0f },//묶여있는 본 
             new BoneWeight() {boneIndex0=0,weight1=0f },
             new BoneWeight() {boneIndex0=0,weight1=0f },
              new BoneWeight() { boneIndex0=1,weight0=1f }, 
             new BoneWeight() {boneIndex0=0,weight1=0f },//4

             new BoneWeight() {boneIndex0=0,weight1=0f },
              new BoneWeight() { boneIndex0=0,weight0=0f },
             new BoneWeight() {boneIndex0=0,weight1=0f },
             new BoneWeight() {boneIndex0=0,weight1=0f },//8

              new BoneWeight() { boneIndex0=0,weight0=0f },
             new BoneWeight() {boneIndex0=0,weight1=0f },
             new BoneWeight() {boneIndex0=0,weight1=0f },
              new BoneWeight() { boneIndex0=0,weight0=0f },
             new BoneWeight() {boneIndex0=0,weight1=0f },
             new BoneWeight() {boneIndex0=0,weight1=0f }//14
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

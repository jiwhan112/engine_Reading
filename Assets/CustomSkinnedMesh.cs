using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSkinnedMesh : MonoBehaviour {
    // 코드로 리깅 연습
    public Material mat;
    public Transform[] bones;
	// Use this for initialization
	void Start ()
    {
        Mesh m = new Mesh();


        m.vertices = new Vector3[]
     {
               new Vector3(0.0f,0.0f,0.0f),
               new Vector3(-5.0f,5.0f,0.0f),
               new Vector3(5.0f,5.0f,0.0f)
     };

        m.triangles = new int[] { 0, 1, 2};// 언제나 3의 배수여야 한다.
        
       
        m.bindposes = new Matrix4x4[]
        {
            bones[0].worldToLocalMatrix*transform.localToWorldMatrix,
            bones[1].worldToLocalMatrix*transform.localToWorldMatrix
        };//위치를 잡아줌

        //버텍스와 웨이트를 칠함
        m.boneWeights = new BoneWeight[]
        {
             new BoneWeight() {boneIndex0=0,weight0=1f },// 1버텍스 //움지이지 않음
             new BoneWeight() {boneIndex0=1,weight0=1f },
             new BoneWeight() {boneIndex0=1,weight0=1f }

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
	void Update ()
    {
		
	}
}

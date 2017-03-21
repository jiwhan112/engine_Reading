using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMonster_Steve : MonoBehaviour {

    float meshSize = 0.1f;
    float uvSize = 0.0625f;
    Vector3[] GetVertexArray(Vector3 orgin,Vector3 size)
    {
        return new Vector3[]
        {
             //Front//
         new Vector3(-size.x,-size.y,-size.z)*meshSize+orgin,
         new Vector3(-size.x,size.y,-size.z)*meshSize+orgin,
         new Vector3(size.x, size.y,-size.z)*meshSize+orgin,
         new Vector3(size.x,-size.y,-size.z)*meshSize+orgin,

         //top//
         new Vector3(-size.x,size.y,-size.z)*meshSize+orgin,
         new Vector3(-size.x,size.y,size.z)*meshSize+orgin,
         new Vector3(size.x,size.y,size.z)*meshSize+orgin,
         new Vector3(size.x,size.y,-size.z)*meshSize+orgin,

          //left//
         new Vector3(-size.x,-size.y,-size.z)*meshSize+orgin,//8
         new Vector3(-size.x,size.y,-size.z)*meshSize+orgin,
         new Vector3(-size.x,size.y,size.z)*meshSize+orgin,
         new Vector3(-size.x,-size.y,size.z)*meshSize+orgin,

         //right//
         new Vector3(size.x,-size.y,-size.z)*meshSize+orgin,
         new Vector3(size.x,size.y,-size.z)*meshSize+orgin,
         new Vector3(size.x,size.y,size.z)*meshSize+orgin,
         new Vector3(size.x,-size.y,size.z)*meshSize+orgin,

         //back//
         new Vector3(-size.x,-size.y,size.z)*meshSize+orgin,
         new Vector3(-size.x,size.y,size.z)*meshSize+orgin,
         new Vector3(size.x, size.y,size.z)*meshSize+orgin,
         new Vector3(size.x,-size.y,size.z)*meshSize+orgin,

         //under
         new Vector3(-size.x,-size.y,-size.z)*meshSize+orgin,
         new Vector3(-size.x,-size.y,size.z)*meshSize+orgin,
         new Vector3(size.x, -size.y,size.z)*meshSize+orgin,
         new Vector3(size.x,-size.y,-size.z)*meshSize+orgin
        };
    }
    int[] GetIndexArray(int startIndex)
    {
        int[] tempIndex = new int[]
        {
                0,1,2,
                0,2,3,

                4,5,6,
                4,6,7,

                8,10,9,
                8,11,10,

                12,13,14,
                12,14,15,

                19,18,17,
                19,17,16,

                23,22,21,
                23,21,20
        };
        for (int i = 0; i < tempIndex.Length; ++i)
            tempIndex[i] += startIndex;

            return tempIndex;
    }
    Vector2[] GetUVArray(Vector2 orgin,Vector3 size)
    {
        return new Vector2[]
          {
            orgin+new Vector2(size.z,0f)*uvSize,
            orgin+new Vector2(size.z,size.y)*uvSize,
            orgin+new Vector2(size.z+size.x,size.y)*uvSize,
            orgin+new Vector2(size.z+size.x,0f)*uvSize,

              // Top
            orgin + new Vector2(size.z, size.y) * uvSize,
            orgin + new Vector2(size.z, size.y + size.z) * uvSize,
            orgin + new Vector2(size.z + size.x, size.y + size.z) * uvSize,
            orgin + new Vector2(size.z + size.x, size.y) * uvSize,
            // Left
            orgin + new Vector2(size.z + size.x, 0f) * uvSize,
            orgin + new Vector2(size.z + size.x, size.y) * uvSize,
            orgin + new Vector2(size.z * 2 + size.x, size.y) * uvSize,
            orgin + new Vector2(size.z * 2 + size.x, 0f) * uvSize,
            // Right
            orgin + new Vector2(size.z, 0f) * uvSize,
            orgin + new Vector2(size.z, size.y) * uvSize,
            orgin + new Vector2(0f, size.y) * uvSize,
            orgin + new Vector2(0f, 0f) * uvSize,
            // Back
            orgin + new Vector2((size.z + size.x) * 2f, 0f) * uvSize,
            orgin + new Vector2((size.z + size.x) * 2f, size.y) * uvSize,
            orgin + new Vector2(size.z * 2 + size.x, size.y) * uvSize,
            orgin + new Vector2(size.z * 2 + size.x, 0f) * uvSize,
            // Bottom
            orgin + new Vector2(size.z + size.x, size.y) * uvSize,
            orgin + new Vector2(size.z + size.x, size.y + size.z) * uvSize,
            orgin + new Vector2(size.z + size.x * 2, size.y + size.z) * uvSize,
            orgin + new Vector2(size.z + size.x * 2, size.y) * uvSize

      };
    }


private void Start()
    {
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh m = new Mesh();


        // Head
        Vector3[] headVArr = GetVertexArray(new Vector3(0f, 1.4f, 0f), new Vector3(2f, 2f, 2f));
        int[] headTArr = GetIndexArray(0);
        Vector2[] headUArr = GetUVArray(new Vector2(0f, 0.75f), new Vector3(2f, 2f, 2f));

        // LHands
        Vector3[] lhandVArr = GetVertexArray(new Vector3(-0.3f, 0.9f, 0f), new Vector3(1f, 3f, 1f));
        int[] lhandTArr = GetIndexArray(24);
        Vector2[] lhandUArr = GetUVArray(new Vector2(0.5f, 0f), new Vector3(1f, 3f, 1f));

        // RHands
        Vector3[] rhandVArr = GetVertexArray(new Vector3(0.3f, 0.9f, 0f), new Vector3(1f, 3f, 1f));
        int[] rhandTArr = GetIndexArray(48);
        Vector2[] rhandUArr = GetUVArray(new Vector2(0.625f, 0.5f), new Vector3(1f, 3f, 1f));

        // Body
        Vector3[] bodyVArr = GetVertexArray(new Vector3(0f, 0.9f, 0f), new Vector3(2f, 3f, 1f));
        int[] bodyTArr = GetIndexArray(72);
        Vector2[] bodyUArr = GetUVArray(new Vector2(0.25f, 0.5f), new Vector3(2f, 3f, 1f));

        // LLeg
        Vector3[] llegVArr = GetVertexArray(new Vector3(-0.1f, 0.3f, 0f), new Vector3(1f, 3f, 1f));
        int[] llegTArr = GetIndexArray(96);
        Vector2[] llegUArr = GetUVArray(new Vector2(0.25f, 0f), new Vector3(1f, 3f, 1f));

        // RLeg
        Vector3[] rlegVArr = GetVertexArray(new Vector3(0.1f, 0.3f, 0f), new Vector3(1f, 3f, 1f));
        int[] rlegTArr = GetIndexArray(120);
        Vector2[] rlegUArr = GetUVArray(new Vector2(0f, 0.5f), new Vector3(1f, 3f, 1f));

        List<Vector3> VerticesList = new List<Vector3>();
        VerticesList.AddRange(headVArr);
        VerticesList.AddRange(lhandVArr);
        VerticesList.AddRange(rhandVArr);
        VerticesList.AddRange(bodyVArr);
        VerticesList.AddRange(llegVArr);
        VerticesList.AddRange(rlegVArr);

        List<int> TriangleList = new List<int>();
        TriangleList.AddRange(headTArr);
        TriangleList.AddRange(lhandTArr);
        TriangleList.AddRange(rhandTArr);
        TriangleList.AddRange(bodyTArr);
        TriangleList.AddRange(llegTArr);
        TriangleList.AddRange(rlegTArr);

        List<Vector2> UVList = new List<Vector2>();
        UVList.AddRange(headUArr);
        UVList.AddRange(lhandUArr);
        UVList.AddRange(rhandUArr);
        UVList.AddRange(bodyUArr);
        UVList.AddRange(llegUArr);
        UVList.AddRange(rlegUArr);

        m.vertices = VerticesList.ToArray();
        m.triangles = TriangleList.ToArray();
        m.uv = UVList.ToArray();

        mf.sharedMesh = m;

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bingle : MonoBehaviour
{
    public Transform center; // 중심축 오브젝트
    public float orbitSpeed = 10f; // 공전 속도
    public Vector3 orbitAxis = Vector3.up; // 공전 축 (기본값은 Y축)

    void Update()
    {
        if (center != null)
        {
            // 중심축 주위를 공전하도록 회전
            transform.RotateAround(center.position, orbitAxis, orbitSpeed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //5호관 외부
    public void GotoS1()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    //5호관 1층 로비
    public void GotoS2()
    {
        transform.position = new Vector3(0, 0, -35);
    }
    //5호관 복도
    public void GotoS3()
    {
        transform.position = new Vector3(-35, 0, -35);
    }
    //5호관 102 강의실
    public void GotoS4()
    {
        transform.position = new Vector3(-35, 0, -70);
    }
    //5호관 왼쪽 복도
    public void GotoS5()
    {
        transform.position = new Vector3(-70, 0, -35);
    }
    //5호관 103 강의실
    public void GotoS6()
    {
        transform.position = new Vector3(-70, 0, -70);
    }
    //5호관 왼쪽 출구
    public void GotoS7()
    {
        transform.position = new Vector3(-70, 0, 0);
    }
    //5호관 2층
    public void GotoS8()
    {
        transform.position = new Vector3(-140, 0, -35);
    }
    //5호관 2층 울산창조센터
    public void GotoS9()
    {
        transform.position = new Vector3(-175, 0, -35);
    }
    //1호관 외부
    public void GotoS10()
    {
        transform.position = new Vector3(-140, 0, 0);
    }
  //로비
    public void GotoS11()
    {
        transform.position = new Vector3(70, 0, 0);
    }
  //행정관 외부
    public void GotoS12()
    {
        transform.position = new Vector3(-140, 0, -105);
    }
  //행정관 로비
    public void GotoS13()
    {
        transform.position = new Vector3(-175, 0, -105);
    }
  //도서관본관 외부
    public void GotoS14()
    {
        transform.position = new Vector3(-140, 0, -70);
    }
}

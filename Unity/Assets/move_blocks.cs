using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//更新履歴
// ver     内容
// 1.0　　マウスクリックでブロックを移動させる
// 1.1    マウス右クリックでブロックを90度回転させる

//  >> Update Start ver1.0
public class move_blocks : MonoBehaviour
{

    private bool selected;


    void Update()
    {
        //マウスがクリックされている間、座標を更新し続ける
        if (selected == true)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
//  >> Update Start ver1.1
            //右クリックがされた場合、画像を90度回転させる
        if (Input.GetMouseButtonDown(1))
            {
                　transform.Rotate(new Vector3(0, 0, 90));
            }
 // << Update End   ver1.1
        }

        //クリックされていない場合、座標の更新を行わない
        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
    }

    //マウスクリックされた場合
    void OnMouseOver()
    {

        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
        }
    }


}
// << Update End ver1.0
 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClickEventHomepage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private RaycastHit ObjHit;
    private Ray CustomRay;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
#if UNITY_ANDROID || UNITY_IPHONE
            //移动端
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
#else
            //PC端
            if (EventSystem.current.IsPointerOverGameObject())
#endif
            {
                Debug.Log("当前点击在UI上" + EventSystem.current.currentSelectedGameObject);
            }
            else
            {
                CustomRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                Debug.DrawLine(CustomRay.origin, ObjHit.point, Color.red, 2);
                if (Physics.Raycast(CustomRay, out ObjHit, 100))
                {
                    if (ObjHit.collider.gameObject != null)
                    {
                        Debug.Log("Click Object:" + ObjHit.collider.gameObject);
                        if (ObjHit.collider.gameObject == GameObject.Find("electronics_factory"))
                        {
                            Debug.Log("Changing scene to factory view");
                            SceneManager.LoadScene("Factory");
                        }
                        if (ObjHit.collider.gameObject == GameObject.Find("attackBot"))
                        {
                            Debug.Log("Changing scene to factory view");
                            SceneManager.LoadScene("Robot");
                        }
                    }
                }
                else
                {
                    Debug.Log("Click Null");
                }
            }
        }
    }
    
}

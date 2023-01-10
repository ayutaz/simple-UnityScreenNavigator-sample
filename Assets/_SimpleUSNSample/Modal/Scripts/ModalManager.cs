using System;
using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Modal;

namespace _SimpleUSNSample.Modal
{
    public class ModalManager : MonoBehaviour
    {
        [SerializeField] private ModalContainer modalContainer;

        private void Update()
        {
            // 表示
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                modalContainer.Push("ModalView1", true);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                modalContainer.Push("ModalView2", true);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                modalContainer.Push("ModalView3", true);
            }
            
            // 非表示
            if (Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.LeftShift))
            {
                
            }else if (Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.LeftShift))
            {
                
            }else if (Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.LeftShift))
            {
                
            }
        }
    }
}
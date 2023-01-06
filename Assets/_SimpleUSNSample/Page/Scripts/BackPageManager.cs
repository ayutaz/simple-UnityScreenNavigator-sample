using System;
using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Page;

namespace _SimpleUSNSample.Page
{
    public class BackPageManager : MonoBehaviour
    {
        [SerializeField] private PageContainer pageContainer;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                pageContainer.Push("View0", true);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                pageContainer.Push("View1", true);
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                pageContainer.Pop(true);
            }
        }
    }
}
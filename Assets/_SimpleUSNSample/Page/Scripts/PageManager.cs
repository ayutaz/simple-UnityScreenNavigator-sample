using System;
using System.Threading.Tasks;
using UniRx;
using UnityEngine;
using UnityEngine.InputSystem.Utilities;
using UnityScreenNavigator.Runtime.Core.Page;
using Observable = UniRx.Observable;

namespace _SimpleUSNSample.Page
{
    public class PageManager : MonoBehaviour
    {
        [SerializeField] private PageContainer pageContainer;

        private void Start()
        {
            Observable.Timer(TimeSpan.Zero, TimeSpan.FromSeconds(3f))
                .Subscribe(async time =>
                {
                    var handle1 = pageContainer.Push($"View{Mathf.RoundToInt(time) % 2}", true);
                    await handle1.Task;
                    await Task.Delay(TimeSpan.FromSeconds(2f),destroyCancellationToken);
                    pageContainer.Pop(true);
                }).AddTo(this);
        }
    }
}
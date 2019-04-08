using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class ScreenLaunch : MonoBehaviour
    {

        [SerializeField] private MaskableGraphic[] _elements;
        [SerializeField] private GameObject _openNext;
        [SerializeField] private float _timing;

        private void Start()
        {
            MaskableGraphic e = null;
            foreach (var elem in _elements)
            {
                e = elem;
                elem.DOFade(1f, _timing / 2f).OnComplete(() => { elem.DOFade(0f, _timing / 2f); });
            }

            StartCoroutine(WaitUntilStop(e));
        }

        private IEnumerator WaitUntilStop(MaskableGraphic lastItem)
        {
            yield return new WaitUntil(() => lastItem == null || !DOTween.IsTweening(lastItem));
            gameObject.SetActive(false);
            _openNext.SetActive(true);
        }
    }
}

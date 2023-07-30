using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class MenuManagerUI : MonoBehaviour
    {
        [SerializeField] private bool startWithDefault = true;
        [SerializeField] private GameObject defaultView;
        [SerializeField] private GameObject viewContainer;
        
        private readonly List<GameObject> _views = new();

        private void Start()
        {
            foreach (Transform child in viewContainer.transform)
            {
                _views.Add(child.gameObject);
            }
            
            if(startWithDefault)
                ChangeView(defaultView);
        }

        public void ChangeView(GameObject viewGameObject)
        {
            foreach (var view in _views)
            {
                view.SetActive(false);
            }
            
            viewGameObject.SetActive(true);
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Escape))
                ChangeView(defaultView);
        }
    }
}
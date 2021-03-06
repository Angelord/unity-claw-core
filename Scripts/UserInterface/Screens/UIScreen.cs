﻿﻿using UnityEngine;

namespace Claw.UserInterface.Screens {
    public abstract class UIScreen : MonoBehaviour {

        private UIScreenManager screenManager;
        
        public void Initialize(UIScreenManager screenManager) {
            this.screenManager = screenManager;
            gameObject.SetActive(false);
            OnInitialize();
        }
        
        public void Show() {
            gameObject.SetActive(true);
            OnShow();
        }

        public void Hide() {
            gameObject.SetActive(false);
            OnHide();
        }

        protected T OpenScreen<T>() where T : UIScreen {
            return screenManager.Push<T>();
        }

        protected void ReturnToPrevious() {
            screenManager.Pop();
        }

        /// <summary> Called on Start. Use to run any initialization code. </summary>
        protected virtual void OnInitialize() { }

        /// <summary> Called when the screen is being opened. Use to subscribe to events.</summary>
        protected virtual void OnShow() { }

        /// <summary> Called when the screen is being closed. Use to unsubscribe from events.</summary>
        protected virtual void OnHide() { }
    }
}
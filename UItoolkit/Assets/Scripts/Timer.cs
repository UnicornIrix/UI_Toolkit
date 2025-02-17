using UnityEngine.UIElements;
using UnityEngine;
using Unity.VisualScripting;
using System;
using System.Net.Http.Headers;

public class Timer : VisualElement
{
    private Label timer_label;
    public Timer(){
        timer_label = new Label();
        timer_label.text = "00:00:00";  
        timer_label.style.fontSize = 50;
        timer_label.style.color = Color.white;
        Add(timer_label);

        RegisterCallback<AttachToPanelEvent>(evt =>
        {
            if(evt.destinationPanel.contextType == ContextType.Player && Application.isPlaying){ // non funge
                Start();
            }
        });

        Application.onBeforeRender += Update;
    }
        public new class UxmlFactory : UxmlFactory<Timer, UxmlTraits>{}
        public new class UxmlTraits : VisualElement.UxmlTraits{}
        
    private void Start(){
        Debug.Log("playerr");
    }

    private void Update(){
        if(Application.isPlaying) {
            timer_label.text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.Input)]
    [Tooltip("Detects mouse scroll wheel movement and sends events.")]
    public class GetMouseScroll : FsmStateAction
    {
        [Tooltip("Event to send if scrolled up.")]
        public FsmEvent scrollUpEvent;
        
        [Tooltip("Event to send if scrolled down.")]
        public FsmEvent scrollDownEvent;
        
        public override void OnUpdate()
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel");
            
            if (scroll > 0f && scrollUpEvent != null)
            {
                Fsm.Event(scrollUpEvent);
            }
            else if (scroll < 0f && scrollDownEvent != null)
            {
                Fsm.Event(scrollDownEvent);
            }
        }
    }
}

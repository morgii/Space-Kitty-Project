using UnityEngine;
using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("Custom")]
    [Tooltip("Find all GameObjects with the given tag and store them in a GameObject array variable.")]
    public class FindGameObjectsWithTagArray : FsmStateAction
    {
        [RequiredField]
        [Tooltip("Tag to search for.")]
        public FsmString tag;

        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("Store results in a GameObject array.")]
        public FsmArray storeGameObjects;

        [Tooltip("Event to send when found.")]
        public FsmEvent foundEvent;

        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset()
        {
            tag = "Untagged";
            storeGameObjects = null;
            foundEvent = null;
            everyFrame = false;
        }

        public override void OnEnter()
        {
            DoFind();
            if (!everyFrame)
                Finish();
        }

        public override void OnUpdate()
        {
            DoFind();
        }

        void DoFind()
        {
            if (storeGameObjects == null || !storeGameObjects.IsNone)
            {
                GameObject[] objs = GameObject.FindGameObjectsWithTag(tag.Value);
                storeGameObjects.Values = objs;
                if (foundEvent != null)
                {
                    Fsm.Event(foundEvent);
                }
            }
        }
    }
}

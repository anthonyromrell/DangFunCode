using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "DangFun/Asset")]
public class SObject : ScriptableObject
{
   public UnityEvent Event;

   private void OnEnable()
   {
      Event.Invoke();
   }
}

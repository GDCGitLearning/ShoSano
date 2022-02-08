using UnityEngine;

// Don't implement Start(), Update(), etc... in a class that inherited from this class
public class SystemBehaviour : MonoBehaviour
{
    public virtual void Initialize() { }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionQueue : ScriptableObject
{
	public List<GameObject> actionStack = new List<GameObject> ();
	
	void OnCollisionEnter (Collision col) {
		actionStack.Add(col.gameObject);
	}

	void OnCollisionExit (Collision col) {
		actionStack.Remove (col.gameObject);
	}
    
    public GameObject resolve() {
        GameObject result = null;
        int largestPriority = -1;
        for (int i=0; i<actionStack.Length; i++) {
            if (actionStack[i].card.priority >= largestPriority) {
                largestPriority = actionStack[i].card.priority;
                result = actionStack[i];
            }
        }
        return result;
    }
}

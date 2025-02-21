using UnityEngine;

public class ResolveTurn : MonoBehaviour
{
    public GameObject actionQueue1;
    public GameObject actionQueue2;
    public GameObject actionQueue3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resolve() {
        // generate bot plays
        int[] cardPlays = new int[] {0, 1, 2};
        reshuffle(cardPlays);
        int[] positionPlays = new int[] {0, 1, 2};
        reshuffle(positionPlays);
        // for (int i=0; i<2; i++) {
        //     switch(positionPlays[i]) {
        //         case 0:
        //             actionQueue1.actionStack.Add()
        //             break;
        //         case 1:
        //             break;
        //         default:
        //             actionQueue3.actionStack.Add()
        //     }
        // }
        // for (int i=0; i<3; i++) {

        // }
    }

    private void reshuffle(int[] a)
    {
        // Knuth shuffle algorithm
        for (int t = 0; t < a.Length; t++ )
        {
            int tmp = a[t];
            int r = Random.Range(t, a.Length);
            a[t] = a[r];
            a[r] = tmp;
        }
    }
}

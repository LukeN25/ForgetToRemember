using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CupGame : MonoBehaviour
{
    int count = 0; 
    public TMP_Text counterTxt;
    
    public GameObject[] cups; 
    public Image die; 
    public float MixerUp;
    public int rounds = 3;//rounds to mix

    bool finishedRevealing;
    
    void Start()
    {
        count = 0; 
        counterTxt.text = "Counter: 0"; 
        die.enabled = false; 
        StartCoroutine(CupMixer());
    }

    public IEnumerator CupMixer(float wfs = .3f)
    {
        Vector3[] ts = new Vector3[cups.Length]; 
        for (int i = 0; i < cups.Length; i++) ts[i] = cups[i].transform.position.Copy();
        foreach (GameObject c in cups) StartCoroutine(RevealCup(c)); 
        yield return new WaitForSecondsRealtime(1);//reveal the cups
        
        for (int i = 0; i < rounds; i++)
        {
            Vector3[] randoms = ts.Randomize().Copy();
            foreach (GameObject c in cups) 
            { 
                StartCoroutine(c.TranslateOverTime(80, Vector3.up * MixerUp)); c.Button().interactable = false; 
            }
            yield return new WaitForSecondsRealtime(wfs);
            
            for (int k = 0; k < ts.Length; k++) 
            { 
                Vector3 movement = new Vector3(randoms[k].x - cups[k].transform.position.x, -MixerUp); StartCoroutine(cups[k].TranslateOverTime(80, movement)); 
            }
            yield return new WaitForSecondsRealtime(wfs);
        }
        
        foreach (GameObject c in cups) c.Button().interactable = true;
    }
    public Sprite standing, laying;
    public IEnumerator RevealCup(GameObject cup)
    {
        finishedRevealing = false; 
        cup.SetActive(true); 
        cup.GetComponent<Image>().sprite = laying; 
        die.enabled = true;
        yield return new WaitForSecondsRealtime(1); 
        cup.GetComponent<Image>().sprite = standing; 
        die.enabled = false; 
        finishedRevealing = true;
    }
    public void UpdateCounter() => counterTxt.text = "Counter " + count;
    public void ClickedCup(GameObject g)
    {
        StartCoroutine(RevealCup(g)); 
        if (g.HasComponentInChildren<Image>()) 
        { 
            count++; 
            UpdateCounter(); 
            StartCoroutine(CounterAnimation(Color.green)); 
        }
        else 
        { 
            count = 0; 
            UpdateCounter(); 
            StartCoroutine(CounterAnimation(Color.red)); 
        }
    }
    public IEnumerator CounterAnimation(Color c) 
    { 
        counterTxt.color = c;
        yield return new WaitForSecondsRealtime(.5f);
        counterTxt.color = Color.white; 
    }
}
public static class Useful
{
    public static Button Button(this GameObject g) => g.GetComponent<Button>();
    public static Vector3[] Positions(this GameObject[] gs)
    {
        List<Vector3> vs = new List<Vector3>(); 
        foreach (GameObject g in gs) 
        { 
            Vector3 v = g.transform.position;
            vs.Add(new Vector3(v.x, v.y, v.z)); 
        }
        return vs.ToArray();
    }
    public static T[] Randomize<T>(this T[] arr)
    {
        List<T> ts = new List<T>(); 
        List<int> index = new List<int>(), ni = new List<int>();//ni- new indexes
        for (int i = 0; i < arr.Length; i++) 
            index.Add(i);

        while (index.Count > 0)
        {
            int ind = Random.Range(0, index.Count);
            ni.Add(index[ind]);
            index.RemoveAt(ind);
        }
        foreach (int n in ni) ts.Add(arr[n]); return ts.ToArray();
    }
    public static bool HasComponentInChildren<T>(this GameObject g, bool ParentHasToo = true) 
    { 
        try 
        { 
            T[] x = g.GetComponentsInChildren<T>();
            if (x == null || x.Length < 2 && ParentHasToo) int.Parse("sd");
            return true;
        } 
        catch 
        { 
            return false; 
        } 
    }

    public static Vector3 Copy(this Vector3 v) => new Vector3(v.x, v.y, v.z);
    public static Vector3[] Copy(this Vector3[] vs) 
    { 
        List<Vector3> nv = new List<Vector3>(); 
        foreach (Vector3 v in vs) nv.Add(new Vector3(v.x, v.y, v.z)); 
        return nv.ToArray(); 
    }
    public static void SetActive(this GameObject[] gs, bool b) 
    { 
        foreach (GameObject g in gs) g.SetActive(b); 
    }
    public static IEnumerator TranslateOverTime(this GameObject g, int milliseconds, Vector3 movement)
    {
        for (int i = 0; i < milliseconds; i++)
        {
            g.transform.Translate(movement / milliseconds, Space.World);
            yield return new WaitForSecondsRealtime(.001f);
        }
    }
    public static IEnumerator TranslateOverTime(this GameObject g, Vector3 target, int milliseconds)
    {
        Vector3 movement = target - g.transform.position;
        for (int i = 0; i < milliseconds; i++)
        {
            g.transform.Translate(target / milliseconds, Space.World); 
            yield return new WaitForSecondsRealtime(.001f);
        }
    }
}

 using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class TimerActivator : MonoBehaviour
{
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var document = GetComponent<UIDocument>();
        document.rootVisualElement.Clear();
        //document.visualTreeAsset = ScriptableObject.CreateInstance<VisualTreeAsset>(); // visualtreeasset è il risultato dell'importer di unity quando vede un file UXML
        

        var timer = new Timer();
        document.rootVisualElement.Add(timer);// rootvisualelement punta alla root del visualtreeasset che abbiamo appena creato
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

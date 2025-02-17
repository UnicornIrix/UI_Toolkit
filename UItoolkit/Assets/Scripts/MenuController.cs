using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class MenuController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var document = GetComponent<UIDocument>();
        var root = document.rootVisualElement;
        var background = root.Q<VisualElement>(name: "background");
        /*Debug.Log(root.Query<VisualElement>(classes: "unity-button").ToList().Count);*/
        var title = root.Q<Label>(name: "Mars");
        title.text = "MARS";

        var new_button = new Button(); 
        new_button.AddToClassList("menuButtons");
        new_button.text = "ci sono anch'io";
        new_button.RegisterCallback<MouseEnterEvent>(evt => //geometry, attach, clickEvent...
        {
            Debug.Log("cliccato");
        }); 
        background.Add(new_button);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

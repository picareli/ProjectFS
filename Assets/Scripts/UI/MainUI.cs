using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace ProjectFS
{
    public class MainUI : MonoBehaviour
    {
        /// <summary>
        /// Field for the property UIDocument.
        /// </summary>
        [SerializeField]
        private UIDocument _uiDocument;
        /// <summary>
        /// The UIDocument that is being manipulated by the MainUI class.
        /// </summary>
        public UIDocument UIDocument { get { return _uiDocument; } private set { _uiDocument = value; } }
        /// <summary>
        /// Field for the property StyleSheet.
        /// </summary>
        [SerializeField]
        private StyleSheet _styleSheet;
        /// <summary>
        /// The StyleSheet used by this UIDocument to style each VisualElement.
        /// </summary>
        public StyleSheet StyleSheet { get { return _styleSheet; } private set { _styleSheet = value; } }

        private void Start()
        {
            StartCoroutine(RenderUIElements());
        }

        private void OnValidate()
        {
            if (Application.isPlaying)
            {
                return;
            }

            StartCoroutine(RenderUIElements());
        }

        /// <summary>
        /// Renders each VisualElement that will compose this UI.
        /// </summary>
        private IEnumerator RenderUIElements()
        {
            yield return null;

            /// root element of the doc
            var root = UIDocument.rootVisualElement;

            root.Clear();

            root.styleSheets.Add(StyleSheet);

            /// desktop
            var desktop = Create("desktop");

            /// icons
            desktop.Add(CreateIconButton("Contracts"));

            desktop.Add(CreateIconButton("Hangar"));

            desktop.Add(CreateIconButton("Profile"));

            root.Add(desktop);

            /// taskbar
            var taskbar = Create("taskbar");

            var startButton = Create<Button>("button", "start-button");

            startButton.text = "Start";

            taskbar.Add(startButton);

            root.Add(taskbar);
        }

        /// <summary>
        /// Creates a new Icon for the Desktop.
        /// </summary>
        private Button CreateIconButton(string itemName)
        {
            var myButton = Create<Button>();

            var myButtonIcon = Create<Image>();

            myButton.Add(myButtonIcon);

            var myButtonLabel = Create<Label>();

            myButtonLabel.text = itemName;

            myButton.Add(myButtonLabel);

            return myButton;
        }

        /// <summary
        /// Creates a new VisualElement with the given classNames.
        /// </summary>
        private VisualElement Create(params string[] classNames)
        {
            return Create<VisualElement>(classNames);
        }

        /// <summary>
        /// Generic Create method.
        /// </summary>
        private T Create<T>(params string[] classNames) where T : VisualElement, new()
        {
            var element = new T();

            foreach (var className in classNames)
            {
                element.AddToClassList(className);
            }

            return element;
        }
    }
}
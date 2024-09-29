using UnityEngine;
using UnityEngine.UI;

public class NextLevelButton : ButtonListener
{
    [SerializeField] private Image _image;
    [SerializeField] private Sprite _menuButtonSprite;

    protected override void HandleAwake()
    {
        if (!Level.IsLast) return;

        _image.sprite = _menuButtonSprite;
        _image.SetNativeSize();
    }

    protected override void Listen()
    {
        if (!Level.TryNext())
        {
            SceneLoad.Load("Menu");
            return;
        }

        SceneLoad.Reload();
    }
}
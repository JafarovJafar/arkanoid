using Shafir.Arkanoid.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using VContainer;

namespace Shafir.Arkanoid.App
{
    public class LoadContentEntryPoint : MonoBehaviour
    {
        [Inject] private SceneLoader _sceneLoader;

        private void Start() =>
            _sceneLoader.LoadScene(Scenes.LoadingScreen, LoadSceneMode.Additive);
    }
}
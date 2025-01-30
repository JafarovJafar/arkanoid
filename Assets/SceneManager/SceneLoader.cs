using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Shafir.Arkanoid.SceneManagement
{
    public class SceneLoader
    {
        private MonoBehaviourHolder _monoBehaviourHolder;

        public SceneLoader(MonoBehaviourHolder monoBehaviourHolder) =>
            _monoBehaviourHolder = monoBehaviourHolder;

        public void LoadScene(Scenes scene) =>
            SceneManager.LoadScene(scene.ToString());

        public void LoadScene(Scenes scene, LoadSceneMode mode) =>
            SceneManager.LoadScene(scene.ToString(), mode);

        public void LoadScene(Scenes scene, LoadSceneMode mode, Action<float, float> loadProgress = null) =>
            _monoBehaviourHolder.StartCoroutine(LoadSceneAsyncCoroutine(scene.ToString(), mode, loadProgress));

        private IEnumerator LoadSceneAsyncCoroutine(string sceneName, LoadSceneMode mode,
            Action<float, float> loadProgress = null)
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName, mode);

            while (!operation.isDone)
            {
                loadProgress?.Invoke(operation.progress, 1f);
                yield return null;
            }

            loadProgress?.Invoke(1f, 1f);
        }
    }
}